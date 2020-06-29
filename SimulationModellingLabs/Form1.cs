using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimulationModellingLabs
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            labels.Add(agent0Label);
            labels.Add(agent1Label);
            labels.Add(agent2Label);
            labels.Add(agent3Label);
            labels.Add(agent4Label);

            var p = new ProducerAgent(0);
            p.workTime = Math.Ceiling(getExponentialRandomVariable(PRODUCTION_DELAY));

            for (int i = 1; i <= CONSUMERS_NUM; i++)
            {
                var c = new ConsumerAgent(i);
                agents.Add(c);
            }

            consumersNumLabel.Text = $"Consumers: {CONSUMERS_NUM}";

        }

        List<Label> labels = new List<Label>();

        public static Random random = new Random();

        public static double ERV_COEF = 30;
        public static double T = 0;
        public static int CONSUMERS_NUM = (int)Math.Ceiling(random.NextDouble() * 5) + 1;
        public static double WORK_DELAY = 1;
        public static double PRODUCTION_DELAY = WORK_DELAY * (CONSUMERS_NUM - 1.9);

        public static int queue = 0;
        public static List<ConsumerAgent> agents = new List<ConsumerAgent>();

        public static double getExponentialRandomVariable(double lambda)
        {
            double res = lambda * Math.Pow(Math.E, -lambda * random.NextDouble());
            return res * ERV_COEF;
        }

        public class Agent
        {
            public Agent(int idd)
            {
                id = idd;
                workTime = 0;
                hasWork = true;
            }

            public double getNextEvent()
            {
                throw new Exception("Must be implemented");
            }

            public void processEvent()
            {
                throw new Exception("Must be implemented");
            }

            public string getStatus()
            {
                return "Not implemented";
            }

            public int id;
            public double workTime;
            public bool hasWork;
        }

        public class ProducerAgent : Agent
        {
            public ProducerAgent(int id) : base(id) { }

            public double getNextEvent()
            {
                return workTime;
            }

            public void processEvent()
            {
                workTime = Math.Ceiling(getExponentialRandomVariable(PRODUCTION_DELAY));

                foreach (var a in agents)
                {
                    if (!a.hasWork)
                    {
                        a.hasWork = true;
                        a.workTime = Math.Ceiling(getExponentialRandomVariable(WORK_DELAY));
                        return;
                    }
                }
                queue++;
            }

            public string getStatus()
            {
                if (workTime == 0) return $"Agent {id}: client came";
                return $"Agent {id}: next client arrives in {workTime} minutes";
            }
        }

        public class ConsumerAgent : Agent
        {
            public ConsumerAgent(int id) : base(id) 
            {
                this.hasWork = false;
            }

            public double getNextEvent()
            {
                if (hasWork) return workTime;
                return 0; ////
            }


            public void processEvent()
            {
                hasWork = false;
                if (queue > 0)
                {
                    this.workTime = Math.Ceiling(getExponentialRandomVariable(WORK_DELAY));
                    this.hasWork = true;
                    queue--;

                }
            }

            public string getStatus()
            {
                if (hasWork) return $"Working for {workTime} minutes";
                else return $"Relax";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = "Time: " + T.ToString();
            inQueueLabel.Text = "In queue: " + queue.ToString();

            var minT = double.MaxValue;

            for (int i = 0; i < agents.Count; i++)
            {
                try
                {
                    labels[i].Text = agents[i].getStatus();
                    if (agents[i].hasWork)
                    {
                        if (agents[i].workTime == 0)
                        {
                            agents[i].processEvent();
                        }
                        if (agents[i].getNextEvent() < minT)
                        {
                            minT = agents[i].workTime;
                        }
                    }
                }
                catch
                {

                }
            }

            eventTimeLabel.Text = $"Next event in: {minT}";

            foreach (var a in agents)
            {
                if (a.hasWork)
                {
                    a.workTime -= minT;
                }
            }

            T += minT;
        }
    }
}
