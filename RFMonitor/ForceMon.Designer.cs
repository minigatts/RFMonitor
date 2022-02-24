namespace RFMonitor
{
    partial class ForceMon
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewForces = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ForcesPlot = new ScottPlot.FormsPlot();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.forcesPage = new System.Windows.Forms.TabPage();
            this.modelPage = new System.Windows.Forms.TabPage();
            this.ForceMonReadCSVBtn = new System.Windows.Forms.Button();
            this.dataGridViewModel = new System.Windows.Forms.DataGridView();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightRIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightPOOH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxStressRIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxStressPOOH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.forcesPage.SuspendLayout();
            this.modelPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForces
            // 
            this.dataGridViewForces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewForces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForces.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewForces.Name = "dataGridViewForces";
            this.dataGridViewForces.RowHeadersVisible = false;
            this.dataGridViewForces.Size = new System.Drawing.Size(289, 512);
            this.dataGridViewForces.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(405, 278);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(8, 8);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // ForcesPlot
            // 
            this.ForcesPlot.Location = new System.Drawing.Point(-1, 12);
            this.ForcesPlot.Name = "ForcesPlot";
            this.ForcesPlot.Size = new System.Drawing.Size(695, 550);
            this.ForcesPlot.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.forcesPage);
            this.tabControl1.Controls.Add(this.modelPage);
            this.tabControl1.Location = new System.Drawing.Point(690, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 550);
            this.tabControl1.TabIndex = 4;
            // 
            // forcesPage
            // 
            this.forcesPage.Controls.Add(this.dataGridViewForces);
            this.forcesPage.Location = new System.Drawing.Point(4, 22);
            this.forcesPage.Name = "forcesPage";
            this.forcesPage.Padding = new System.Windows.Forms.Padding(3);
            this.forcesPage.Size = new System.Drawing.Size(301, 524);
            this.forcesPage.TabIndex = 0;
            this.forcesPage.Text = "Forces";
            this.forcesPage.UseVisualStyleBackColor = true;
            // 
            // modelPage
            // 
            this.modelPage.Controls.Add(this.ForceMonReadCSVBtn);
            this.modelPage.Controls.Add(this.dataGridViewModel);
            this.modelPage.Location = new System.Drawing.Point(4, 22);
            this.modelPage.Name = "modelPage";
            this.modelPage.Padding = new System.Windows.Forms.Padding(3);
            this.modelPage.Size = new System.Drawing.Size(301, 524);
            this.modelPage.TabIndex = 1;
            this.modelPage.Text = "Model";
            this.modelPage.UseVisualStyleBackColor = true;
            // 
            // ForceMonReadCSVBtn
            // 
            this.ForceMonReadCSVBtn.Location = new System.Drawing.Point(104, 495);
            this.ForceMonReadCSVBtn.Name = "ForceMonReadCSVBtn";
            this.ForceMonReadCSVBtn.Size = new System.Drawing.Size(75, 23);
            this.ForceMonReadCSVBtn.TabIndex = 1;
            this.ForceMonReadCSVBtn.Text = "Import CSV";
            this.ForceMonReadCSVBtn.UseVisualStyleBackColor = true;
            this.ForceMonReadCSVBtn.Click += new System.EventHandler(this.ForceMonReadCSVBtn_click);
            // 
            // dataGridViewModel
            // 
            this.dataGridViewModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Depth,
            this.WeightRIH,
            this.WeightPOOH,
            this.MaxStressRIH,
            this.MaxStressPOOH});
            this.dataGridViewModel.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewModel.Name = "dataGridViewModel";
            this.dataGridViewModel.Size = new System.Drawing.Size(289, 483);
            this.dataGridViewModel.TabIndex = 0;
            // 
            // Depth
            // 
            this.Depth.HeaderText = "Depth";
            this.Depth.Name = "Depth";
            // 
            // WeightRIH
            // 
            this.WeightRIH.HeaderText = "Surface Weight RIH (lbf)";
            this.WeightRIH.Name = "WeightRIH";
            // 
            // WeightPOOH
            // 
            this.WeightPOOH.HeaderText = "Surface Weight POOH (lbf)";
            this.WeightPOOH.Name = "WeightPOOH";
            // 
            // MaxStressRIH
            // 
            this.MaxStressRIH.HeaderText = "Maximum Stress RIH (kpsi)";
            this.MaxStressRIH.Name = "MaxStressRIH";
            // 
            // MaxStressPOOH
            // 
            this.MaxStressPOOH.HeaderText = "Maximum Stress POOH (kpsi)";
            this.MaxStressPOOH.Name = "MaxStressPOOH";
            // 
            // ForceMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 583);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ForcesPlot);
            this.Controls.Add(this.chart1);
            this.Name = "ForceMon";
            this.Text = "ForceMon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.forcesPage.ResumeLayout(false);
            this.modelPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewForces;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ScottPlot.FormsPlot ForcesPlot;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage forcesPage;
        private System.Windows.Forms.TabPage modelPage;
        private System.Windows.Forms.DataGridView dataGridViewModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightRIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightPOOH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxStressRIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxStressPOOH;
        private System.Windows.Forms.Button ForceMonReadCSVBtn;
    }
}