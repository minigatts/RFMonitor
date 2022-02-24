using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RFMonitor
{
    public partial class ForceMon : Form
    {
        private BindingSource bs = new BindingSource();
        public ForceMon form;
        readonly double[] weightsArray = new double[400000];
        readonly double[] depthsArray = new double[400000];
        readonly double[] modelDepthArray = new double[1000];
        readonly double[] RIHArray = new double[1000];
        readonly double[] POOHArray = new double[1000];
        readonly ScottPlot.Plottable.ScatterPlot ScatterPlot;
        int NextPointIndex = 0;

        Timer timer = new Timer();

        public ForceMon()
        {
            InitializeComponent();

            try
            {
                Variables.ForcesData.dt.Columns.Add("Depth");
                Variables.ForcesData.dt.Columns.Add("Weight");
            }
            catch
            {
                Debug.WriteLine("Column already exists in table.");
            }


            bs.DataSource = Variables.ForcesData.dt;

            dataGridViewForces.DataSource = bs;

            ScatterPlot = ForcesPlot.Plot.AddScatter(weightsArray, depthsArray, lineWidth: 0, label: "Forces");            
            ForcesPlot.Plot.Title("Surface Wieght vs. Depth");
            ForcesPlot.Plot.XAxis.Label("Weight");
            ForcesPlot.Plot.YAxis.Label("Depth");

            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            dataGridViewForces.Refresh();            

            try 
            {
                double[] tempDepth = new double[Variables.ForcesData.dt.Rows.Count];
                double[] tempWeight = new double[Variables.ForcesData.dt.Rows.Count];                
                

                // Classic version :-)
                for (int a = 0; a < Variables.ForcesData.dt.Rows.Count; a++)
                {
                    depthsArray[a] = -float.Parse(Variables.ForcesData.dt.Rows[a]["Depth"].ToString());
                    weightsArray[a] = float.Parse(Variables.ForcesData.dt.Rows[a]["Weight"].ToString());      
                }               

                ScatterPlot.MaxRenderIndex = NextPointIndex;
                NextPointIndex += 5;
                           
                ForcesPlot.Render();

            }
            catch
            {
                Debug.WriteLine("Could not copy data to chart DataTable.");
            }
        }

        private void ForceMonReadCSVBtn_click(object sender, EventArgs e)
        {
            Variables.ReadCSV();

            Variables.ModelData.dt = Variables.CSVTemp.dt.Copy();
            Variables.CSVTemp.dt.Clear();

            dataGridViewModel.CancelEdit();
            dataGridViewModel.Columns.Clear();
            dataGridViewModel.DataSource = null;
            dataGridViewModel.DataSource = Variables.ModelData.dt;
            dataGridViewModel.Refresh();

            for (int a = 1; a < Variables.ModelData.dt.Rows.Count; a++)
            {
                modelDepthArray[a] = -float.Parse(Variables.ModelData.dt.Rows[a][0].ToString());
                RIHArray[a] = float.Parse(Variables.ModelData.dt.Rows[a][1].ToString());
                POOHArray[a] = float.Parse(Variables.ModelData.dt.Rows[a][2].ToString());
            }

            ForcesPlot.Plot.AddScatter(RIHArray, modelDepthArray, lineWidth: 0, label: "RIH Model");
            ForcesPlot.Plot.AddScatter(POOHArray, modelDepthArray, lineWidth: 0, label: "POOH Model");

        }
    }
}
