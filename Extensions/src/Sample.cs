﻿using System;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    public class Sample
    {
        public bool IsBlank { get; }
        public string Name { get; }
        private List<Element> _elements;
        public string Type { get; }
        public string Unit { get; }
        public string GRSName { get; }
        public double Weight { get; }


        public string OriginalDirectory { get; }
        public string OriginalFileName { get; }
        public string NewFileName { get; }

        public StringBuilder FileHead { get; private set; }


        public List<Element> Elements
        {
            get
            {
                return _elements;
            }
        }

        private double ParseValue(string val, string word="unnamed")
        {
            double d;
            if (!double.TryParse(val, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out d))
            {
                Debug.WriteLine($"Problem with pasrsing current line for {word} value {val}");
                return -1.0;
            }

            return d;
        }

        public Sample(string name, string type, string grs, double weight, bool isBlank, List<Element> elements, string originalDirectory, string originalFileName, string newFileName, StringBuilder headOfFile)
        {
            Name = name;
            Type = type;
            GRSName = grs;
            IsBlank = isBlank;
            Weight = weight;
            _elements = new List<Element>(elements);
            OriginalDirectory = originalDirectory;
            OriginalFileName = originalFileName;
            NewFileName = newFileName;
            FileHead = headOfFile;
        }

        public Sample(string path, bool isBlank=false)
        {
            bool isHeadOfFile = true;
            FileHead = new StringBuilder();
            OriginalFileName = Path.GetFileName(path);
            OriginalDirectory = Path.GetDirectoryName(path);
            NewFileName = $"{Path.GetFileNameWithoutExtension(OriginalFileName)}.mde";
            IsBlank = isBlank;
            _elements = new List<Element>();
            var elemPattern = new Regex(@"[A-Z]{1,2}[-]\d{2,3}[m]{0,1}");
            var concAncMDAPattern = new Regex(@"\d[.]\d{2}E[+-]\d{2,3}");
            var errPattern = new Regex(@"\d{1,2}[.]\d{2}");

            var el = "";

            Weight = -1.0;

            var rLine = "";
            Debug.WriteLine($"Start process file: {path}");
            Debug.WriteLine("Saved elements:");
            try
            {
                using (TextReader tr = File.OpenText(path))
                {
                    while ((rLine = tr.ReadLine()) != null)
                    {
                        rLine = rLine.Replace(",", ".");
                        Debug.WriteLine($"Current line:");
                        Debug.WriteLine($"{rLine}");

                        if (rLine.StartsWith("Имя образца") || rLine.StartsWith("Sample name"))
                            Name = rLine.Split(':')[1].Trim();

                        if (rLine.StartsWith("Тип") || rLine.StartsWith("Type"))
                            Type = rLine.Split(':')[1].Trim();

                        if (rLine.ToLower().Contains(".grs"))
                            GRSName = rLine.Split(':')[1].Trim();

                        //if (rLine.ToLower().Contains("%") && (rLine.ToLower().Contains("обнаруж") || (rLine.ToLower().Contains("limit"))))
                        //Unit = rLine.Split('%')[0].Trim();

                        if (rLine.Contains("activity"))
                            break;

                        if (rLine.StartsWith("Вес") || rLine.StartsWith("Weight") || rLine.StartsWith("Mass"))
                            Weight = ParseValue(rLine.Split(':')[1].Replace("μgram", "").Replace("шт.", "").Trim(), "weight");

                        if (elemPattern.IsMatch(rLine) && concAncMDAPattern.IsMatch(rLine) && errPattern.IsMatch(rLine) && !rLine.Contains("Вес") && !rLine.Contains("μgram") && !rLine.Contains("шт"))
                        {
                           
                            el = elemPattern.Match(rLine).Value;

                            _elements.Add(new Element(elemPattern.Match(rLine).Value,
                                                          ParseValue(concAncMDAPattern.Matches(rLine)[0].Value, "concentration"),
                                                          ParseValue(errPattern.Match(rLine, 13).Value, "error"),
                                                          ParseValue(concAncMDAPattern.Matches(rLine)[1].Value, "mda")));

                            Debug.WriteLine($"Inserted element:");
                            Debug.WriteLine($"{_elements.Last().ToString()}");


                            isHeadOfFile = false;
                        }

                        if (isHeadOfFile)
                            FileHead.AppendLine(rLine);
                    }
                }

                Debug.WriteLine($"Parsed sample:   {path}");
                Debug.WriteLine("{Name}\t{Type}\t{GRSName}\t{Weight}");
                Debug.WriteLine($"{Name}\t{Type}\t{GRSName}\t{Weight}");
                Debug.WriteLine($"{_elements.Count} elements were inserted");


                if (Weight < 0)
                    throw new ArgumentException($"Ошибка при чтении веса в файле {OriginalFileName}");
            }
            catch (Exception ex)
            { 
                Debug.WriteLine(ex);
            
            }
        }

        //TODO: how to avoid handling deep copy?
        public Sample Clone()
        {
            return new Sample(Name, Type, GRSName, Weight, IsBlank, Elements, OriginalDirectory, OriginalFileName, NewFileName, FileHead);
        }

        public Element this [ string NameOfElement ]
        {
            get { return _elements.Find(e => e.Name == NameOfElement); }
        }

        public static Sample operator -(Sample lhs, Sample rhs)
        {

            Sample newSample = lhs.Clone();
            newSample.Elements.Clear();

            foreach (var el in lhs.Elements)
            {
                if (rhs.Elements.Any(e => e.Name ==  el.Name ))
                    newSample.Elements.Add(el - rhs[el.Name]);
                else newSample.Elements.Add(el);

                Debug.WriteLine($"Element after substraction {newSample[el.Name].ToString()}");

            }
            return newSample;
        }

        public static Sample operator *(Sample lhs, double rhs)
        {
            foreach (var el in lhs.Elements)
            {
                el.Concentration = el.Concentration * rhs;
                el.MDA = el.MDA * rhs;
            }
            return lhs;
        }
        
        // FIXME: change Conc to Mass for filters
        // FIXME: finally fix auto update!
        public void Save(string path = "", bool keepHead = false)
        {
            Debug.WriteLine($"Starts save sample to file");

            if (string.IsNullOrEmpty(path) || !Directory.Exists(Path.GetDirectoryName(path)))
                path = $"{OriginalDirectory}\\{NewFileName}";


            using (TextWriter file = File.CreateText(path))
            {
                if (!keepHead)
                    file.Write(FileHead.Replace("КОНЦЕНТРАЦИЙ  ", "МАССОВЫХ ДОЛЕЙ").Replace("концентр.,", "масса,   ").Replace("ОБРАЗЦЕ", "ФИЛЬТРЕ").Replace("OF ELEMENTS IN SAMPLE", "OF ELEMENTS IN FILTER").Replace("   μг/гр", "мк грамм   ").Replace("    μg/g", "μgram")); // sorry :(
                else file.Write(FileHead);

                foreach (var el in Elements)
                    file.WriteLine(el.ToString());               
            }

            Debug.WriteLine($"File saved to {path}");
        }
    }

    //TODO: what happening in case array of structures inside the class?
    public class Element
    {
        private string _name;
        private double _conc;
        private double _error;
        private double _mda;
        private double _sdev;


        public Element() { }
        public Element(string name, double conc, double error, double mda, double sdev = 0.0)
        {
            _name = name;
            _conc = conc;
            _error = error;
            _mda = mda;
            _sdev = sdev;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }


        public double Concentration
        {
            get { return _conc; }
            set
            {
                _conc = value;
                //if (value < 0)
                //    throw new ArgumentException("Errors occured during the parsing of concentration values");
            }
        }

        public double Error
        {
            get { return _error; }
            set
            {
                _error = value;
                if (value < 0)
                    throw new ArgumentException("Errors occured during the parsing of error values");
            }
        }


        public double MDA
        {
            get { return _mda; }
            set
            {
                _mda = value;
                if (value < 0)
                    throw new ArgumentException("Errors occured during the parsing of mda values");
            }
        }

        public double StdDev
        {
            get { return _sdev; }
            set
            {
                _sdev = value;
                if (value < 0)
                    throw new ArgumentException("Errors occured during the parsing of mda values");
            }
        }

        public override string ToString()
        {
            var s1 = Name;
            var s2 = $"{Concentration:E2}";
            var s3 = $"{Error:f2}";
            var s4 = $"{MDA:E2}";
            return $"\t{s1,-7}\t{s2,-9}\t{s3,-5}\t{s4,-9}";
        }

        public static Element operator -(Element lhs, Element rhs)
        {
            if (string.Equals(lhs.Name, rhs.Name))
                return new Element(lhs.Name, lhs.Concentration - rhs.Concentration, System.Math.Sqrt(lhs.Error*lhs.Error + rhs.Error*rhs.Error), lhs.MDA);

            throw new ArgumentException("Elements should be the same");
        }
    }
}
