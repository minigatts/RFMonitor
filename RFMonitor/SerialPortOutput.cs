using System;
using System.Diagnostics;
using System.Threading;
using System.IO.Ports;
using System.Configuration;
using System.Windows.Forms;
using System.Timers;

namespace CuddCal
{
    public class SerialPortOutput
    {
        static bool _continue;
        static SerialPort _writePort;        
        Thread writeThread;
        

        public SerialPortOutput()
        {            
            writeThread = new Thread(WriteCom);
            string selectedCom = ConfigurationManager.AppSettings["SelectedComOut"];

            _writePort = new SerialPort(selectedCom, 19200, Parity.None, 8, StopBits.One);

            Debug.WriteLine("Opening port...");
            try
            {
                _writePort.Open();

                _continue = true;                

                writeThread.Start();
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("The selected com port " + selectedCom + " is already in use.");
            }                    
        }

        public void WriteCom()
        {
            
            while (_continue)
            {
                
                Thread.Sleep(1000);

                try
                {
                    string message = "";

                    for(int i = 0; i < 15; i++)
                    {
                        message += (Variables.CalibrationValues[i, 2]).ToString() + ",";
                    }

                    message += (Variables.CalibrationValues[15, 2]).ToString() + "\r\n";

                    _writePort.Write(message);
                }
                catch (TimeoutException) 
                {
                    Debug.WriteLine("Timeout exception.");
                }
                catch(NullReferenceException)
                {
                    Debug.WriteLine("Null reference exception.");
                }                
            }
        }

        // Close out serial port and end read thread.
        public void Close()
        {
            try 
            {
                _continue = false;

                // Wait for output thread to finish.
                writeThread.Join();

                _writePort.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            
            
        }

    }

    
}
