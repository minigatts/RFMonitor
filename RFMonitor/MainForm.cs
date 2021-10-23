using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace RFMonitor
{
    public partial class RFMonitor : Form
    {
        SerialPortMonitor _spMon;
        static System.Timers.Timer uiUpdateTimer;

        public RFMonitor()
        {
            uiUpdateTimer = new System.Timers.Timer(2000);
            uiUpdateTimer.Elapsed += OnTimedUpdate;
            uiUpdateTimer.AutoReset = true;
            uiUpdateTimer.Enabled = true;

            Variables.ReadData();

            InitializeComponent();    
        }       

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Initialize LastGoodTime with current time on connect.
            if (ParseDepth.IsDateTimeNullorEmpty(Variables.LastGoodTime))
            {
                Variables.LastGoodTime = DateTime.Now;
            }

            InitializeSerialPort();
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _spMon.Close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        private void InitializeSerialPort()
        {
            _spMon = new SerialPortMonitor();            
        }

        public void OnTimedUpdate(object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
           {
               this.lblDepth.Text = Variables.CurrentDepth.ToString("0.0");
               this.lblRunningFootage.Text = Variables.RunningFootage.ToString("0.0");
               this.lblMaxDepth.Text = Variables.MaxDepth.ToString("0.0");
           });
            
        }

    }
}
