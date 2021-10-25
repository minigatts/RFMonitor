using System;
using System.Windows.Forms;
using System.Timers;
using System.IO.Ports;
using System.Configuration;

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

            // Get a list of available serial port names.
            Variables.Ports = SerialPort.GetPortNames();

            Variables.ReadData();

            InitializeComponent();

            cbPorts.Items.AddRange(Variables.Ports);
            cbPorts.Text = ConfigurationManager.AppSettings["SelectedCom"];
            tbDepthColumn.Text = ConfigurationManager.AppSettings["DepthCol"];

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
            tbDepthColumn.Enabled = false;
            cbPorts.Enabled = false;
            btnNewJob.Enabled = false;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _spMon.Close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            tbDepthColumn.Enabled = true;
            cbPorts.Enabled = true;
            btnNewJob.Enabled = true;
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

        private void cbPorts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Program.SetSetting("SelectedCom", this.cbPorts.Text);
        }

        private void tbDepthColumn_TextChanged(object sender, EventArgs e)
        {
            Program.SetSetting("DepthCol", this.tbDepthColumn.Text);
        }

        private void btnNewJob_Click(object sender, EventArgs e)
        {
            Variables.ClearData();
        }
    }
}
