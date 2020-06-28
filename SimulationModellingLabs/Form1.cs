using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencySimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.02;
        double price, euros = 0, rubles = 500;
        int days, speed;
        Random rnd = new Random();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            textRubles.Text = rubles.ToString() + " ₽";
            textEuros.Text = euros.ToString() + " €";
            price = (double)inputPrice.Value;
            days = (int)inputDays.Value;
            speed = (int)inputSpeed.Value;
            timer1.Interval = 2000 / speed;
            chart1.Series[0].Points.AddXY(0, price);
            timer1.Start();
        }

        int currentDay = 0;

        double q = 0.04;
        double ov = 0.2;
        double t = 0.1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentDay++;
            if (currentDay > days)
            {
                chart1.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Maximum - days - 1;
            }
            // броуновское движение
            double a = Math.Exp(t * (q - ov * ov * 0.5));
            double b = ov * Math.Sqrt(t);
            price = price * a * Math.Exp(b * (rnd.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(currentDay, price);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (euros > 0)
            {
                euros -= (double)inputEuros.Value;
                rubles += (double)inputEuros.Value * price;
                textRubles.Text = rubles.ToString() + " ₽";
                textEuros.Text = euros.ToString() + " €";
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if ((double)inputEuros.Value * price <= rubles)
            {
                rubles -= (double)inputEuros.Value * price;
                euros += (double)inputEuros.Value;
                textRubles.Text = rubles.ToString() + " ₽";
                textEuros.Text = euros.ToString() + " €";
            }
        }

        private void inputDays_ValueChanged(object sender, EventArgs e)
        {
            days = (int)inputDays.Value;
        }

        private void inputSpeed_Scroll(object sender, EventArgs e)
        {
            speed = (int)inputSpeed.Value;
            timer1.Interval = 2000 / speed;
        }
    }
}
