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

        int N = 0; // общее число экспериментов
        int range = 0;
        double Ex; // матожидание
        double Dx; // дисперсия
        List<double> X;
        List<double> Y;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            cleanUpParameters();

            chart1.Series["Series1"].Points.Clear();
            errorLabel.Text = "";
            try
            {
                range = (int)GetDouble(range_textBox.Text);
                N = (int)GetDouble(numOfExperimentsTextBox.Text);
                Ex = GetDouble(Ex_textBox.Text);
                Dx = GetDouble(Dx_textBox.Text);
            }
            catch
            {
                errorLabel.Text = "Error: Enter valid numbers";
                return;
            }

            generateEvents();

            for (int i = 0; i < X.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(X[i], Y[i]);
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
            for (int i = 0; i < N; i++)
            {
                var rand = (rnd.NextDouble() - 0.5) * range;
                var e = (1 / (Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, (-rand * rand) / 2);
                e = Ex + Dx * e;
                Y.Add(e);
                X.Add(rand);
            }
        }

        private void cleanUpParameters()
        {
            N = 0;
            range = 0;
            Ex = 0;
            Dx = 0;
            X = new List<double>();
            Y = new List<double>();
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
