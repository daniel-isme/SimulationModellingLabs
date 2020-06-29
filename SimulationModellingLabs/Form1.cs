using System;
using System.Windows.Forms;

namespace SimulationModellingLabs
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public static double factorial(int num)
        {
            var rval = 1;
            for (var i = 2; i <= num; i++)
                rval = rval * i;
            return rval;
        }

        public static Random random = new Random();

        public static int T;
        public static int N;
        public static int MAX;

        public class RandomFlow
        {
            public int rate;
            public double[] events;
            public RandomFlow(int rate)
            {
                this.rate = rate;
                events = new double[MAX];
                for (int i = 0; i < MAX; i++)
                { 
                    events[i] = 0; 
                }
            }

            public void start()
            {
                for (int i = 0; i < N; i++)
                {
                    int n = getNumberOfEvents(rate);
                    try
                    {
                        events[n] += 1;
                    }
                    catch
                    {
                        continue;
                    }
                }

                for (int i = 0; i < MAX; i++)
                {
                    events[i] /= N;
                }
            }

            public int getNumberOfEvents(int rate)
            {
                int i = 0;
                double acc = 0;
                double P = random.NextDouble();
                while (true)
                {
                    double prob = (Math.Pow(rate * T, i) / factorial(i)) * Math.Pow(Math.E, -rate * T);
                    acc += prob;
                    if (P < acc)
                    {
                        return i;
                    }
                    else i++;
                }
            }
        }

        public class DoubleRandomFlow : RandomFlow
        {
            int rate1, rate2;
            public DoubleRandomFlow(int rate1, int rate2) : base(rate1 + rate2) ////
            {
                this.rate1 = rate1;
                this.rate2 = rate2;
                events = new double[MAX];
                for (int i = 0; i < MAX; i++)
                {
                    events[i] = 0;
                }
            }

            public void Start()
            {
                for (int i = 0; i < N; i++)
                {
                    int n1 = getNumberOfEvents(rate1);
                    int n2 = getNumberOfEvents(rate2);
                    try
                    {
                        events[n1 + n2] += 1;
                    }
                    catch
                    {
                        continue;
                    }
                }

                for (int i = 0; i < MAX; i++)
                {
                    events[i] /= N;
                }
            }
        }

        public class RealPuassonFlow : RandomFlow
        {
            public RealPuassonFlow(int rate) : base(rate)
            {
            }

            public void Start() {
                for (int m = 0; m < MAX; m++)
                {
                    double v = getNumberOfEvents(rate, m) % 60;
                    events[m] = v;
                }
            }

            public double getNumberOfEvents(int rate, int i) {
                return Math.Pow(rate * T, i) / factorial(i) * Math.Pow(Math.E, -rate * T);
            }
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                T = int.Parse(tTextBox.Text);
                N = int.Parse(nTextBox.Text);
                MAX = T * 8 * 2;
            }
            catch
            {
                return;
            }

            var r1 = 3;
            var r2 = 5;

            var flow1 = new RandomFlow(r1);
            var flow2 = new RandomFlow(r2);
            var realFlow = new RealPuassonFlow(r1 + r2);
            var doubleFlow = new DoubleRandomFlow(r1, r2);

            flow1.start();
            flow2.start();
            realFlow.Start();
            doubleFlow.Start();

            chart1.Series[0].Points.DataBindY(flow1.events);
            chart2.Series[0].Points.DataBindY(flow2.events);
            chart3.Series[0].Points.DataBindY(doubleFlow.events);
            chart4.Series[0].Points.DataBindY(realFlow.events);
        }
    }
}
