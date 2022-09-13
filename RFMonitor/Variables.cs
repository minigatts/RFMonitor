using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CuddCal
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

        static string _infofeed;

        public static string InfoFeed
        {
            get { return _infofeed; }
            set { _infofeed = value; }
        }

        // Channel value variables
        static float _circulating;
        static float _wellhead;
        static float _stripper1;
        static float _stripper2;
        static float _upperSkate;
        static float _middleSkate;
        static float _lowerSkate;
        static float _chainTension;
        static float _weight;
        static float _spare1;
        static float _speed;
        static float _flowRate;
        static float _auxFlowRate;
        static float _injector;
        static float _spare2;
        static float _depth;

        static Dictionary<int, string> _channels = new Dictionary<int, string>()
        {
            {0, "Circulating" },
            {1, "Wellhead"},
            {2, "Stripper1"},
            {3, "Stripper2"},
            {4, "UpperSkate"},
            {5, "MiddleSkate"},
            {6, "LowerSkate"},
            {7, "ChainTension"},
            {8, "Weight"},
            {9, "Spare1"},
            {10, "Speed"},
            {11, "FlowRate"},
            {12, "AuxFlowRate"},
            {13, "Injector"},
            {14, "Spare2"},
            {15, "Depth"}
        };

        public static Dictionary<int, string> Channels
        {
            get { return _channels; }
            set { _channels = value; }
        }

        // Array to store calibration values and calibrated result.
        static float[,] _calibrationvalues = new float[16, 3] 
        {   
            { 0, 0, 0 },             
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 }, 
            { 0, 0, 0 } 
        };

        public static float [,] CalibrationValues 
        {
            get { return _calibrationvalues; }
            set { _calibrationvalues = value; }
        }        

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

        #region Channel Accessors
        public static float Circulating
        {
            get { return _circulating; }
            set { _circulating = value; }
        }
        public static float Wellhead
        {
            get { return _wellhead; }
            set { _wellhead = value; }
        }
        public static float Stripper1
        {
            get { return _stripper1; }
            set { _stripper1 = value; }
        }
        public static float Stripper2
        {
            get { return _stripper2; }
            set { _stripper2 = value; }
        }
        public static float UpperSkate
        {
            get { return _upperSkate; }
            set { _upperSkate = value; }
        }
        public static float MiddleSkate
        {
            get { return _middleSkate; }
            set { _middleSkate = value; }
        }
        public static float LowerSkate
        {
            get { return _lowerSkate; }
            set { _lowerSkate = value; }
        }
        public static float ChainTension
        {
            get { return _chainTension; }
            set { _chainTension = value; }
        }
        public static float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public static float Spare1
        {
            get { return _spare1; }
            set { _spare1 = value; }
        }

        public static float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public static float FlowRate
        {
            get { return _flowRate; }
            set { _flowRate = value; }
        }
        public static float AuxFlowRate
        {
            get { return _auxFlowRate; }
            set { _auxFlowRate = value; }
        }
        public static float Injector
        {
            get { return _injector; }
            set { _injector = value; }
        }
        public static float Spare2
        {
            get { return _spare2; }
            set { _spare2 = value; }
        }
        public static float Depth
        {
            get { return _depth; }
            set { _depth = value; }
        }
        #endregion
        #endregion

        #region Save / Load
        public static void SaveData()
        {
            var status = new List<string>
            {
           
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
            }
            catch(FileNotFoundException)
            {
                Debug.WriteLine("No status file found.");
            }
        }


        #endregion
    }
}
