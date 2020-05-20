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
        class Event
        {
            public int x; // значения xi
            public int n; // число выпадений значения xi
            public double p; // вероятности значений xi
            public double p_empirical; // pi называются относительными частотами(или эмпирическими вероятностями) значений xi
        }

        Random rnd = new Random();

        int m = 5; 
        int N = 0; // общее число экспериментов

        double Ex; // матожидание
        double Ex2; // матожидание квадрата
        double Dx; // дисперсия
        double Ex_empirical; // эмпирическое матожидание
        double Ex2_empirical; // эмпирическое матожидание квадрата
        double Dx_empirical; // эмпирическае дисперсия
        double chiSquared; // критерий хи-квадрат Пирсона

        List<Event> events;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            events = new List<Event>();

            for (int i = 1; i <= m; i++)
            {
                events.Add(new Event
                {
                    x = i
                });
            }

            chart1.Series["Series1"].Points.Clear();
            errorLabel.Text = "";
            try
            {
                events.First(ev => ev.x == 1).p = GetDouble(prob1TextBox.Text, 0.16666);
                events.First(ev => ev.x == 2).p = GetDouble(prob2TextBox.Text, 0.16666);
                events.First(ev => ev.x == 3).p = GetDouble(prob3TextBox.Text, 0.16666);
                events.First(ev => ev.x == 4).p = GetDouble(prob4TextBox.Text, 0.16666);
                N = int.Parse(numOfExperimentsTextBox.Text);
            }
            catch
            {
                errorLabel.Text = "Error: Enter valid numbers";
                return;
            }

            double sum = 0;
            for (int i = 1; i <= 4; i++)
            {
                sum += events.First(ev => ev.x == i).p;
            }

            if (sum < 1)
            {
                events.First(ev => ev.x == 5).p = 1 - sum;
            }
            else
            {
                errorLabel.Text = "Error: Sum of probs > 1";
                return;
            }

            for (int i = 0; i < N; i++)
            {
                var eventNum = generateEvent(rnd.NextDouble(), events.Select(ev => ev.p).ToArray());
                events.First(ev => ev.x == eventNum).n++;
            }

            Ex = 0;
            Ex2 = 0;
            Dx = 0;
            Ex_empirical = 0;
            Ex2_empirical = 0;
            Dx_empirical = 0;
            chiSquared = 0;

            foreach (Event ev in events)
            {
                ev.p_empirical = ev.n / (double)N;
                chart1.Series["Series1"].Points.AddY(Math.Round(ev.p_empirical, 4));

                Ex += ev.p * ev.x;
                Ex2 += ev.p * Math.Pow(ev.x, 2);
                Ex_empirical += ev.p_empirical * ev.x;
                Ex2_empirical += ev.p_empirical * Math.Pow(ev.x, 2);
                chiSquared += Math.Pow(ev.n, 2) / (N * ev.p); //Math.Pow(ev.n - N * ev.p, 2) / (N * ev.p);
            }

            chiSquared -= N;

            Dx = Ex2 - Math.Pow(Ex, 2);
            Dx_empirical = Ex2_empirical - Math.Pow(Ex_empirical, 2);

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

        public static double GetDouble(string value, double defaultValue)
        {
            double result;

            //Try parsing in the current culture
            if (!double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                //Then try in US english
                !double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                //Then in neutral language
                !double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                result = defaultValue;
                throw new Exception("Failed to parse from string");
            }

            return result;
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

            return k+1;
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
