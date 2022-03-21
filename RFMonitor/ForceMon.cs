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
using System.IO;

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
        Timer AutoSave = new Timer();

        public ForceMon()
        {
            InitializeComponent();

            // Load forces data if it exists.
            if (File.Exists("forcesdata.csv"))
            {
                try
                {
                    Variables.ForcesData.dt.ReadFromCsvFile("forcesdata.csv");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Could not read from forcesdata.csv");
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                try
                {
                    Variables.ForcesData.dt.Columns.Add("Depth");
                    Variables.ForcesData.dt.Columns.Add("Weight");
                }
                catch
                {
                    Debug.WriteLine("Column already exists in table.");
                }
            }

            bs.DataSource = Variables.ForcesData.dt;

            dataGridViewForces.DataSource = bs;

            ScatterPlot = ForcesPlot.Plot.AddScatter(weightsArray, depthsArray, lineWidth: 0, label: "Forces");            
            ForcesPlot.Plot.Title("Surface Wieght vs. Depth");
            ForcesPlot.Plot.XAxis.Label("Weight");
            ForcesPlot.Plot.YAxis.Label("Depth");

            AutoSave.Interval = 60000;
            AutoSave.Tick += new EventHandler(timer_Tick);
            AutoSave.Start();

            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }

        void autosave_Tick(object sender, EventArgs e)
        {
            try 
            { 
                Variables.ForcesData.dt.WriteToCsvFile("forcesdata.csv");
                Debug.WriteLine("Forces data backed up to csv.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Could not save forces data to csv.");
                Debug.WriteLine(ex);
            }

        }

        void timer_Tick(object sender, EventArgs e)
        {
            dataGridViewForces.Refresh();

            int numrows = Variables.ForcesData.dt.Rows.Count;

            try 
            {
                double[] tempDepth = new double[numrows];                
                double[] tempWeight = new double[numrows];                
                                
                for (int a = 0; a < numrows; a++)
                {
                    depthsArray[a] = -float.Parse(Variables.ForcesData.dt.Rows[a]["Depth"].ToString());
                    weightsArray[a] = float.Parse(Variables.ForcesData.dt.Rows[a]["Weight"].ToString());      
                }               

                if(numrows > (NextPointIndex + 1))
                {
                    Debug.WriteLine("Updated render index from " + NextPointIndex + " to " + numrows);
                    NextPointIndex = numrows;                    
                }
                
                ScatterPlot.MaxRenderIndex = NextPointIndex;                
                NextPointIndex += 5;
                           
                ForcesPlot.Render();

            }
            catch
            {
                Debug.WriteLine("Could not copy data to chart DataTable.");
            }

            try
            {
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Could not save datatable to CSV.");
                Debug.WriteLine(ex);
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
