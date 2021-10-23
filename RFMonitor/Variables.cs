using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;
using System.IO;

namespace RFMonitor
{
    class Variables
    {
        #region Data Variables
        static DateTime _currentTime;
        static DateTime _lastGoodTime;
        static float _currentDepth;
        static float _maxDepth;
        static float _lastGoodDepth;
        static float _runningFootage;

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

            using( var writer = File.CreateText("status.txt"))
            {
                foreach (string item in status)
                {
                    writer.WriteLine(item);                    
                }

                writer.Dispose();
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
        #endregion
    }
}
