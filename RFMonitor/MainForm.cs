using System;
using System.Windows.Forms;
using System.Timers;
using System.IO.Ports;
using System.Configuration;
using System.Diagnostics;
using System.IO;

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

            try
            {
                Variables.ReadData();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Debug.WriteLine("Error when reading status.txt.");
            }
            

            InitializeComponent();

            cbPorts.Items.AddRange(Variables.Ports);
            cbPorts.Text = ConfigurationManager.AppSettings["SelectedCom"];
            tbDepthColumn.Text = ConfigurationManager.AppSettings["DepthCol"];
            tbDepthGain.Text = ConfigurationManager.AppSettings["DepthGain"];
            tbDepthOffset.Text = ConfigurationManager.AppSettings["DepthOffset"];
            tbWeightColumn.Text = ConfigurationManager.AppSettings["WeightCol"];
            tbWeightGain.Text = ConfigurationManager.AppSettings["WeightGain"];
            tbWeightOffset.Text = ConfigurationManager.AppSettings["WeightOffset"];

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
            tbDepthGain.Enabled = false;
            tbDepthOffset.Enabled = false;
            tbWeightColumn.Enabled = false;
            tbWeightGain.Enabled = false;
            tbWeightOffset.Enabled = false;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _spMon.Close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            tbDepthColumn.Enabled = true;
            cbPorts.Enabled = true;
            btnNewJob.Enabled = true;
            tbDepthGain.Enabled = true;
            tbDepthOffset.Enabled = true;
            tbWeightColumn.Enabled = true;
            tbWeightGain.Enabled = true;
            tbWeightOffset.Enabled = true;
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
            try
            {
                Variables.DepthCol = Convert.ToInt16(this.tbDepthColumn.Text);
                Program.SetSetting("DepthCol", this.tbDepthColumn.Text);
            }
            catch (FormatException)
            {
                // User input invalid.
                this.tbDepthColumn.Text = null;
            }
            
        }
        private void tbDepthGain_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Variables.DepthGain = Convert.ToSingle(this.tbDepthGain.Text);
                Program.SetSetting("DepthGain", this.tbDepthGain.Text);
            }
            catch (FormatException)
            {
                // User input invalid.
                this.tbDepthGain.Text = null;
            }
        }

        private void tbDepthOffset_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Variables.DepthOffset = Convert.ToSingle(this.tbDepthOffset.Text);
                Program.SetSetting("DepthOffset", this.tbDepthOffset.Text);
            }
            catch (FormatException)
            {
                // User input invalid.
                this.tbDepthOffset.Text = null;
            }
        }

        private void tbWeightColumn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Variables.WeightCol = Convert.ToInt16(this.tbWeightColumn.Text);
                Program.SetSetting("WeightCol", this.tbWeightColumn.Text);
            }
            catch (FormatException)
            {
                // User input invalid.
                this.tbWeightColumn.Text = null;
            }

        }

        private void tbWeightGain_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Variables.WeightGain = Convert.ToSingle(this.tbWeightGain.Text);
                Program.SetSetting("WeightGain", this.tbWeightGain.Text);
            }
            catch (FormatException)
            {
                // User input invalid.
                this.tbWeightGain.Text = null;
            }
        }

        private void tbWeightOffset_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Variables.WeightOffset = Convert.ToSingle(this.tbWeightOffset.Text);
                Program.SetSetting("WeightOffset", this.tbWeightOffset.Text);
            }
            catch (FormatException)
            {
                // User input invalid.
                this.tbWeightOffset.Text = null;
            }
        }


        private void btnNewJob_Click(object sender, EventArgs e)
        {
            try
            {
                Variables.ClearData();
                File.Delete("forcesdata.csv");
                Variables.ForcesData.dt.Clear();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Could not clear data.");
                Debug.WriteLine(ex);
            }
            
        }

  

        private void btnForceMon_Click(object sender, EventArgs e)
        {
            ForceMon viewer = new ForceMon();
            viewer.Show();           


        }     
    }
}
