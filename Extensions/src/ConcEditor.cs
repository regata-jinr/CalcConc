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
        public List<Sample> InputSamples { get; set; }
        private Sample AverageSample { get; }

        private DataTable srcsTable;
        private DataTable resTable;
        private Dictionary<string, Type> cols;

       

        private void ApplyLangSettings()
        {
            if (lang == "English")
            {
                Text = "Редактор файлов концентраций";
                LabelConcEditorResult.Text = "Усредненные значения";
                LabelConcEditorSource.Text = "Исходные значения";
                ButtonConcEditorHighLight.Text = "Показать выбросы?";
                ButtonConcEditorSave.Text = "Сохранить как";
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
                ButtonConcEditorHighLight.Text = "Show deviations";
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
            //srcs = new List<Sample>();

            ApplyLangSettings();


        }

        

        private void ConvertSamplesToTable()
        {
            Debug.WriteLine("Start adding data to table sources");
            srcsTable = new DataTable();
            foreach (var col in cols) srcsTable.Columns.Add(col.Key, col.Value);

            foreach (Sample samp in srcs)
            {
                foreach (Element el in samp.Elements)
                {
                    Debug.WriteLine("Adding row:");
                    Debug.WriteLine($"{samp.OriginalFileName}, {samp.Name}, {samp.Weight}, {el.Name}, {el.Concentration}, {el.Error}, {el.MDA}");
                    srcsTable.Rows.Add(samp.OriginalFileName, samp.Name, samp.Weight, el.Name, el.Concentration, el.Error, el.MDA);
                }
            }
        }

        private void ConcEditor_Shown(object sender, EventArgs e)
        {
            ConvertSamplesToTable();
            DataGridViewConcValEditorSource.DataSource = srcsTable;

            var resT = from dt in srcsTable.AsEnumerable()
                       group dt by new
                       {
                           element = dt.Field<string>(cols.ElementAt(3).Key)
                       } into res
                       select new
                       {
                           element = res.Key.element,
                           Concentration = res.Average(p => p.Field<double>(cols.ElementAt(4).Key)),
                           Error = res.Error(p => p.Field<double>(cols.ElementAt(5).Key)),

                           MDA = res.Min(p=>p.Field<double>(cols.ElementAt(6).Key))
                           };

            resTable = new DataTable();
            resTable.Columns.Add(cols.ElementAt(3).Key, cols.ElementAt(3).Value);
            resTable.Columns.Add(cols.ElementAt(4).Key, cols.ElementAt(4).Value);
            resTable.Columns.Add(cols.ElementAt(5).Key, cols.ElementAt(5).Value);
            resTable.Columns.Add(cols.ElementAt(6).Key, cols.ElementAt(6).Value);
            foreach (var r in resT)
                resTable.Rows.Add(r.element, r.Concentration, r.Error, r.MDA);

            DataGridViewConcValEditorResult.DataSource = resTable;
            DataGridViewConcValEditorResult.Columns[1].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorResult.Columns[2].DefaultCellStyle.Format = "f2";
            DataGridViewConcValEditorResult.Columns[3].DefaultCellStyle.Format = "E2";

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
