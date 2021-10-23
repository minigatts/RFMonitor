using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;

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

            _readPort = new SerialPort("COM5", 19200, Parity.None, 8, StopBits.One);

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
