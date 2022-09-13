﻿using System;
using System.Diagnostics;
using System.Threading;
using System.IO.Ports;
using System.Configuration;
using System.Windows.Forms;

namespace CuddCal
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
            try
            {
                _readPort.Open();

                _continue = true;

                // Clear buffer before starting.
                // Rolligon box doesn't provide timestamp with data, so we only want the most recent transmission.
                _readPort.DiscardInBuffer();

                readThread.Start();
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("The selected com port " + selectedCom + " is already in use.");
            }                    
        }

        public void ReadCom()
        {
            while (_continue)
            {
                try
                {
                    string message = _readPort.ReadLine();
                    ParseChannels.GetChannelValues(message);                    
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

                // Wait for monitor thread to finish.
                readThread.Join();

                _readPort.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            
            
        }

    }

    
}
