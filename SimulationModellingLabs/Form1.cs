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
        class Team
        {
            public string Name;
            public int Win;
            public int Lose;
            public int Draw;
        }

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

    }
}
