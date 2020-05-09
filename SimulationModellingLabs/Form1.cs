using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationModellingLabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int m = 5;

        private void generateButton_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            errorLabel.Text = "";
            double[] eventsProb = new double[m];
            int numOfExperiments = 0;
            try
            {
                eventsProb[0] = double.Parse(prob1TextBox.Text);
                eventsProb[1] = double.Parse(prob2TextBox.Text);
                eventsProb[2] = double.Parse(prob3TextBox.Text);
                eventsProb[3] = double.Parse(prob4TextBox.Text);
                numOfExperiments = int.Parse(numOfExperimentsTextBox.Text);
            }
            catch
            {
                errorLabel.Text = "Error: Enter valid numbers";
                return;
            }

            var sum = eventsProb.Take(4).Sum();

            if (sum < 1)
            {
                eventsProb[4] = 1 - sum;
            }
            else
            {
                errorLabel.Text = "Error: Sum of probs > 1";
                return;
            }

            int[] statistics = new int[m];

            for (int i = 0; i < numOfExperiments; i++)
            {
                statistics[generateEvent(rnd.NextDouble(), eventsProb)]++;
            }

            double[] frequency = new double[m];
            for (int i = 0; i < m; i++)
            {
                frequency[i] = statistics[i] / (double)numOfExperiments;
                chart1.Series["Series1"].Points.AddY(frequency[i]);
            }
        }

        private int generateEvent(double alpha, double[] eventsProb)
        {
            int k = 0;
            double A = alpha;

            A -= eventsProb[k];
            while (A > 0 && k < m)
            {
                k++;
                A -= eventsProb[k];
            }

            return k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prob1TextBox.Text = "";
            prob2TextBox.Text = "";
            prob3TextBox.Text = "";
            prob4TextBox.Text = "";
            numOfExperimentsTextBox.Text = "";
        }
    }
}
