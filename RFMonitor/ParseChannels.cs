using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CuddCal
{
    class ParseChannels
    {   
        public static void GetChannelValues(string message)
        {
            string[] elements = message.Split(new string[] { ",", "\0\r" }, StringSplitOptions.None);

            if (elements.Length == 0)
            {
                // Do nothing if more (or fewer) than 16 channels are present.
                // This is an incomplete data stream, and we won't be able to match channel data correctly.                
                Variables.InfoFeed += ("No data.\r\n");
            }
            else if ( (elements.Length >=1 && elements.Length < 16) | elements.Length > 16)
            {
                // Do nothing if more (or fewer) than 16 channels are present.
                // This is an incomplete data stream, and we won't be able to match channel data correctly.                
                Variables.InfoFeed += ("Wrong number of channels in serial string.  Expected 16 but got " + elements.Length +"\r\n");
            }
            else
            {
                float[] temp = new float[16];

                int i = 0;

                char[] charsToTrim = { ' ', '0' };

                
                foreach (string value in elements)
                {
                    try
                    {
                        // Remove leading zeros, convert to float.
                        temp[i] = float.Parse(value.TrimStart(charsToTrim));

                        Variables.CalibrationValues[i, 2] = temp[i] * Variables.CalibrationValues[i, 0] + Variables.CalibrationValues[i, 1];

                    }
                    catch (Exception e)
                    {                        
                        Variables.InfoFeed += ("Non-numeric value in position " + (i+1) + " : " + Variables.Channels[i] + "Value set to -1.\r\n");
                        Variables.CalibrationValues[i, 2] = -1;
                    }

                    i++;
                }
           
            }       
        }        
    }
}
