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
        private Dictionary<string, Type> resColumns;

        private void RecalcAndFillDgvs()
        {
            AverageElementsValues(ref _inputSamples);
            var newResList = new List<Sample>() { _averageSample };
            
            DataGridViewConcValEditorResult.DataSource = ConvertSamplesToTable(ref newResList, ref resColumns, true);
            DataGridViewConcValEditorSource.DataSource = ConvertSamplesToTable(ref _inputSamples, ref cols);
            DataGridViewConcValEditorResult.Sort(DataGridViewConcValEditorResult.Columns[4], ListSortDirection.Ascending);
            DataGridViewConcValEditorSource.Sort(DataGridViewConcValEditorSource.Columns[8], ListSortDirection.Ascending);
        }


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
                cols.Add("NumSort", typeof(int));
                resColumns.Add("Элемент", typeof(string));
                resColumns.Add("Концентранция,uг/гр", typeof(double));
                resColumns.Add("Погрешность, %", typeof(double));
                resColumns.Add("МДА, uг/гр", typeof(double));
                resColumns.Add("numSort", typeof(int));

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
                cols.Add("NumSort", typeof(int));
                resColumns.Add("Element", typeof(string));
                resColumns.Add("Concentration, ug/gr", typeof(double));
                resColumns.Add("Error, %", typeof(double));
                resColumns.Add("MDC, ug/gr", typeof(double));
                resColumns.Add("numSort", typeof(int));
            };
        }


        public ConcEditor()
        {
            InitializeComponent();

            cols = new Dictionary<string, Type>();
            resColumns = new Dictionary<string, Type>();

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
                MDA = newEl.Average(a => a.MDA)
            }).ToList();

            _averageSample = new Sample(_combinedSample.Name, _combinedSample.Type, _combinedSample.GRSName, _combinedSample.Weight, _combinedSample.IsBlank, els, _combinedSample.OriginalDirectory, _combinedSample.OriginalFileName, "Average.con", _combinedSample.FileHead);
        }


        private DataTable ConvertSamplesToTable(ref List<Sample> samples, ref Dictionary<string, Type> columns, bool isResult = false)
        {
            var dt = new DataTable();
            var NumPattern = new System.Text.RegularExpressions.Regex(@"\d{2,3}");
            int num;
            
            Debug.WriteLine("Start adding data to table sources");
            foreach (var col in columns) dt.Columns.Add(col.Key, col.Value);

            foreach (Sample samp in samples)
            {
                foreach (Element el in samp.Elements)
                {
                    int.TryParse(NumPattern.Match(el.Name).Value, out num);
                    Debug.WriteLine("Adding row:");
                    if (!isResult) //with smells...
                        dt.Rows.Add(samp.OriginalFileName, samp.Name, samp.Weight, el.Name, el.Concentration, el.Error, el.MDA, 100 * (el.Concentration - _averageSample[el.Name].Concentration)/ el.Concentration, num);
                    else
                        dt.Rows.Add(el.Name, el.Concentration, el.Error, el.MDA, num);
                    Debug.WriteLine($"{dt.Rows[dt.Rows.Count-1][0].ToString()}--{dt.Rows[dt.Rows.Count - 1][1].ToString()}--{dt.Rows[dt.Rows.Count - 1][2].ToString()}--{dt.Rows[dt.Rows.Count - 1][3].ToString()}--{num}");

                }
            }
            return dt;
        }

        private void ConcEditor_Shown(object sender, EventArgs e)
        {



            RecalcAndFillDgvs();

            DataGridViewConcValEditorResult.Columns[1].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorResult.Columns[2].DefaultCellStyle.Format = "f2";
            DataGridViewConcValEditorResult.Columns[3].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorResult.Columns[4].Visible = false;
            DataGridViewConcValEditorResult.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorResult.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorResult.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorResult.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

           
            DataGridViewConcValEditorSource.Columns[4].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorSource.Columns[5].DefaultCellStyle.Format = "f2";
            DataGridViewConcValEditorSource.Columns[6].DefaultCellStyle.Format = "E2";
            DataGridViewConcValEditorSource.Columns[7].DefaultCellStyle.Format = "f0";
            DataGridViewConcValEditorSource.Columns[8].Visible = false;
            DataGridViewConcValEditorSource.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorSource.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorSource.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorSource.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorSource.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorSource.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorSource.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewConcValEditorSource.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

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


            buttonRestore.Enabled = true;
            buttonRestore.Text = $"Восстановить удаленную строку({_deletedElements.Count})";

            RecalcAndFillDgvs();

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

            RecalcAndFillDgvs();

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
