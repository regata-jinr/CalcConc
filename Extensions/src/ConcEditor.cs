using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Extensions
{
    public partial class ConcEditor : Form
    {
        public static string lang { get; set; }
        private List<Sample> _inputSamples;
        public List<Sample> InputSamples
        {
            get
            {
                return _inputSamples;
            }

            set
            {
                _inputSamples = value;
            }
        }
        private Sample _averageSample;

        private Dictionary<string, Type> cols;

       

        private void ApplyLangSettings()
        {
            if (lang == "English")
            {
                Text = "Просмотр файлов концентраций";
                LabelConcEditorResult.Text = "Усредненные значения";
                LabelConcEditorSource.Text = "Исходные значения";
                ButtonConcEditorHighLight.Text = "Показать значения превышающие n*sigma.  n = ";
                ButtonConcEditorSave.Text = "Сохранить как";
                buttonExportToExcel.Text = "Экспорт в excel";
                cols.Add("Файл", typeof(string));
                cols.Add("Образец", typeof(string));
                cols.Add("Вес, гр", typeof(double));
                cols.Add("Элемент", typeof(string));
                cols.Add("Концентранция, uг/гр", typeof(double));
                cols.Add("Погрешность, %", typeof(double));
                cols.Add("МДА, uг/гр", typeof(double));
            }
            else
            {
                Text = "Concentration files editor";
                LabelConcEditorResult.Text = "Average values";
                LabelConcEditorSource.Text = "Sources";
                ButtonConcEditorHighLight.Text = "Show value with deviation more than n*sigma.  n = ";
                buttonExportToExcel.Text = "Export to excel";
                ButtonConcEditorSave.Text = "Save as";
                cols.Add("File", typeof(string));
                cols.Add("Sample", typeof(string));
                cols.Add("Weight, gr", typeof(double));
                cols.Add("Element", typeof(string));
                cols.Add("Concentration, ug/gr", typeof(double));
                cols.Add("Error, %", typeof(double));
                cols.Add("MDC, ug/gr", typeof(double));
            }
        }

       
        public ConcEditor()
        {
            InitializeComponent();

            cols = new Dictionary<string, Type>();
            

            ApplyLangSettings();


        }

        private Sample CombineSample(ref List<Sample> samples)
        {
            string names = "";

            List<Element> elements = new List<Element>();

            foreach (var s in samples)
            {
                names += $"{s.Name}, ";
                elements.AddRange(s.Elements);

            }

            return new Sample(names, samples[0].Type, samples[0].GRSName, 0.0, false, elements, samples[0].OriginalDirectory, "", "", samples[0].FileHead.Replace(samples[0].Name, names));
        }

        private void AverageElementsValues(ref List<Sample> samples)
        {
            var sample = CombineSample(ref samples);
            var els = sample.Elements.GroupBy(el => new { elName = el.Name }).Select(newEl => new Element()
            {
                Name =  newEl.Key.elName,
                Concentration = newEl.Average(a => a.Concentration),
                Error = newEl.Error(a => a.Error),
                MDA = newEl.Average(a => a.MDA)
            }).ToList();

            _averageSample = new Sample(sample.Name, sample.Type, sample.GRSName, sample.Weight, sample.IsBlank, els, sample.OriginalDirectory, sample.OriginalFileName, "Average.con", sample.FileHead);
        }


        private DataTable ConvertSamplesToTable(ref List<Sample> samples, ref Dictionary<string, Type> columns, bool isResult = false)
        {
            var dt = new DataTable();
            Debug.WriteLine("Start adding data to table sources");
            foreach (var col in columns) dt.Columns.Add(col.Key, col.Value);

            foreach (Sample samp in samples)
            {
                foreach (Element el in samp.Elements)
                {
                    Debug.WriteLine("Adding row:");
                    Debug.WriteLine($"{columns}");
                    if (!isResult) //with smells...
                        dt.Rows.Add(samp.OriginalFileName, samp.Name, samp.Weight, el.Name, el.Concentration, el.Error, el.MDA);
                    else
                        dt.Rows.Add(el.Name, el.Concentration, el.Error, el.MDA);
                }
            }
            return dt;
        }

        private void ConcEditor_Shown(object sender, EventArgs e)
        {
            
            DataGridViewConcValEditorSource.DataSource = ConvertSamplesToTable(ref _inputSamples, ref cols);
            DataGridViewConcValEditorSource.Columns[4].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorSource.Columns[5].DefaultCellStyle.Format = "f2";
            DataGridViewConcValEditorSource.Columns[6].DefaultCellStyle.Format = "E2";

            AverageElementsValues(ref _inputSamples);
            var newResList = new List<Sample>() { _averageSample };
            var newColumns = new Dictionary<string, Type>() { { "Element", typeof(string) }, { "Concentration, ug/gr", typeof(double) }, { "Error, %", typeof(double) }, { "MDC, ug/gr", typeof(double) } };
            DataGridViewConcValEditorResult.DataSource = ConvertSamplesToTable(ref newResList, ref newColumns, true);
            DataGridViewConcValEditorResult.Columns[1].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorResult.Columns[2].DefaultCellStyle.Format = "f2";
            DataGridViewConcValEditorResult.Columns[3].DefaultCellStyle.Format = "E2";


            //var resT = from dt in srcsTable.AsEnumerable()
            //           group dt by new
            //           {
            //               element = dt.Field<string>(cols.ElementAt(3).Key)
            //           } into res
            //           select new
            //           {
            //               element = res.Key.element,
            //               Concentration = res.Average(p => p.Field<double>(cols.ElementAt(4).Key)),
            //               Error = res.Error(p => p.Field<double>(cols.ElementAt(5).Key)),

            //               MDA = res.Min(p=>p.Field<double>(cols.ElementAt(6).Key))
            //               };

            //resTable = new DataTable();
            //resTable.Columns.Add(cols.ElementAt(3).Key, cols.ElementAt(3).Value);
            //resTable.Columns.Add(cols.ElementAt(4).Key, cols.ElementAt(4).Value);
            //resTable.Columns.Add(cols.ElementAt(5).Key, cols.ElementAt(5).Value);
            //resTable.Columns.Add(cols.ElementAt(6).Key, cols.ElementAt(6).Value);
            //foreach (var r in resT)
            //    resTable.Rows.Add(r.element, r.Concentration, r.Error, r.MDA);



        }

        private void ButtonConcEditorSave_Click(object sender, EventArgs e)
        {
            _averageSample.Save();
        }
    }

    public static class LINQExtension
    {
        public static double Error(this IEnumerable<double> source)
        {
            if (source == null) throw new ArgumentNullException("source");

            if (source.Count() == 0)
                throw new InvalidOperationException("Cannot compute error for an empty set.");

            double d = 0.0;
            foreach (var di in source)
                d += 1 / (di * di);

            return 1 / System.Math.Sqrt(d);
        }

        public static double Error<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            return Error(Enumerable.Select(source, selector));
        }

      
    }
}
