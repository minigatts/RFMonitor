using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace RFMonitor
{
    class Variables
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

        public static void ClearData()
        {
            LastGoodTime = DateTime.Now;
            CurrentDepth = 0;
            MaxDepth = 0;
            LastGoodDepth = 0;
            RunningFootage = 0;

            SaveData();
        }
        #endregion
    }
}
