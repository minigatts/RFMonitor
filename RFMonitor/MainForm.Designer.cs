
namespace CuddCal
{
    partial class CuddCal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuddCal));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbPortsIn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDepthOffset = new System.Windows.Forms.TextBox();
            this.tbDepthGain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbCircGain = new System.Windows.Forms.TextBox();
            this.tbCircOffset = new System.Windows.Forms.TextBox();
            this.tbWellheadGain = new System.Windows.Forms.TextBox();
            this.tbWellheadOffset = new System.Windows.Forms.TextBox();
            this.tbStripper1Gain = new System.Windows.Forms.TextBox();
            this.tbStripper1Offset = new System.Windows.Forms.TextBox();
            this.tbStripper2Gain = new System.Windows.Forms.TextBox();
            this.tbStripper2Offset = new System.Windows.Forms.TextBox();
            this.tbUpperSkateGain = new System.Windows.Forms.TextBox();
            this.tbUpperSkateOffset = new System.Windows.Forms.TextBox();
            this.tbMiddleSkateGain = new System.Windows.Forms.TextBox();
            this.tbMiddleSkateOffset = new System.Windows.Forms.TextBox();
            this.tbFlowRateGain = new System.Windows.Forms.TextBox();
            this.tbFlowRateOffset = new System.Windows.Forms.TextBox();
            this.tbSpeedGain = new System.Windows.Forms.TextBox();
            this.tbSpeedOffset = new System.Windows.Forms.TextBox();
            this.tbSpare1Gain = new System.Windows.Forms.TextBox();
            this.tbSpare1Offset = new System.Windows.Forms.TextBox();
            this.tbWeightGain = new System.Windows.Forms.TextBox();
            this.tbWeightOffset = new System.Windows.Forms.TextBox();
            this.tbChainTensionGain = new System.Windows.Forms.TextBox();
            this.tbChainTensionOffset = new System.Windows.Forms.TextBox();
            this.tbLowerSkateGain = new System.Windows.Forms.TextBox();
            this.tbLowerSkateOffset = new System.Windows.Forms.TextBox();
            this.tbAuxFlowRateGain = new System.Windows.Forms.TextBox();
            this.tbAuxFlowRateOffset = new System.Windows.Forms.TextBox();
            this.tbSpare2Gain = new System.Windows.Forms.TextBox();
            this.tbSpare2Offset = new System.Windows.Forms.TextBox();
            this.tbInjectorGain = new System.Windows.Forms.TextBox();
            this.tbInjectorOffset = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDepthValue = new System.Windows.Forms.Label();
            this.lbSpare2Value = new System.Windows.Forms.Label();
            this.lbInjectorValue = new System.Windows.Forms.Label();
            this.lbAuxFlowRateValue = new System.Windows.Forms.Label();
            this.lbFlowRateValue = new System.Windows.Forms.Label();
            this.lbSpeedValue = new System.Windows.Forms.Label();
            this.lbSpare1Value = new System.Windows.Forms.Label();
            this.lbWeightValue = new System.Windows.Forms.Label();
            this.lbChainTensionValue = new System.Windows.Forms.Label();
            this.lbLowerSkateValue = new System.Windows.Forms.Label();
            this.lbMiddleSkateValue = new System.Windows.Forms.Label();
            this.lbUpperSkateValue = new System.Windows.Forms.Label();
            this.lbStripper2Value = new System.Windows.Forms.Label();
            this.lbStripper1Value = new System.Windows.Forms.Label();
            this.lbWellheadValue = new System.Windows.Forms.Label();
            this.lbCircValue = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cbPortsOut = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnect.Location = new System.Drawing.Point(382, 10);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(129, 24);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(382, 48);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(129, 24);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cbPortsIn
            // 
            this.cbPortsIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPortsIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortsIn.FormattingEnabled = true;
            this.cbPortsIn.Location = new System.Drawing.Point(15, 34);
            this.cbPortsIn.Margin = new System.Windows.Forms.Padding(4);
            this.cbPortsIn.Name = "cbPortsIn";
            this.cbPortsIn.Size = new System.Drawing.Size(128, 24);
            this.cbPortsIn.TabIndex = 17;
            this.cbPortsIn.SelectionChangeCommitted += new System.EventHandler(this.cbPortsIn_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "DAS COM Port";
            // 
            // tbDepthOffset
            // 
            this.tbDepthOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDepthOffset.Location = new System.Drawing.Point(382, 586);
            this.tbDepthOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbDepthOffset.Name = "tbDepthOffset";
            this.tbDepthOffset.Size = new System.Drawing.Size(128, 22);
            this.tbDepthOffset.TabIndex = 22;
            // 
            // tbDepthGain
            // 
            this.tbDepthGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDepthGain.Location = new System.Drawing.Point(199, 586);
            this.tbDepthGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbDepthGain.Name = "tbDepthGain";
            this.tbDepthGain.Size = new System.Drawing.Size(128, 22);
            this.tbDepthGain.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Circulating";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Wellhead";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Stripper 1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Stripper 2";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Upper Skate Pressure";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Middle Skate Pressure";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 310);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Lower Skate Pressure";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 341);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Chain Tension";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 372);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Weight";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 403);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Spare Input 1";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 434);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "Speed";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 465);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Flow Rate";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 496);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Aux Flow Rate";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 527);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 16);
            this.label17.TabIndex = 39;
            this.label17.Text = "Injector Pressure";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 558);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 16);
            this.label18.TabIndex = 40;
            this.label18.Text = "Spare Input 2";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 589);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 16);
            this.label19.TabIndex = 41;
            this.label19.Text = "Depth";
            // 
            // tbCircGain
            // 
            this.tbCircGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCircGain.Location = new System.Drawing.Point(199, 121);
            this.tbCircGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbCircGain.Name = "tbCircGain";
            this.tbCircGain.Size = new System.Drawing.Size(128, 22);
            this.tbCircGain.TabIndex = 43;
            // 
            // tbCircOffset
            // 
            this.tbCircOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCircOffset.Location = new System.Drawing.Point(382, 121);
            this.tbCircOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbCircOffset.Name = "tbCircOffset";
            this.tbCircOffset.Size = new System.Drawing.Size(128, 22);
            this.tbCircOffset.TabIndex = 42;
            // 
            // tbWellheadGain
            // 
            this.tbWellheadGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbWellheadGain.Location = new System.Drawing.Point(199, 152);
            this.tbWellheadGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbWellheadGain.Name = "tbWellheadGain";
            this.tbWellheadGain.Size = new System.Drawing.Size(128, 22);
            this.tbWellheadGain.TabIndex = 45;
            // 
            // tbWellheadOffset
            // 
            this.tbWellheadOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbWellheadOffset.Location = new System.Drawing.Point(382, 152);
            this.tbWellheadOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbWellheadOffset.Name = "tbWellheadOffset";
            this.tbWellheadOffset.Size = new System.Drawing.Size(128, 22);
            this.tbWellheadOffset.TabIndex = 44;
            // 
            // tbStripper1Gain
            // 
            this.tbStripper1Gain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbStripper1Gain.Location = new System.Drawing.Point(199, 183);
            this.tbStripper1Gain.Margin = new System.Windows.Forms.Padding(4);
            this.tbStripper1Gain.Name = "tbStripper1Gain";
            this.tbStripper1Gain.Size = new System.Drawing.Size(128, 22);
            this.tbStripper1Gain.TabIndex = 47;
            // 
            // tbStripper1Offset
            // 
            this.tbStripper1Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbStripper1Offset.Location = new System.Drawing.Point(382, 183);
            this.tbStripper1Offset.Margin = new System.Windows.Forms.Padding(4);
            this.tbStripper1Offset.Name = "tbStripper1Offset";
            this.tbStripper1Offset.Size = new System.Drawing.Size(128, 22);
            this.tbStripper1Offset.TabIndex = 46;
            // 
            // tbStripper2Gain
            // 
            this.tbStripper2Gain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbStripper2Gain.Location = new System.Drawing.Point(199, 214);
            this.tbStripper2Gain.Margin = new System.Windows.Forms.Padding(4);
            this.tbStripper2Gain.Name = "tbStripper2Gain";
            this.tbStripper2Gain.Size = new System.Drawing.Size(128, 22);
            this.tbStripper2Gain.TabIndex = 49;
            // 
            // tbStripper2Offset
            // 
            this.tbStripper2Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbStripper2Offset.Location = new System.Drawing.Point(382, 214);
            this.tbStripper2Offset.Margin = new System.Windows.Forms.Padding(4);
            this.tbStripper2Offset.Name = "tbStripper2Offset";
            this.tbStripper2Offset.Size = new System.Drawing.Size(128, 22);
            this.tbStripper2Offset.TabIndex = 48;
            // 
            // tbUpperSkateGain
            // 
            this.tbUpperSkateGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbUpperSkateGain.Location = new System.Drawing.Point(199, 245);
            this.tbUpperSkateGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbUpperSkateGain.Name = "tbUpperSkateGain";
            this.tbUpperSkateGain.Size = new System.Drawing.Size(128, 22);
            this.tbUpperSkateGain.TabIndex = 51;
            // 
            // tbUpperSkateOffset
            // 
            this.tbUpperSkateOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbUpperSkateOffset.Location = new System.Drawing.Point(382, 245);
            this.tbUpperSkateOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbUpperSkateOffset.Name = "tbUpperSkateOffset";
            this.tbUpperSkateOffset.Size = new System.Drawing.Size(128, 22);
            this.tbUpperSkateOffset.TabIndex = 50;
            // 
            // tbMiddleSkateGain
            // 
            this.tbMiddleSkateGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMiddleSkateGain.Location = new System.Drawing.Point(199, 276);
            this.tbMiddleSkateGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbMiddleSkateGain.Name = "tbMiddleSkateGain";
            this.tbMiddleSkateGain.Size = new System.Drawing.Size(128, 22);
            this.tbMiddleSkateGain.TabIndex = 53;
            // 
            // tbMiddleSkateOffset
            // 
            this.tbMiddleSkateOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMiddleSkateOffset.Location = new System.Drawing.Point(382, 276);
            this.tbMiddleSkateOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbMiddleSkateOffset.Name = "tbMiddleSkateOffset";
            this.tbMiddleSkateOffset.Size = new System.Drawing.Size(128, 22);
            this.tbMiddleSkateOffset.TabIndex = 52;
            // 
            // tbFlowRateGain
            // 
            this.tbFlowRateGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFlowRateGain.Location = new System.Drawing.Point(199, 462);
            this.tbFlowRateGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbFlowRateGain.Name = "tbFlowRateGain";
            this.tbFlowRateGain.Size = new System.Drawing.Size(128, 22);
            this.tbFlowRateGain.TabIndex = 65;
            // 
            // tbFlowRateOffset
            // 
            this.tbFlowRateOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFlowRateOffset.Location = new System.Drawing.Point(382, 462);
            this.tbFlowRateOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbFlowRateOffset.Name = "tbFlowRateOffset";
            this.tbFlowRateOffset.Size = new System.Drawing.Size(128, 22);
            this.tbFlowRateOffset.TabIndex = 64;
            // 
            // tbSpeedGain
            // 
            this.tbSpeedGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSpeedGain.Location = new System.Drawing.Point(199, 431);
            this.tbSpeedGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbSpeedGain.Name = "tbSpeedGain";
            this.tbSpeedGain.Size = new System.Drawing.Size(128, 22);
            this.tbSpeedGain.TabIndex = 63;
            // 
            // tbSpeedOffset
            // 
            this.tbSpeedOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSpeedOffset.Location = new System.Drawing.Point(382, 431);
            this.tbSpeedOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbSpeedOffset.Name = "tbSpeedOffset";
            this.tbSpeedOffset.Size = new System.Drawing.Size(128, 22);
            this.tbSpeedOffset.TabIndex = 62;
            // 
            // tbSpare1Gain
            // 
            this.tbSpare1Gain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSpare1Gain.Location = new System.Drawing.Point(199, 400);
            this.tbSpare1Gain.Margin = new System.Windows.Forms.Padding(4);
            this.tbSpare1Gain.Name = "tbSpare1Gain";
            this.tbSpare1Gain.Size = new System.Drawing.Size(128, 22);
            this.tbSpare1Gain.TabIndex = 61;
            // 
            // tbSpare1Offset
            // 
            this.tbSpare1Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSpare1Offset.Location = new System.Drawing.Point(382, 400);
            this.tbSpare1Offset.Margin = new System.Windows.Forms.Padding(4);
            this.tbSpare1Offset.Name = "tbSpare1Offset";
            this.tbSpare1Offset.Size = new System.Drawing.Size(128, 22);
            this.tbSpare1Offset.TabIndex = 60;
            // 
            // tbWeightGain
            // 
            this.tbWeightGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbWeightGain.Location = new System.Drawing.Point(199, 369);
            this.tbWeightGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbWeightGain.Name = "tbWeightGain";
            this.tbWeightGain.Size = new System.Drawing.Size(128, 22);
            this.tbWeightGain.TabIndex = 59;
            // 
            // tbWeightOffset
            // 
            this.tbWeightOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbWeightOffset.Location = new System.Drawing.Point(382, 369);
            this.tbWeightOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbWeightOffset.Name = "tbWeightOffset";
            this.tbWeightOffset.Size = new System.Drawing.Size(128, 22);
            this.tbWeightOffset.TabIndex = 58;
            // 
            // tbChainTensionGain
            // 
            this.tbChainTensionGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbChainTensionGain.Location = new System.Drawing.Point(199, 338);
            this.tbChainTensionGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbChainTensionGain.Name = "tbChainTensionGain";
            this.tbChainTensionGain.Size = new System.Drawing.Size(128, 22);
            this.tbChainTensionGain.TabIndex = 57;
            // 
            // tbChainTensionOffset
            // 
            this.tbChainTensionOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbChainTensionOffset.Location = new System.Drawing.Point(382, 338);
            this.tbChainTensionOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbChainTensionOffset.Name = "tbChainTensionOffset";
            this.tbChainTensionOffset.Size = new System.Drawing.Size(128, 22);
            this.tbChainTensionOffset.TabIndex = 56;
            // 
            // tbLowerSkateGain
            // 
            this.tbLowerSkateGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLowerSkateGain.Location = new System.Drawing.Point(199, 307);
            this.tbLowerSkateGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbLowerSkateGain.Name = "tbLowerSkateGain";
            this.tbLowerSkateGain.Size = new System.Drawing.Size(128, 22);
            this.tbLowerSkateGain.TabIndex = 55;
            // 
            // tbLowerSkateOffset
            // 
            this.tbLowerSkateOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLowerSkateOffset.Location = new System.Drawing.Point(382, 307);
            this.tbLowerSkateOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbLowerSkateOffset.Name = "tbLowerSkateOffset";
            this.tbLowerSkateOffset.Size = new System.Drawing.Size(128, 22);
            this.tbLowerSkateOffset.TabIndex = 54;
            // 
            // tbAuxFlowRateGain
            // 
            this.tbAuxFlowRateGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAuxFlowRateGain.Location = new System.Drawing.Point(199, 492);
            this.tbAuxFlowRateGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbAuxFlowRateGain.Name = "tbAuxFlowRateGain";
            this.tbAuxFlowRateGain.Size = new System.Drawing.Size(128, 22);
            this.tbAuxFlowRateGain.TabIndex = 67;
            // 
            // tbAuxFlowRateOffset
            // 
            this.tbAuxFlowRateOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAuxFlowRateOffset.Location = new System.Drawing.Point(382, 492);
            this.tbAuxFlowRateOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbAuxFlowRateOffset.Name = "tbAuxFlowRateOffset";
            this.tbAuxFlowRateOffset.Size = new System.Drawing.Size(128, 22);
            this.tbAuxFlowRateOffset.TabIndex = 66;
            // 
            // tbSpare2Gain
            // 
            this.tbSpare2Gain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSpare2Gain.Location = new System.Drawing.Point(199, 555);
            this.tbSpare2Gain.Margin = new System.Windows.Forms.Padding(4);
            this.tbSpare2Gain.Name = "tbSpare2Gain";
            this.tbSpare2Gain.Size = new System.Drawing.Size(128, 22);
            this.tbSpare2Gain.TabIndex = 71;
            // 
            // tbSpare2Offset
            // 
            this.tbSpare2Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSpare2Offset.Location = new System.Drawing.Point(382, 555);
            this.tbSpare2Offset.Margin = new System.Windows.Forms.Padding(4);
            this.tbSpare2Offset.Name = "tbSpare2Offset";
            this.tbSpare2Offset.Size = new System.Drawing.Size(128, 22);
            this.tbSpare2Offset.TabIndex = 70;
            // 
            // tbInjectorGain
            // 
            this.tbInjectorGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbInjectorGain.Location = new System.Drawing.Point(199, 525);
            this.tbInjectorGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbInjectorGain.Name = "tbInjectorGain";
            this.tbInjectorGain.Size = new System.Drawing.Size(128, 22);
            this.tbInjectorGain.TabIndex = 69;
            // 
            // tbInjectorOffset
            // 
            this.tbInjectorOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbInjectorOffset.Location = new System.Drawing.Point(382, 525);
            this.tbInjectorOffset.Margin = new System.Windows.Forms.Padding(4);
            this.tbInjectorOffset.Name = "tbInjectorOffset";
            this.tbInjectorOffset.Size = new System.Drawing.Size(128, 22);
            this.tbInjectorOffset.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Gain";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Offset";
            // 
            // lbDepthValue
            // 
            this.lbDepthValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDepthValue.AutoSize = true;
            this.lbDepthValue.Location = new System.Drawing.Point(531, 589);
            this.lbDepthValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDepthValue.Name = "lbDepthValue";
            this.lbDepthValue.Size = new System.Drawing.Size(43, 16);
            this.lbDepthValue.TabIndex = 89;
            this.lbDepthValue.Text = "Depth";
            // 
            // lbSpare2Value
            // 
            this.lbSpare2Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSpare2Value.AutoSize = true;
            this.lbSpare2Value.Location = new System.Drawing.Point(531, 558);
            this.lbSpare2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSpare2Value.Name = "lbSpare2Value";
            this.lbSpare2Value.Size = new System.Drawing.Size(85, 16);
            this.lbSpare2Value.TabIndex = 88;
            this.lbSpare2Value.Text = "Spare Input 2";
            // 
            // lbInjectorValue
            // 
            this.lbInjectorValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInjectorValue.AutoSize = true;
            this.lbInjectorValue.Location = new System.Drawing.Point(531, 527);
            this.lbInjectorValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInjectorValue.Name = "lbInjectorValue";
            this.lbInjectorValue.Size = new System.Drawing.Size(107, 16);
            this.lbInjectorValue.TabIndex = 87;
            this.lbInjectorValue.Text = "Injector Pressure";
            // 
            // lbAuxFlowRateValue
            // 
            this.lbAuxFlowRateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAuxFlowRateValue.AutoSize = true;
            this.lbAuxFlowRateValue.Location = new System.Drawing.Point(531, 496);
            this.lbAuxFlowRateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuxFlowRateValue.Name = "lbAuxFlowRateValue";
            this.lbAuxFlowRateValue.Size = new System.Drawing.Size(92, 16);
            this.lbAuxFlowRateValue.TabIndex = 86;
            this.lbAuxFlowRateValue.Text = "Aux Flow Rate";
            // 
            // lbFlowRateValue
            // 
            this.lbFlowRateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFlowRateValue.AutoSize = true;
            this.lbFlowRateValue.Location = new System.Drawing.Point(531, 465);
            this.lbFlowRateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFlowRateValue.Name = "lbFlowRateValue";
            this.lbFlowRateValue.Size = new System.Drawing.Size(67, 16);
            this.lbFlowRateValue.TabIndex = 85;
            this.lbFlowRateValue.Text = "Flow Rate";
            // 
            // lbSpeedValue
            // 
            this.lbSpeedValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSpeedValue.AutoSize = true;
            this.lbSpeedValue.Location = new System.Drawing.Point(531, 434);
            this.lbSpeedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSpeedValue.Name = "lbSpeedValue";
            this.lbSpeedValue.Size = new System.Drawing.Size(48, 16);
            this.lbSpeedValue.TabIndex = 84;
            this.lbSpeedValue.Text = "Speed";
            // 
            // lbSpare1Value
            // 
            this.lbSpare1Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSpare1Value.AutoSize = true;
            this.lbSpare1Value.Location = new System.Drawing.Point(531, 403);
            this.lbSpare1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSpare1Value.Name = "lbSpare1Value";
            this.lbSpare1Value.Size = new System.Drawing.Size(85, 16);
            this.lbSpare1Value.TabIndex = 83;
            this.lbSpare1Value.Text = "Spare Input 1";
            // 
            // lbWeightValue
            // 
            this.lbWeightValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbWeightValue.AutoSize = true;
            this.lbWeightValue.Location = new System.Drawing.Point(531, 372);
            this.lbWeightValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWeightValue.Name = "lbWeightValue";
            this.lbWeightValue.Size = new System.Drawing.Size(49, 16);
            this.lbWeightValue.TabIndex = 82;
            this.lbWeightValue.Text = "Weight";
            // 
            // lbChainTensionValue
            // 
            this.lbChainTensionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbChainTensionValue.AutoSize = true;
            this.lbChainTensionValue.Location = new System.Drawing.Point(531, 341);
            this.lbChainTensionValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChainTensionValue.Name = "lbChainTensionValue";
            this.lbChainTensionValue.Size = new System.Drawing.Size(93, 16);
            this.lbChainTensionValue.TabIndex = 81;
            this.lbChainTensionValue.Text = "Chain Tension";
            // 
            // lbLowerSkateValue
            // 
            this.lbLowerSkateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLowerSkateValue.AutoSize = true;
            this.lbLowerSkateValue.Location = new System.Drawing.Point(531, 310);
            this.lbLowerSkateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLowerSkateValue.Name = "lbLowerSkateValue";
            this.lbLowerSkateValue.Size = new System.Drawing.Size(138, 16);
            this.lbLowerSkateValue.TabIndex = 80;
            this.lbLowerSkateValue.Text = "Lower Skate Pressure";
            // 
            // lbMiddleSkateValue
            // 
            this.lbMiddleSkateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMiddleSkateValue.AutoSize = true;
            this.lbMiddleSkateValue.Location = new System.Drawing.Point(531, 279);
            this.lbMiddleSkateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMiddleSkateValue.Name = "lbMiddleSkateValue";
            this.lbMiddleSkateValue.Size = new System.Drawing.Size(143, 16);
            this.lbMiddleSkateValue.TabIndex = 79;
            this.lbMiddleSkateValue.Text = "Middle Skate Pressure";
            // 
            // lbUpperSkateValue
            // 
            this.lbUpperSkateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUpperSkateValue.AutoSize = true;
            this.lbUpperSkateValue.Location = new System.Drawing.Point(531, 248);
            this.lbUpperSkateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUpperSkateValue.Name = "lbUpperSkateValue";
            this.lbUpperSkateValue.Size = new System.Drawing.Size(140, 16);
            this.lbUpperSkateValue.TabIndex = 78;
            this.lbUpperSkateValue.Text = "Upper Skate Pressure";
            // 
            // lbStripper2Value
            // 
            this.lbStripper2Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStripper2Value.AutoSize = true;
            this.lbStripper2Value.Location = new System.Drawing.Point(531, 217);
            this.lbStripper2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStripper2Value.Name = "lbStripper2Value";
            this.lbStripper2Value.Size = new System.Drawing.Size(64, 16);
            this.lbStripper2Value.TabIndex = 77;
            this.lbStripper2Value.Text = "Stripper 2";
            // 
            // lbStripper1Value
            // 
            this.lbStripper1Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStripper1Value.AutoSize = true;
            this.lbStripper1Value.Location = new System.Drawing.Point(531, 186);
            this.lbStripper1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStripper1Value.Name = "lbStripper1Value";
            this.lbStripper1Value.Size = new System.Drawing.Size(64, 16);
            this.lbStripper1Value.TabIndex = 76;
            this.lbStripper1Value.Text = "Stripper 1";
            // 
            // lbWellheadValue
            // 
            this.lbWellheadValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbWellheadValue.AutoSize = true;
            this.lbWellheadValue.Location = new System.Drawing.Point(531, 155);
            this.lbWellheadValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWellheadValue.Name = "lbWellheadValue";
            this.lbWellheadValue.Size = new System.Drawing.Size(65, 16);
            this.lbWellheadValue.TabIndex = 75;
            this.lbWellheadValue.Text = "Wellhead";
            // 
            // lbCircValue
            // 
            this.lbCircValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCircValue.AutoSize = true;
            this.lbCircValue.Location = new System.Drawing.Point(531, 124);
            this.lbCircValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCircValue.Name = "lbCircValue";
            this.lbCircValue.Size = new System.Drawing.Size(69, 16);
            this.lbCircValue.TabIndex = 74;
            this.lbCircValue.Text = "Circulating";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(539, 30);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(130, 24);
            this.btnApply.TabIndex = 90;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(211, 14);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 16);
            this.label20.TabIndex = 92;
            this.label20.Text = "Output COM Port";
            // 
            // cbPortsOut
            // 
            this.cbPortsOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPortsOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortsOut.FormattingEnabled = true;
            this.cbPortsOut.Location = new System.Drawing.Point(199, 34);
            this.cbPortsOut.Margin = new System.Windows.Forms.Padding(4);
            this.cbPortsOut.Name = "cbPortsOut";
            this.cbPortsOut.Size = new System.Drawing.Size(128, 24);
            this.cbPortsOut.TabIndex = 91;
            this.cbPortsOut.SelectedIndexChanged += new System.EventHandler(this.cbPortsOut_SelectionChangeCommitted);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(575, 101);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 16);
            this.label21.TabIndex = 93;
            this.label21.Text = "Output";
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbInfo.Location = new System.Drawing.Point(12, 628);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(666, 61);
            this.tbInfo.TabIndex = 94;
            // 
            // CuddCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(690, 701);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbPortsOut);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lbDepthValue);
            this.Controls.Add(this.lbSpare2Value);
            this.Controls.Add(this.lbInjectorValue);
            this.Controls.Add(this.lbAuxFlowRateValue);
            this.Controls.Add(this.lbFlowRateValue);
            this.Controls.Add(this.lbSpeedValue);
            this.Controls.Add(this.lbSpare1Value);
            this.Controls.Add(this.lbWeightValue);
            this.Controls.Add(this.lbChainTensionValue);
            this.Controls.Add(this.lbLowerSkateValue);
            this.Controls.Add(this.lbMiddleSkateValue);
            this.Controls.Add(this.lbUpperSkateValue);
            this.Controls.Add(this.lbStripper2Value);
            this.Controls.Add(this.lbStripper1Value);
            this.Controls.Add(this.lbWellheadValue);
            this.Controls.Add(this.lbCircValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSpare2Gain);
            this.Controls.Add(this.tbSpare2Offset);
            this.Controls.Add(this.tbInjectorGain);
            this.Controls.Add(this.tbInjectorOffset);
            this.Controls.Add(this.tbAuxFlowRateGain);
            this.Controls.Add(this.tbAuxFlowRateOffset);
            this.Controls.Add(this.tbFlowRateGain);
            this.Controls.Add(this.tbFlowRateOffset);
            this.Controls.Add(this.tbSpeedGain);
            this.Controls.Add(this.tbSpeedOffset);
            this.Controls.Add(this.tbSpare1Gain);
            this.Controls.Add(this.tbSpare1Offset);
            this.Controls.Add(this.tbWeightGain);
            this.Controls.Add(this.tbWeightOffset);
            this.Controls.Add(this.tbChainTensionGain);
            this.Controls.Add(this.tbChainTensionOffset);
            this.Controls.Add(this.tbLowerSkateGain);
            this.Controls.Add(this.tbLowerSkateOffset);
            this.Controls.Add(this.tbMiddleSkateGain);
            this.Controls.Add(this.tbMiddleSkateOffset);
            this.Controls.Add(this.tbUpperSkateGain);
            this.Controls.Add(this.tbUpperSkateOffset);
            this.Controls.Add(this.tbStripper2Gain);
            this.Controls.Add(this.tbStripper2Offset);
            this.Controls.Add(this.tbStripper1Gain);
            this.Controls.Add(this.tbStripper1Offset);
            this.Controls.Add(this.tbWellheadGain);
            this.Controls.Add(this.tbWellheadOffset);
            this.Controls.Add(this.tbCircGain);
            this.Controls.Add(this.tbCircOffset);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDepthGain);
            this.Controls.Add(this.tbDepthOffset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPortsIn);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(465, 574);
            this.Name = "CuddCal";
            this.Text = "CUDD-Cal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox cbPortsIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDepthOffset;
        private System.Windows.Forms.TextBox tbDepthGain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbCircGain;
        private System.Windows.Forms.TextBox tbCircOffset;
        private System.Windows.Forms.TextBox tbWellheadGain;
        private System.Windows.Forms.TextBox tbWellheadOffset;
        private System.Windows.Forms.TextBox tbStripper1Gain;
        private System.Windows.Forms.TextBox tbStripper1Offset;
        private System.Windows.Forms.TextBox tbStripper2Gain;
        private System.Windows.Forms.TextBox tbStripper2Offset;
        private System.Windows.Forms.TextBox tbUpperSkateGain;
        private System.Windows.Forms.TextBox tbUpperSkateOffset;
        private System.Windows.Forms.TextBox tbMiddleSkateGain;
        private System.Windows.Forms.TextBox tbMiddleSkateOffset;
        private System.Windows.Forms.TextBox tbFlowRateGain;
        private System.Windows.Forms.TextBox tbFlowRateOffset;
        private System.Windows.Forms.TextBox tbSpeedGain;
        private System.Windows.Forms.TextBox tbSpeedOffset;
        private System.Windows.Forms.TextBox tbSpare1Gain;
        private System.Windows.Forms.TextBox tbSpare1Offset;
        private System.Windows.Forms.TextBox tbWeightGain;
        private System.Windows.Forms.TextBox tbWeightOffset;
        private System.Windows.Forms.TextBox tbChainTensionGain;
        private System.Windows.Forms.TextBox tbChainTensionOffset;
        private System.Windows.Forms.TextBox tbLowerSkateGain;
        private System.Windows.Forms.TextBox tbLowerSkateOffset;
        private System.Windows.Forms.TextBox tbAuxFlowRateGain;
        private System.Windows.Forms.TextBox tbAuxFlowRateOffset;
        private System.Windows.Forms.TextBox tbSpare2Gain;
        private System.Windows.Forms.TextBox tbSpare2Offset;
        private System.Windows.Forms.TextBox tbInjectorGain;
        private System.Windows.Forms.TextBox tbInjectorOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDepthValue;
        private System.Windows.Forms.Label lbSpare2Value;
        private System.Windows.Forms.Label lbInjectorValue;
        private System.Windows.Forms.Label lbAuxFlowRateValue;
        private System.Windows.Forms.Label lbFlowRateValue;
        private System.Windows.Forms.Label lbSpeedValue;
        private System.Windows.Forms.Label lbSpare1Value;
        private System.Windows.Forms.Label lbWeightValue;
        private System.Windows.Forms.Label lbChainTensionValue;
        private System.Windows.Forms.Label lbLowerSkateValue;
        private System.Windows.Forms.Label lbMiddleSkateValue;
        private System.Windows.Forms.Label lbUpperSkateValue;
        private System.Windows.Forms.Label lbStripper2Value;
        private System.Windows.Forms.Label lbStripper1Value;
        private System.Windows.Forms.Label lbWellheadValue;
        private System.Windows.Forms.Label lbCircValue;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbPortsOut;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbInfo;
    }
}

