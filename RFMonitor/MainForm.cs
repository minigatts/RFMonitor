using System;
using System.Windows.Forms;
using System.Timers;
using System.IO.Ports;
using System.Configuration;
using System.Diagnostics;

namespace CuddCal
{
    public partial class CuddCal : Form
    {
        SerialPortMonitor _spMon;
        SerialPortOutput _spOut;
        static System.Timers.Timer uiUpdateTimer;

        public CuddCal()
        {
            uiUpdateTimer = new System.Timers.Timer(1000);
            uiUpdateTimer.Elapsed += OnTimedUpdate;
            uiUpdateTimer.AutoReset = true;
            uiUpdateTimer.Enabled = true;

            // Initialize calibration values array
            fill_calibration_array();

            // Get a list of available serial port names.
            Variables.Ports = SerialPort.GetPortNames();

            Variables.ReadData();

            InitializeComponent();

            // Fill combo boxes for input / output with available port names.
            cbPortsIn.Items.AddRange(Variables.Ports);
            cbPortsOut.Items.AddRange(Variables.Ports);

            // Update entry text boxes to reflect config settings.
            cbPortsIn.Text = ConfigurationManager.AppSettings["SelectedCom"];
            cbPortsOut.Text = ConfigurationManager.AppSettings["SelectedComOut"];

            tbCircGain.Text = ConfigurationManager.AppSettings["CirculatingGain"];
            tbCircOffset.Text = ConfigurationManager.AppSettings["CirculatingOffset"];

            tbWellheadGain.Text = ConfigurationManager.AppSettings["WellheadGain"];
            tbWellheadOffset.Text = ConfigurationManager.AppSettings["WellheadOffset"];

            tbStripper1Gain.Text = ConfigurationManager.AppSettings["Stripper1Gain"];
            tbStripper1Offset.Text = ConfigurationManager.AppSettings["Stripper1Offset"];

            tbStripper2Gain.Text = ConfigurationManager.AppSettings["Stripper2Gain"];
            tbStripper2Offset.Text = ConfigurationManager.AppSettings["Stripper2Offset"];

            tbUpperSkateGain.Text = ConfigurationManager.AppSettings["UpperSkateGain"];
            tbUpperSkateOffset.Text = ConfigurationManager.AppSettings["UpperSkateOffset"];

            tbMiddleSkateGain.Text = ConfigurationManager.AppSettings["MiddleSkateGain"];
            tbMiddleSkateOffset.Text = ConfigurationManager.AppSettings["MiddleSkateOffset"];

            tbLowerSkateGain.Text = ConfigurationManager.AppSettings["LowerSkateGain"];
            tbLowerSkateOffset.Text = ConfigurationManager.AppSettings["LowerSkateOffset"];

            tbChainTensionGain.Text = ConfigurationManager.AppSettings["ChainTensionGain"];
            tbChainTensionOffset.Text = ConfigurationManager.AppSettings["ChainTensionOffset"];

            tbWeightGain.Text = ConfigurationManager.AppSettings["WeightGain"];
            tbWeightOffset.Text = ConfigurationManager.AppSettings["WeightOffset"];

            tbSpare1Gain.Text = ConfigurationManager.AppSettings["Spare1Gain"];
            tbSpare1Offset.Text = ConfigurationManager.AppSettings["Spare1Offset"];

            tbSpeedGain.Text = ConfigurationManager.AppSettings["SpeedGain"];
            tbSpeedOffset.Text = ConfigurationManager.AppSettings["SpeedOffset"];

            tbFlowRateGain.Text = ConfigurationManager.AppSettings["FlowRateGain"];
            tbFlowRateOffset.Text = ConfigurationManager.AppSettings["FlowRateOffset"];

            tbAuxFlowRateGain.Text = ConfigurationManager.AppSettings["AuxFlowRateGain"];
            tbAuxFlowRateOffset.Text = ConfigurationManager.AppSettings["AuxFlowRateOffset"];

            tbInjectorGain.Text = ConfigurationManager.AppSettings["InjectorGain"];
            tbInjectorOffset.Text = ConfigurationManager.AppSettings["InjectorOffset"];

            tbSpare2Gain.Text = ConfigurationManager.AppSettings["Spare2Gain"];
            tbSpare2Offset.Text = ConfigurationManager.AppSettings["Spare2Offset"];

            tbDepthGain.Text = ConfigurationManager.AppSettings["DepthGain"];
            tbDepthOffset.Text = ConfigurationManager.AppSettings["DepthOffset"];

        }

        private void btnConnect_Click(object sender, EventArgs e)        {            

            InitializeSerialPorts();

            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            cbPortsIn.Enabled = false;
            cbPortsOut.Enabled = false;

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _spMon.Close();
            _spOut.Close();

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            cbPortsIn.Enabled = true;
            cbPortsOut.Enabled = true;
        }

        private void InitializeSerialPorts()
        {
            // Monitor incoming serial data
            _spMon = new SerialPortMonitor();

            // Output calibrated data
            _spOut = new SerialPortOutput();
        }

        public void OnTimedUpdate(object source, ElapsedEventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    // Update form labels with latest calibrated channel values
                    updateChannelValues();

                    // Update info box.
                    if( Variables.InfoFeed != null & Variables.InfoFeed != "" )
                    {
                        AppendTextBoxLine(Variables.InfoFeed);
                        Variables.InfoFeed = "";
                    }
                    
                });
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
           
            
        }

        private void cbPortsIn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Program.SetSetting("SelectedCom", this.cbPortsIn.Text);
        }

        private void cbPortsOut_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Program.SetSetting("SelectedComOut", this.cbPortsOut.Text);
        }

        private void fill_calibration_array() 
        {
            // Retrieve calibration values from App.config

            Debug.WriteLine("Filling calibration array from App.config...");

            Variables.CalibrationValues[0, 0] = float.Parse(ConfigurationManager.AppSettings["CirculatingGain"]);
            Variables.CalibrationValues[0, 1] = float.Parse(ConfigurationManager.AppSettings["CirculatingOffset"]);

            Variables.CalibrationValues[1, 0] = float.Parse(ConfigurationManager.AppSettings["WellheadGain"]);
            Variables.CalibrationValues[1, 1] = float.Parse(ConfigurationManager.AppSettings["WellheadOffset"]);

            Variables.CalibrationValues[2, 0] = float.Parse(ConfigurationManager.AppSettings["Stripper1Gain"]);
            Variables.CalibrationValues[2, 1] = float.Parse(ConfigurationManager.AppSettings["Stripper1Offset"]);

            Variables.CalibrationValues[3, 0] = float.Parse(ConfigurationManager.AppSettings["Stripper2Gain"]);
            Variables.CalibrationValues[3, 1] = float.Parse(ConfigurationManager.AppSettings["Stripper2Offset"]);

            Variables.CalibrationValues[4, 0] = float.Parse(ConfigurationManager.AppSettings["UpperSkateGain"]);
            Variables.CalibrationValues[4, 1] = float.Parse(ConfigurationManager.AppSettings["UpperSkateOffset"]);

            Variables.CalibrationValues[5, 0] = float.Parse(ConfigurationManager.AppSettings["MiddleSkateGain"]);
            Variables.CalibrationValues[5, 1] = float.Parse(ConfigurationManager.AppSettings["MiddleSkateOffset"]);

            Variables.CalibrationValues[6, 0] = float.Parse(ConfigurationManager.AppSettings["LowerSkateGain"]);
            Variables.CalibrationValues[6, 1] = float.Parse(ConfigurationManager.AppSettings["LowerSkateOffset"]);

            Variables.CalibrationValues[7, 0] = float.Parse(ConfigurationManager.AppSettings["ChainTensionGain"]);
            Variables.CalibrationValues[7, 1] = float.Parse(ConfigurationManager.AppSettings["ChainTensionOffset"]);

            Variables.CalibrationValues[8, 0] = float.Parse(ConfigurationManager.AppSettings["WeightGain"]);
            Variables.CalibrationValues[8, 1] = float.Parse(ConfigurationManager.AppSettings["WeightOffset"]);

            Variables.CalibrationValues[9, 0] = float.Parse(ConfigurationManager.AppSettings["Spare1Gain"]);
            Variables.CalibrationValues[9, 1] = float.Parse(ConfigurationManager.AppSettings["Spare1Offset"]);

            Variables.CalibrationValues[10, 0] = float.Parse(ConfigurationManager.AppSettings["SpeedGain"]);
            Variables.CalibrationValues[10, 1] = float.Parse(ConfigurationManager.AppSettings["SpeedOffset"]);

            Variables.CalibrationValues[11, 0] = float.Parse(ConfigurationManager.AppSettings["FlowRateGain"]);
            Variables.CalibrationValues[11, 1] = float.Parse(ConfigurationManager.AppSettings["FlowRateOffset"]);

            Variables.CalibrationValues[12, 0] = float.Parse(ConfigurationManager.AppSettings["AuxFlowRateGain"]);
            Variables.CalibrationValues[12, 1] = float.Parse(ConfigurationManager.AppSettings["AuxFlowRateOffset"]);

            Variables.CalibrationValues[13, 0] = float.Parse(ConfigurationManager.AppSettings["InjectorGain"]);
            Variables.CalibrationValues[13, 1] = float.Parse(ConfigurationManager.AppSettings["InjectorOffset"]);

            Variables.CalibrationValues[14, 0] = float.Parse(ConfigurationManager.AppSettings["Spare2Gain"]);
            Variables.CalibrationValues[14, 1] = float.Parse(ConfigurationManager.AppSettings["Spare2Offset"]);

            Variables.CalibrationValues[15, 0] = float.Parse(ConfigurationManager.AppSettings["DepthGain"]);
            Variables.CalibrationValues[15, 1] = float.Parse(ConfigurationManager.AppSettings["DepthOffset"]);

            for(int i = 0; i <= 15; i++)
            {
                Debug.WriteLine(Variables.Channels[i] + " Gain : " + Variables.CalibrationValues[i, 0] +  " Offset : " + Variables.CalibrationValues[i, 1]);
            }
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            AppendTextBoxLine("Appying calibration settings to config.");
          
            // Commit text field values to App settings
            try
            {

                Program.SetSetting("CirculatingGain", this.tbCircGain.Text);
                Program.SetSetting("CirculatingOffset", this.tbCircOffset.Text);

                Program.SetSetting("WellheadGain", this.tbWellheadGain.Text);
                Program.SetSetting("WellheadOffset", this.tbWellheadOffset.Text);

                Program.SetSetting("Stripper1Gain", this.tbStripper1Gain.Text);
                Program.SetSetting("Stripper1Offset", this.tbStripper1Offset.Text);                

                Program.SetSetting("Stripper2Gain", this.tbStripper2Gain.Text);
                Program.SetSetting("Stripper2Offset", this.tbStripper2Offset.Text);            

                Program.SetSetting("UpperSkateGain", this.tbUpperSkateGain.Text);
                Program.SetSetting("UpperSkateOffset", this.tbUpperSkateOffset.Text);                

                Program.SetSetting("MiddleSkateGain", this.tbMiddleSkateGain.Text);
                Program.SetSetting("MiddleSkateOffset", this.tbMiddleSkateOffset.Text);                

                Program.SetSetting("LowerSkateGain", this.tbLowerSkateGain.Text);
                Program.SetSetting("LowerSkateOffset", this.tbLowerSkateOffset.Text);

                Program.SetSetting("ChainTensionGain", this.tbChainTensionGain.Text);
                Program.SetSetting("ChainTensionOffset", this.tbChainTensionOffset.Text);

                Program.SetSetting("WeightGain", this.tbWeightGain.Text);
                Program.SetSetting("WeightOffset", this.tbWeightOffset.Text);                

                Program.SetSetting("Spare1Gain", this.tbSpare1Gain.Text);
                Program.SetSetting("Spare1Offset", this.tbSpare1Offset.Text);       

                Program.SetSetting("SpeedGain", this.tbSpeedGain.Text);
                Program.SetSetting("SpeedOffset", this.tbSpeedOffset.Text);

                Program.SetSetting("FlowRateGain", this.tbFlowRateGain.Text);
                Program.SetSetting("FlowRateOffset", this.tbFlowRateOffset.Text);

                Program.SetSetting("AuxFlowRateGain", this.tbAuxFlowRateOffset.Text);
                Program.SetSetting("AuxFlowRateOffset", this.tbAuxFlowRateOffset.Text);

                Program.SetSetting("InjectorGain", this.tbInjectorGain.Text);
                Program.SetSetting("InjectorOffset", this.tbInjectorOffset.Text);

                Program.SetSetting("Spare2Gain", this.tbSpare2Gain.Text);
                Program.SetSetting("Spare2Offset", this.tbSpare2Offset.Text);

                Program.SetSetting("DepthGain", this.tbDepthGain.Text);
                Program.SetSetting("DepthOffset", this.tbDepthOffset.Text);

                Debug.WriteLine("Done applying to config.");

                try 
                {
                    AppendTextBoxLine("Applying updated values to calibration array");
                    fill_calibration_array();
                    AppendTextBoxLine("Done.");
                }
                catch (Exception ex)
                {
                    AppendTextBoxLine("Failed to apply updated values to calibration array");
                    Debug.WriteLine(ex.Message);
                }
                

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }            
            
        }

        private void updateChannelValues()
        {
            // Update main form labels with calibrated channel values
            this.lbCircValue.Text = Variables.CalibrationValues[0,2].ToString();
            this.lbWellheadValue.Text = Variables.CalibrationValues[1, 2].ToString();
            this.lbStripper1Value.Text = Variables.CalibrationValues[2, 2].ToString();
            this.lbStripper2Value.Text = Variables.CalibrationValues[3, 2].ToString();
            this.lbUpperSkateValue.Text = Variables.CalibrationValues[4, 2].ToString();
            this.lbMiddleSkateValue.Text = Variables.CalibrationValues[5, 2].ToString();
            this.lbLowerSkateValue.Text = Variables.CalibrationValues[6, 2].ToString();
            this.lbChainTensionValue.Text = Variables.CalibrationValues[7, 2].ToString();
            this.lbWeightValue.Text = Variables.CalibrationValues[8, 2].ToString();
            this.lbSpare1Value.Text = Variables.CalibrationValues[9, 2].ToString();
            this.lbSpeedValue.Text = Variables.CalibrationValues[10, 2].ToString();
            this.lbFlowRateValue.Text = Variables.CalibrationValues[11, 2].ToString();
            this.lbAuxFlowRateValue.Text = Variables.CalibrationValues[12, 2].ToString();
            this.lbInjectorValue.Text = Variables.CalibrationValues[13, 2].ToString();
            this.lbSpare2Value.Text = Variables.CalibrationValues[14, 2].ToString();
            this.lbDepthValue.Text = Variables.CalibrationValues[15, 2].ToString();

        }

        public void AppendTextBoxLine(string myStr)
        {
            if (tbInfo.Text.Length > 0)
            {
                tbInfo.AppendText(Environment.NewLine);
            }
            tbInfo.AppendText(myStr);
        }      

    }
}
