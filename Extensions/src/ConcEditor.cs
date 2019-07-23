using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.ComponentModel;

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
        private Sample _combinedSample;

        private  List<Tuple<string, Element>> _deletedElements;
        

        private Dictionary<string, Type> cols;



        private void ApplyLangSettings()
        {
            if (lang == "English")
            {
                Text = "Просмотр файлов концентраций";
                LabelConcEditorResult.Text = "Усредненные значения";
                LabelConcEditorSource.Text = "Исходные значения";
                ButtonConcEditorHighLight.Text = "Окрасить элементы, у которых относительная погрешность превышает";
                ButtonConcEditorSave.Text = "Сохранить как";
                buttonDeleteRow.Text = "Удалить выделенные строки";
                buttonRestore.Text = "Восстановить удаленную строку(0)";
                cols.Add("Файл", typeof(string));
                cols.Add("Образец", typeof(string));
                cols.Add("Вес, гр", typeof(double));
                cols.Add("Элемент", typeof(string));
                cols.Add("Концентранция, uг/гр", typeof(double));
                cols.Add("Погрешность, %", typeof(double));
                cols.Add("МДА, uг/гр", typeof(double));
                cols.Add("Относительная ошибка, %", typeof(double));
            }
            else
            {
                Text = "Concentration files editor";
                LabelConcEditorResult.Text = "Average values";
                LabelConcEditorSource.Text = "Sources";
                ButtonConcEditorHighLight.Text = "Colorize elements with relative error more than";
                buttonDeleteRow.Text = "Delete selected rows";
                buttonRestore.Text = "Restore deleted row (0)";
                ButtonConcEditorSave.Text = "Save as";
                cols.Add("File", typeof(string));
                cols.Add("Sample", typeof(string));
                cols.Add("Weight, gr", typeof(double));
                cols.Add("Element", typeof(string));
                cols.Add("Concentration, ug/gr", typeof(double));
                cols.Add("Error, %", typeof(double));
                cols.Add("MDC, ug/gr", typeof(double));
                cols.Add("Relative error, %", typeof(double));
            }
        }


        public ConcEditor()
        {
            InitializeComponent();

            cols = new Dictionary<string, Type>();

            ApplyLangSettings();
        }

        private void CombineSample(ref List<Sample> samples)
        {
            string names = "";
            if (_combinedSample != null)
                names = _combinedSample.Name;

            List<Element> elements = new List<Element>();

            foreach (var s in samples)
            {
                if (!names.Contains(s.Name))
                    names += $"{s.Name}, ";
                elements.AddRange(s.Elements);
            }

            if (_combinedSample == null)
                samples[0].FileHead.Replace(samples[0].Name, names);


            _combinedSample = new Sample(names, samples[0].Type, samples[0].GRSName, 0.0, false, elements, samples[0].OriginalDirectory, "", "", samples[0].FileHead);
        }

        private void AverageElementsValues(ref List<Sample> samples)
        {
            CombineSample(ref samples);
            var els = _combinedSample.Elements.GroupBy(el => new { elName = el.Name }).Select(newEl => new Element()
            {
                Name = newEl.Key.elName,
                Concentration = newEl.Average(a => a.Concentration),
                Error = newEl.Error(a => a.Error),
                MDA = newEl.Average(a => a.MDA),
                StdDev = newEl.StdDev(a => a.Concentration)
            }).ToList();

            _averageSample = new Sample(_combinedSample.Name, _combinedSample.Type, _combinedSample.GRSName, _combinedSample.Weight, _combinedSample.IsBlank, els, _combinedSample.OriginalDirectory, _combinedSample.OriginalFileName, "Average.con", _combinedSample.FileHead);
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
                        dt.Rows.Add(samp.OriginalFileName, samp.Name, samp.Weight, el.Name, el.Concentration, el.Error, el.MDA, 100 * (el.Concentration - _averageSample[el.Name].Concentration)/ el.Concentration);
                    else
                        dt.Rows.Add(el.Name, el.Concentration, el.Error, el.MDA);
                }
            }
            return dt;
        }

        private void ConcEditor_Shown(object sender, EventArgs e)
        {

            

            AverageElementsValues(ref _inputSamples);
            var newResList = new List<Sample>() { _averageSample };
            var newColumns = new Dictionary<string, Type>() { { "Element", typeof(string) }, { "Concentration, ug/gr", typeof(double) }, { "Error, %", typeof(double) }, { "MDC, ug/gr", typeof(double) } };
            DataGridViewConcValEditorResult.DataSource = ConvertSamplesToTable(ref newResList, ref newColumns, true);
            DataGridViewConcValEditorResult.Columns[1].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorResult.Columns[2].DefaultCellStyle.Format = "f2";
            DataGridViewConcValEditorResult.Columns[3].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorResult.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorResult.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorResult.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewConcValEditorSource.DataSource = ConvertSamplesToTable(ref _inputSamples, ref cols);
            DataGridViewConcValEditorSource.Columns[4].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorSource.Columns[5].DefaultCellStyle.Format = "f2";
            DataGridViewConcValEditorSource.Columns[6].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorSource.Columns[7].DefaultCellStyle.Format = "f0";

            ButtonConcEditorHighLight_Click(sender,e);
        }

        private void ButtonConcEditorSave_Click(object sender, EventArgs e)
        {
            try
            {
                _averageSample.Save("",true);
                MessageBox.Show("Файл успешно сохранен в исходной директории с именем Average.con", " Программа расчета концентраций", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            int curIndex = DataGridViewConcValEditorSource.SelectedRows[DataGridViewConcValEditorSource.SelectedRows.Count-1].Index;
            if (curIndex >= DataGridViewConcValEditorSource.Rows.Count) curIndex = DataGridViewConcValEditorSource.Rows.Count - 1;

            if (_deletedElements == null)
            {
                _deletedElements = new List<Tuple<string, Element>>();
            }

            foreach (DataGridViewRow sRow in DataGridViewConcValEditorSource.SelectedRows)
            {
                string curEl = sRow.Cells[3].Value.ToString();
                var ds = _inputSamples.Find(s => s.OriginalFileName == sRow.Cells[0].Value.ToString());
                _deletedElements.Add(new Tuple<string, Element>(ds.OriginalFileName, ds[curEl]));

                _inputSamples.Find(s => s.OriginalFileName == sRow.Cells[0].Value.ToString()).Elements.Remove(ds[sRow.Cells[3].Value.ToString()]);

            }

            DataGridViewConcValEditorSource.DataSource = ConvertSamplesToTable(ref _inputSamples, ref cols);

            AverageElementsValues(ref _inputSamples);
            buttonRestore.Enabled = true;
            buttonRestore.Text = $"Восстановить удаленную строку({_deletedElements.Count})";
            var newResList = new List<Sample>() { _averageSample };
            var newColumns = new Dictionary<string, Type>() { { "Element", typeof(string) }, { "Concentration, ug/gr", typeof(double) }, { "Error, %", typeof(double) }, { "MDC, ug/gr", typeof(double) } };
            DataGridViewConcValEditorResult.DataSource = ConvertSamplesToTable(ref newResList, ref newColumns, true);

            ButtonConcEditorHighLight_Click(sender, e);

            DataGridViewConcValEditorSource.ClearSelection();
            DataGridViewConcValEditorSource.Rows[curIndex].Selected = true;
            DataGridViewConcValEditorSource.FirstDisplayedScrollingRowIndex = curIndex;

        }

        private void ButtonConcEditorHighLight_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewConcValEditorSource.Rows)
            {
                if (Math.Abs((double)row.Cells[7].Value) >= (double)NumericUpDownN.Value)
                    row.Cells[4].Style.BackColor = Color.LightPink;
                else row.Cells[4].Style.BackColor = Color.White;
            }


        }


        private void buttonRestore_Click(object sender, EventArgs e)
        {
            if (_deletedElements == null)
                return;

            _inputSamples.Find(s => s.OriginalFileName == _deletedElements.Last().Item1).Elements.Add(_deletedElements.Last().Item2);
            _deletedElements.Remove(_deletedElements.Last());

           
            buttonRestore.Text = $"Восстановить удаленную строку({_deletedElements.Count})";

            AverageElementsValues(ref _inputSamples);
            var newResList = new List<Sample>() { _averageSample };
            var newColumns = new Dictionary<string, Type>() { { "Element", typeof(string) }, { "Concentration, ug/gr", typeof(double) }, { "Error, %", typeof(double) }, { "MDC, ug/gr", typeof(double) } };
            DataGridViewConcValEditorResult.DataSource = ConvertSamplesToTable(ref newResList, ref newColumns, true);
            DataGridViewConcValEditorSource.DataSource = ConvertSamplesToTable(ref _inputSamples, ref cols);

            if (_deletedElements.Count == 0)
                buttonRestore.Enabled = false;

            ButtonConcEditorHighLight_Click(sender, e);

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

        public static double StdDev(this IEnumerable<double> source)
        {
            if (source == null) throw new ArgumentNullException("source");

            if (source.Count() == 0)
                throw new InvalidOperationException("Cannot compute error for an empty set.");

            double average = source.Average();
            double sumOfSquaresOfDifferences = source.Select(val => (val - average) * (val - average)).Sum();
            return Math.Sqrt(sumOfSquaresOfDifferences / source.Count());

        }

        public static double Error<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            return Error(Enumerable.Select(source, selector));
        }
        public static double StdDev<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            return StdDev(Enumerable.Select(source, selector));
        }


    }
}
