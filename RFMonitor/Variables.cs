using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace RFMonitor
{
    public static class Variables
    {
        #region Data Variables
        static string[] _ports;
        static DateTime _currentTime;
        static DateTime _lastGoodTime;
        static float _currentDepth;
        static float _maxDepth;
        static float _lastGoodDepth;
        static float _runningFootage;
        static float _depthGain;
        static float _depthOffset;
        static float _weightGain;
        static float _weightOffset;
        static int _depthCol;
        static int _weightCol;

        public static DateTime CurrentTime
        {
            get { return _currentTime; }
            set { _currentTime = value; }
        }
        public static DateTime LastGoodTime
        {
            get { return _lastGoodTime; }
            set { _lastGoodTime = value; }
        }

        public static float CurrentDepth
        {
            get { return _currentDepth; }
            set { _currentDepth = value; }
        }       

        public static float MaxDepth
        {
            get { return _maxDepth; }
            set { _maxDepth = value; }
        }

        public static float LastGoodDepth
        {
            get { return _lastGoodDepth; }
            set { _lastGoodDepth = value; }
        }

        public static float RunningFootage
        {
            get { return _runningFootage; }
            set { _runningFootage = value; }
        }
        public static string[] Ports
        {
            get { return _ports; }
            set { _ports = value; }
        }

        public static int DepthCol
        {
            get { return _depthCol; }
            set { _depthCol = value; }
        }

        public static float DepthGain
        {
            get { return _depthGain; }
            set { _depthGain = value; }
        }
        public static float DepthOffset
        {
            get { return _depthOffset; }
            set { _depthOffset = value; }
        }

        public static int WeightCol
        {
            get { return _weightCol; }
            set { _weightCol = value; }
        }

        public static float WeightGain
        {
            get { return _weightGain; }
            set { _weightGain = value; }
        }

        public static float WeightOffset
        {
            get { return _weightOffset; }
            set { _weightOffset = value; }
        }

        public static class ForcesData
        {
            public static DataTable dt = new DataTable();                     
            
        }

        public static class ModelData
        {
            public static DataTable dt = new DataTable();

        }

        public static class CSVTemp
        {
            public static DataTable dt = new DataTable();

        }
        #endregion

        #region Save / Load
        public static void SaveData()
        {
            var status = new List<string>
            {
                _lastGoodTime.ToString(),
                _currentDepth.ToString(),
                _maxDepth.ToString(),
                _lastGoodDepth.ToString(),
                _runningFootage.ToString()
            };

            try
            {
                using (var writer = File.CreateText("status.txt"))
                {
                    foreach (string item in status)
                    {
                        writer.WriteLine(item);
                    }

                    writer.Dispose();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Can't write to status file.");
                Debug.WriteLine(e);
            }
        }

        public static void ReadData()
        {
            try 
            { 
                string[] lines = System.IO.File.ReadAllLines("status.txt");

                LastGoodTime = DateTime.Parse(lines[0]);
                CurrentDepth = Single.Parse(lines[1]);
                MaxDepth = Single.Parse(lines[2]);
                LastGoodDepth = Single.Parse(lines[3]);
                RunningFootage = Single.Parse(lines[4]);
            }
            catch(FileNotFoundException)
            {
                Debug.WriteLine("No status file found.");
            }
        }

        public static void ClearData()
        {
            LastGoodTime = DateTime.Now;
            CurrentDepth = 0;
            MaxDepth = 0;
            LastGoodDepth = 0;
            RunningFootage = 0;

            SaveData();
        }

        private static OpenFileDialog openFileDialog1;

        public static void ReadCSV()
        {
                        
            string fileName;
            string filePath;

            openFileDialog1 = new OpenFileDialog();           
          

            if( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                fileName = openFileDialog1.FileName;
                filePath = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);

                Debug.WriteLine(fileName);
                Debug.WriteLine(filePath);
            }
            else 
            {
                fileName = null;
                filePath = null;                
            }

            try 
            {
                using (var reader = new StreamReader(fileName))

                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    using (var dr = new CsvDataReader(csv))
                    {
                        CSVTemp.dt.Load(dr);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error opening CSV file.");
                Debug.WriteLine(e);
            }

            
        }

        public static void ExportDataTable(this CsvWriter writer, DataTable dt)
        {
            // Write the header
            foreach (DataColumn column in dt.Columns)
            {
                writer.WriteField(column.ColumnName);
            }
            writer.NextRecord();

            // Write the rows
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    writer.WriteField(row[column]);
                }
                writer.NextRecord();
            }
        }
        
        #endregion
    }
}
