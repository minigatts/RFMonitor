using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Configuration;

namespace RFMonitor
{
    class ParseDepth
    {
        // Application constants
        static int depthCol = Convert.ToInt16(ConfigurationManager.AppSettings["DepthCol"]);
        static int maxSpeed = Convert.ToInt16(ConfigurationManager.AppSettings["MaxSpeed"])/60;        

        static DateTime currentTime;
        static TimeSpan timeDelta;
        static float depthDelta;
        static float depth;
        static float speed;
        
        public static void GetDepth ( string message )
        {            
            // Pull current depth from serial stream.
            string[] elements = message.Split(',');

            try
            {                
                depth = float.Parse(elements[depthCol])*Variables.DepthGain+Variables.DepthOffset;

                // Mark time of sample.
                currentTime = DateTime.Now;

                // Get time since last sample
                timeDelta = currentTime - Variables.LastGoodTime;
                Debug.WriteLine("\nCurrent Time : " + currentTime + "  Last Time : " + Variables.LastGoodTime);
                Debug.WriteLine("Time Delta : " + timeDelta);

                if (timeDelta.TotalSeconds >= .5)
                {
                    if (depth > Variables.LastGoodDepth)  // Running in hole.
                    {
                        depthDelta = Math.Abs(depth - Variables.LastGoodDepth);

                        speed = Convert.ToSingle(depthDelta / timeDelta.TotalSeconds);
                        Debug.WriteLine("Speed : " + speed * 60 + " ft/min");
                        Debug.WriteLine("Depth : " + depth  + " LastGoodDepth : " + Variables.LastGoodDepth);

                        // Check to see if speed limit has been exceeded
                        if (depthDelta / timeDelta.TotalSeconds < maxSpeed)  // Under limit, keep footage.
                        {                            
                            Variables.RunningFootage += depthDelta;
                            Variables.LastGoodDepth = depth;
                        }
                        else  // Over limit, discard footage and set last good depth to current depth.
                        {
                            Debug.WriteLine("Exceeded speed limit " + maxSpeed + " ft/sec.");
                            Variables.LastGoodDepth = depth;
                        }

                        Debug.WriteLine("Running Footage : " + Variables.RunningFootage);
                    }
                    else  // Pulling out of hole.  
                    {
                        // Update last good depth, but do not record negative running footage.
                        Variables.LastGoodDepth = depth;
                        Debug.WriteLine("Decreasing depth.  Last good depth : " + Variables.LastGoodDepth);
                    }
                }

                Variables.CurrentDepth = depth;
                Variables.LastGoodTime = currentTime;
                if (depth > Variables.MaxDepth) { Variables.MaxDepth = depth; }

                Variables.SaveData();

            }
            catch (IndexOutOfRangeException)
            {                
                Debug.WriteLine("Too much data in buffer.");
            }
            catch (FormatException)
            {
                Debug.WriteLine("Index string not in correct format.");
            }
            
        }

        public static bool IsDateTimeNullorEmpty(DateTime? date)
        {
            return date == null ? true : false;
        }

    }
}
