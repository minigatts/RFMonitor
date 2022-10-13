using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
using System.Diagnostics;
using System.Configuration;
using System.Text.RegularExpressions;

namespace RFMonitor
{
    class ParseDepth    {
        

        // Application constants
        static int depthCol = Convert.ToInt16(ConfigurationManager.AppSettings["DepthCol"]);
        static int weightCol = Convert.ToInt16(ConfigurationManager.AppSettings["WeightCol"]);
        static int maxSpeed = Convert.ToInt16(ConfigurationManager.AppSettings["MaxSpeed"])/60;        

        static DateTime currentTime;
        static TimeSpan timeDelta;
        static float depthDelta;
        static float depth;
        static float weight;
        static float speed;
        static string depthStr;
        static string weightStr;

        public static void GetDepth ( string message )
        {
            // Capture changes to Column Value if applied after program start.
            depthCol = Convert.ToInt16(Variables.DepthCol);
            weightCol = Convert.ToInt16(Variables.WeightCol);            

            // Pull current depth from serial stream.
            string[] elements = message.Split(new string[] { "," , "\0\r"}, StringSplitOptions.None);         

            try
            {
                depthStr = elements[depthCol];
                depthStr = depthStr.TrimStart(new Char[] { '0' });
                depthStr = Regex.Replace(depthStr, "[^-.0-9]", "");              

                weightStr = elements[weightCol];
                weightStr = weightStr.TrimStart(new Char[] { '0' });
                weightStr = Regex.Replace(weightStr, "[^-.0-9]", "");                


                depth = (float) Math.Round(Convert.ToSingle(depthStr) * Variables.DepthGain + Variables.DepthOffset,1);
                weight = (float) Math.Round(Convert.ToSingle(weightStr) * Variables.WeightGain + Variables.WeightOffset,1);

                try 
                {
                    


                    Debug.WriteLine("\nDepth :" + depthStr + "Weight : " + weightStr);
                    DataRow _forces = Variables.ForcesData.dt.NewRow();

                    // This is unnecessary, but avoids an error message which appears when the Force Monitor has not been opened yet..
                    if (!_forces.Table.Columns.Contains("Depth") & !_forces.Table.Columns.Contains("Weight"))
                    {
                        _forces.Table.Columns.Add("Depth");
                        _forces.Table.Columns.Add("Weight");
                    }                    

                    _forces["Depth"] = depth;
                    _forces["Weight"] = weight;
                    Variables.ForcesData.dt.Rows.Add(_forces);                    

                }
                catch (Exception e)
                { 
                    Debug.WriteLine("Error in Forces Parsing");
                    Debug.WriteLine(e);
                }      

                // Mark time of sample.
                currentTime = DateTime.Now;

                // Get time since last sample
                timeDelta = currentTime - Variables.LastGoodTime;
                Debug.WriteLine("Depth Column : " + depthCol + "  Weight Column : " + weightCol);
                Debug.WriteLine("Current Time : " + currentTime + "  Last Time : " + Variables.LastGoodTime);
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
