using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

        double[] finalProbs = new double[] { 56.0 / 240.0, 124.0 / 240.0, 60.0 / 240.0 };
        int weatherState = 0;
        double N = 0;

        int time = 0;
        int changeTime = 2;
        bool paused = true;
        double[,] matrix = new double[,] { 
            { -0.4,  0.3,  0.1 },
            { 0.4, -0.8,  0.4 },
            { 0.1,  0.4, -0.5 } 
        };

        //0 - clear, 1 - cloudy, 2 - rain
        double[] weatherProbabilities = new double[] { 0, 0, 0 };

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!paused) return;

            paused = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!paused)
            {
                updateTime();

                if (time > changeTime)
                {
                    increaseChangeTime();
                    updateState();
                    updatePicture();
                    updateProbs();
                    updateChart();
                }
            }
        }

        private void updateChart()
        {
            chart1.Series["Probability"].Points.Clear();
            chart1.Series["Final"].Points.Clear();

            for (int i = 0; i < weatherProbabilities.Count(); i++)
            {
                chart1.Series["Probability"].Points.AddXY(i + 1, weatherProbabilities[i] / N);
                chart1.Series["Final"].Points.AddXY(i + 1, finalProbs[i]);
            }
        }

        private void updateProbs()
        {
            weatherProbabilities[weatherState]++;
            N++;
        }

        private void updatePicture()
        {
            switch (weatherState)
            {
                case 0:
                    weatherPictureBox.Image = Properties.Resources.clear;
                    break;
                case 1:
                    weatherPictureBox.Image = Properties.Resources.cloudy;
                    break;
                case 2:
                    weatherPictureBox.Image = Properties.Resources.rain;
                    break;
            }
        }

        private void updateState()
        {
            var r = rnd.NextDouble();
            double acc = 0;

            for (int i = 0; i < 3; i++)
            {
                if (i != weatherState)
                {
                    var v = -matrix[weatherState, i] / matrix[weatherState, weatherState];
                    acc += v;
                    if (acc > r)
                    {
                        weatherState = i;
                        break;
                    }
                }
            }
        }

        private void increaseChangeTime()
        {
            var t = Math.Log(rnd.NextDouble()) / matrix[weatherState, weatherState];
            changeTime += (int)Math.Ceiling(t);
        }

        private void updateTime()
        {
            time++;
            timeLabel.Text = $"{time % 24}:00";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            paused = true;
        }
    }
}
