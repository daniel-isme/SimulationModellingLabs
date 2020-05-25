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
            public int Points;
        }

        Random rnd = new Random();
        double l = 2.7;

        public Form1()
        {
            InitializeComponent();
            teams_richTextBox.Select();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            List<Team> teams = new List<Team>();

            string[] teamNames = teams_richTextBox.Text.Split(',');
            foreach (string teamName in teamNames)
            {
                if (teamName.Trim() == "") continue;
                teams.Add(new Team
                {
                    Name = teamName.Trim(),
                    Win = 0,
                    Lose = 0,
                    Draw = 0,
                    Points = 0
                });
            }

            for (int i = 0; i < teams.Count - 1; i++)
            {
                for (int j = i + 1; j < teams.Count; j++)
                {
                    double a1;
                    double a2;
                    int m1 = 0;
                    int m2 = 0;
                    double s1 = 0;
                    double s2 = 0;

                    while (s1 >= -l)
                    {
                        m1++;
                        a1 = rnd.NextDouble();
                        s1 += Math.Log(a1);
                    }
                    while (s2 >= -l)
                    {
                        m2++;
                        a2 = rnd.NextDouble();
                        s2 += Math.Log(a2);
                    }

                    if (m1 > m2)
                    {
                        teams[i].Win++;
                        teams[i].Points += 3;
                        teams[j].Lose++;
                    }
                    else if (m1 == m2)
                    {
                        teams[i].Draw++;
                        teams[j].Draw++;
                        teams[i].Points += 1;
                        teams[j].Points += 1;
                    }
                    else
                    {
                        teams[j].Win++;
                        teams[j].Points += 3;
                        teams[i].Lose++;
                    }
                }
            }

            teams = teams.OrderByDescending(t => t.Points).ToList();

            display_richTextBox.Clear();
            display_richTextBox.Text += "Team name - Points / Wins / Draws / Loses\n\n";

            foreach (Team team in teams)
            {
                display_richTextBox.Text += $"{team.Name} - {team.Points} / {team.Win} / {team.Draw} / {team.Lose}\n";
            }
        }
    }
}
