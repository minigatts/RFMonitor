using System;
using System.Diagnostics;
using System.Threading;
using System.IO.Ports;
using System.Configuration;

namespace RFMonitor
{
    public class SerialPortMonitor
    {
        static bool _continue;
        static SerialPort _readPort;
        Thread readThread;

        public SerialPortMonitor()
        {
            readThread = new Thread(ReadCom);
            string selectedCom = ConfigurationManager.AppSettings["SelectedCom"];

            _readPort = new SerialPort(selectedCom, 19200, Parity.None, 8, StopBits.One);

            Debug.WriteLine("Opening port...");
            _readPort.Open();
            _continue = true;

            // Clear buffer before starting.
            // Rolligon box doesn't provide timestamp with data, so we only want the most recent transmission.
            _readPort.DiscardInBuffer();  

            readThread.Start();            
        }

        public void ReadCom()
        {
            while (_continue)
            {
                try
                {
                    string message = _readPort.ReadLine();
                    ParseDepth.GetDepth(message);                    
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
            _continue = false;

            // Wait for monitor thread to finish.
            readThread.Join();
            
            _readPort.Close();
        }

    }

    
}
