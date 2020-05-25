using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationModellingLabs
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();

        double L = 0;
        int N = 0; // общее число экспериментов
        int range = 0;
        List<double> results;
        List<double> puassonResults;

        double Ex; // матожидание
        double Dx; // дисперсия
        double Ex_empirical; // эмпирическое матожидание
        double Dx_empirical; // эмпирическае дисперсия
        double chiSquared; // критерий хи-квадрат Пирсона

        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            cleanUpParameters();

            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            errorLabel.Text = "";
            try
            {
                L = GetDouble(intensity_textBox.Text);
                range = (int)GetDouble(range_textBox.Text);
                N = (int)GetDouble(numOfExperimentsTextBox.Text);
            }
            catch
            {
                errorLabel.Text = "Error: Enter valid numbers";
                return;
            }

            generateEvents();
            simulatePuasson();

            for (int i = 0; i < puassonResults.Count; i++)
            {
                Ex += i * puassonResults[i];
            }

            for (int i = 0; i < puassonResults.Count; i++)
            {
                Dx += puassonResults[i] * (i - Ex) * (i - Ex);
            }

            for (int i = 0; i < results.Count; i++)
            {
                Ex_empirical += i * results[i];
            }

            for (int i = 0; i < results.Count; i++)
            {
                Dx_empirical += results[i] * (i - Ex_empirical) * (i - Ex_empirical);
            }

            for (int i = 0; i < results.Count; i++)
            {
                chiSquared += (results[i] * results[i] * N * N) / (N * puassonResults[i]);
            }
            chiSquared -= N;

            for (int i = 0; i < results.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, results[i]);
                chart1.Series["Series2"].Points.AddXY(i, puassonResults[i]);
            }


            var deltaE = Math.Abs(Ex_empirical - Ex);
            var deltaD = Math.Abs(Dx_empirical - Dx);
            var deltaE_percents = deltaE / Math.Abs(Ex);
            var deltaD_percents = deltaD / Math.Abs(Dx);

            averageLabel.Text = $"Average: {Math.Round(Ex_empirical, 3)} (error = {(int)(deltaE_percents * 100)}%)";
            varianceLabel.Text = $"Variance: {Math.Round(Dx_empirical, 3)} (error = {(int)(deltaD_percents * 100)}%)";
            chiSquaredLabel.Text = $"Chi-squared: {Math.Round(chiSquared, 3)} > {11.07}    is ";
            chiSquaredLogicLabel.Text = $"{Math.Round(chiSquared, 3) > 11.07}";
            if (Math.Round(chiSquared, 3) > 11.07)
            {
                chiSquaredLogicLabel.ForeColor = Color.Green;
            }
            else
            {
                chiSquaredLogicLabel.ForeColor = Color.Red;
            }
        }

        private void simulatePuasson()
        {
            for (int m = 0; m < range; m++)
            {
                var v = (Math.Pow(L, m) / (double)Factorial(m)) * Math.Pow(Math.E, -L);
                puassonResults.Add(v);
            }
        }

        public int Factorial(int f)
        {
            if (f == 0)
                return 1;
            else
                return f * Factorial(f - 1);
        }

        private void generateEvents()
        {
            for (int i = 0; i < range; i++)
            {
                results.Add(0);
            }

            for (int i = 0; i < N; i++)
            {
                double s = 0;
                int m = -1;

                while (s > -L)
                {
                    m++;
                    s += Math.Log(rnd.NextDouble());
                }
                try
                {
                    results[m]++;
                }
                catch
                {
                    Console.WriteLine("Out of range");
                    continue;
                }
            }

            for (int i = 0; i < results.Count; i++)
            {
                results[i] /= N;
            }
        }

        private void cleanUpParameters()
        {
            L = 0;
            N = 0;
            range = 0;
            results = new List<double>();
            puassonResults = new List<double>();

            Ex = 0;
            Dx = 0;
            chiSquared = 0;
            Ex_empirical = 0;
            Dx_empirical = 0;
        }

        public static double GetDouble(string value)
        {
            double result;

            //Try parsing in the current culture
            if (!double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                //Then try in US english
                !double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                //Then in neutral language
                !double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                throw new Exception("Failed to parse from string");
            }

            return result;
        }

    }
}
