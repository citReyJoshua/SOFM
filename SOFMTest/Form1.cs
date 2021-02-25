using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SOFM;
using System.Diagnostics;

namespace SOFMTest
{
    public partial class Form1 : Form
    {
        private SOFM.NeuralNetwork nn;
        private readonly Stopwatch sw;
        private float[,] centroids;

        public Form1()
        {
            InitializeComponent();
            sw = new Stopwatch();
            showLegend();
        }

        private void computeCentroids()
        {
            for (int x = 0; x < nn.UsedColors.Count; x++)
            {
                Color temp = nn.UsedColors[x];
                float xValues = 0;
                float yValues = 0;
                int totalPoints = 0;
                for (int i = 0; i < nn.OutputLayerDimension; i++)
                {
                    for(int j = 0; j < nn.OutputLayerDimension; j++)
                    {
                        if (sofmVisualizer.Matrix[i,j] == temp)
                        {
                            xValues += i;
                            yValues += j;
                            totalPoints++;
                        }
                    }
                }
                centroids[x, 0] = xValues / totalPoints;
                centroids[x, 1] = yValues / totalPoints;

            }
        }

        private string findNearestDistance(int x, int y)
        {
            double distance = 999999;
            int centroid_index = 0;
            for (int i = 0; i < nn.UsedColors.Count; i++)
            {
                double tempDistance = Math.Sqrt((double)(Math.Pow(centroids[i, 0] - x, 2) + Math.Pow(centroids[i, 1] - y, 2)));
                if (tempDistance < distance)
                {
                    distance = tempDistance;
                    centroid_index = i;
                }
            }

            return nn.ExistentClasses.Keys[centroid_index];
        }
        private void nn_EndIterationEvent(object sender, EventArgs e)
        {
            lblTime.Text = "Time Elapsed: " + sw.Elapsed.Seconds.ToString() + " seconds";
        }

        private void btnLoadDataAndCreateNetwork_Click(object sender, EventArgs e)
        {
            nn = new NeuralNetwork(25, 500, 0.00000001, f: Functions.MexicanHat);
            nn.EndEpochEvent += new EndEpochEventHandler(nn_EndEpochEvent);
            nn.EndIterationEvent += new EndIterationEventHandler(nn_EndIterationEvent);
            nn.Normalize = true;
            
            
            OpenFileDialog ofd = new OpenFileDialog();
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                nn.ReadDataFromFile(ofd.FileName);
                sofmVisualizer.Matrix = null;
                sw.Restart();
                nn.StartLearning();
                sofmVisualizer.Matrix = nn.ColorSOFM();
                centroids = new float[nn.UsedColors.Count, 2];
                computeCentroids();
                sofmVisualizer.Invalidate();
                sw.Stop();
                AddLegend();
            }
        }

        private void showLegend()
        {
            panelLegend.Controls.Clear();
            Label label = new Label
            {
                Name = "lblLegend",
                Top = 5,
                Left = 5,
                Text = "Groups",
                AutoSize = true
            };
            this.panelLegend.Controls.Add(label);
            panelLegend.Visible = true;
        }

        private void AddLegend()
        {
            this.panelLegend.Controls.Clear();
            for (int i = 0; i < nn.ExistentClasses.Count; i++)
            {
                Label lbl = new Label
                {
                    Name = "lbl" + nn.ExistentClasses.Keys[i],
                    Text = " - " + nn.ExistentClasses.Keys[i],
                    Top = 20 * (i + 1),
                    AutoSize = true
                };
                lbl.Left = 15 + (int)lbl.Font.Size;
                this.panelLegend.Controls.Add(lbl);

                Panel panel = new Panel
                {
                    Name = "panel" + nn.ExistentClasses.Keys[i],
                    Top = 20 * (i + 1) + (int)lbl.Font.Size / 2,
                    Left = 15,
                    Width = (int)lbl.Font.Size,
                    Height = (int)lbl.Font.Size,
                    BackColor = nn.UsedColors[i]
                };
                this.panelLegend.Controls.Add(panel);
            }
        }

        private void chbVisualization_CheckedChanged(object sender, EventArgs e)
        {
            this.nn_EndEpochEvent(this, new EndEpochEventArgs());
        }

        private void nn_EndEpochEvent(object sender, EndEpochEventArgs e)
        {
            Application.DoEvents();
        }

        private void btnLoadWeight_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string[] line = sr.ReadLine().Split(' ');
                List<double> values = new List<double>();
                for (int i = 0; i < line.Length - 1; i++)
                {
                    values.Add(Double.Parse(line[i]));
                }
                Neuron Winner = nn.FindWinner(values);
                sofmVisualizer.LightUpThePixel(Winner.Coordinate.X, Winner.Coordinate.Y);
                lblResult.Text = "Most likely a/an " + findNearestDistance(Winner.Coordinate.X, Winner.Coordinate.Y);
                ofd.Dispose();
            }
        }

        
    }
}