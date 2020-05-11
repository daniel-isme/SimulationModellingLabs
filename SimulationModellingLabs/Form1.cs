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
        private class Cell
        {
            public int num;
            public bool selected;
            public Button button;
        }

        List<Button> buttons;
        List<TextBox> probTextBoxes;
        List<Bitmap> diceEdges = new List<Bitmap>();
        double[] eventsProb;

        Random rnd = new Random();
        int m = 6;

        int requiredSum = 0;
        int currentSum = 0;
        bool diceRolled = false;

        List<Cell> cells = new List<Cell>();

        public Form1()
        {
            InitializeComponent();

            buttons = this.Controls.OfType<Button>()
                          .Where(c => c.Name.StartsWith("button"))
                          .ToList();

            probTextBoxes = this.Controls.OfType<TextBox>()
                          .Where(c => c.Name.StartsWith("prob"))
                          .ToList();

            diceEdges.Add(Properties.Resources.dice_1);
            diceEdges.Add(Properties.Resources.dice_2);
            diceEdges.Add(Properties.Resources.dice_3);
            diceEdges.Add(Properties.Resources.dice_4);
            diceEdges.Add(Properties.Resources.dice_5);
            diceEdges.Add(Properties.Resources.dice_6);

            eventsProb = new double[m];

            applyProbs();

            for (int i = 1; i < 10; i++)
            {
                cells.Add(new Cell
                {
                    num = i,
                    selected = false,
                    button = buttons[8 - (i - 1)]
                });
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            applyProbs();
        }

        private void applyProbs()
        {
            errorLabel.Text = "";
            try
            {
                eventsProb[0] = double.Parse(probTextBox1.Text);
                eventsProb[1] = double.Parse(probTextBox2.Text);
                eventsProb[2] = double.Parse(probTextBox3.Text);
                eventsProb[3] = double.Parse(probTextBox4.Text);
                eventsProb[4] = double.Parse(probTextBox5.Text);
            }
            catch
            {
                errorLabel.Text = "Error: Enter valid numbers";
                return;
            }

            var sum = eventsProb.Take(m - 1).Sum();
            if (sum < 1)
            {
                eventsProb[m - 1] = 1 - sum;
            }
            else
            {
                errorLabel.Text = "Error: Sum of probs > 1";
                return;
            }
        }

        private int generateEvent(double alpha)
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox prob in probTextBoxes)
            {
                prob.Text = "";
            }
        }

        private void shutTheBox(int num)
        {
            if (diceRolled)
            {
                Cell cell = cells.First(c => c.num == num);

                if (cell.button.Enabled)
                {
                    if (!cell.selected)
                    {
                        if (cell.num + currentSum <= requiredSum)
                        {
                            currentSum += cell.num;
                            cell.selected = true;
                            cell.button.BackColor = Color.DimGray;
                        }
                    }
                    else
                    {
                        currentSum -= cell.num;
                        cell.selected = false;
                        cell.button.BackColor = Color.SaddleBrown;
                    }
                }
                else
                {
                    return;
                }

                if (currentSum == requiredSum)
                {
                    List<Cell> cellsSelected = cells.Where(c => c.selected == true)
                                                    .ToList();
                    foreach (Cell c in cellsSelected)
                    {
                        c.button.Text = "";
                        c.button.Enabled = false;
                    }
                    currentSum = 0;
                    diceRolled = false;
                    rollDice();
                }
            }
        }

        private void dicePictureBox1_Click(object sender, EventArgs e)
        {
            rollDice();
        }

        private void dicePictureBox2_Click(object sender, EventArgs e)
        {
            rollDice();
        }

        private void rollDice()
        {
            if (!diceRolled)
            {
                int firstNum = generateEvent(rnd.NextDouble());
                int secondNum = generateEvent(rnd.NextDouble());
                requiredSum = firstNum + secondNum + 2;
                dicePictureBox1.Image = diceEdges[firstNum];
                dicePictureBox2.Image = diceEdges[secondNum];
                diceRolled = true;
                checkIfPossibleToWin();
            }
        }

        private void checkIfPossibleToWin()
        {
            List<Cell> cellsRemaining = cells.Where(c => c.button.Enabled == true)
                                             .ToList();

            List<int> mas = cellsRemaining.Select(c => c.num)
                                          .ToList();
            
            if (cellsRemaining.Count <= 0)
            {
                win();
                return;
            }

            if (sumExists(mas, 0, 0))
            {
                return;
            }
            else
            {
                int score = cellsRemaining.Sum(c => c.num);
                gameOver(score);
            }
        }

        bool sumExists(List<int> mas, int num, int s)
        {
            if (num == mas.Count())
            {
                if (s == requiredSum)
                {
                    return true;
                }
                return false;
            }

            if (sumExists(mas, num + 1, s))
            {
                return true;
            }

            s += mas[num]; 

            if (sumExists(mas, num + 1, s))
            {
                return true;
            }
            return false;
        }

        private void gameOver(int score)
        {
            gameStatusLabel.Text = $"GAME OVER! \nScore: {score}";
            gameStatusLabel.ForeColor = Color.Red;
        }

        private void win()
        {
            gameStatusLabel.Text = "YOU WIN!";
            gameStatusLabel.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shutTheBox(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shutTheBox(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shutTheBox(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shutTheBox(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            shutTheBox(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shutTheBox(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            shutTheBox(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            shutTheBox(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            shutTheBox(9);
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void defaultPropsButton_Click(object sender, EventArgs e)
        {
            probTextBox1.Text = "0.166666";
            probTextBox2.Text = "0.166666";
            probTextBox3.Text = "0.166666";
            probTextBox4.Text = "0.166666";
            probTextBox5.Text = "0.166666";
            applyProbs();
        }

        private void rollAnywayButton_Click(object sender, EventArgs e)
        {
            diceRolled = false;
            rollDice();
        }
    }
}
