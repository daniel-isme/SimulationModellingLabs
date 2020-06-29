namespace SimulationModellingLabs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.inQueueLabel = new System.Windows.Forms.Label();
            this.consumersNumLabel = new System.Windows.Forms.Label();
            this.agent0Label = new System.Windows.Forms.Label();
            this.agent1Label = new System.Windows.Forms.Label();
            this.agent2Label = new System.Windows.Forms.Label();
            this.agent3Label = new System.Windows.Forms.Label();
            this.agent4Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eventTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(43, 49);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(94, 29);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time: 0\r\n";
            // 
            // inQueueLabel
            // 
            this.inQueueLabel.AutoSize = true;
            this.inQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inQueueLabel.Location = new System.Drawing.Point(174, 49);
            this.inQueueLabel.Name = "inQueueLabel";
            this.inQueueLabel.Size = new System.Drawing.Size(131, 29);
            this.inQueueLabel.TabIndex = 1;
            this.inQueueLabel.Text = "In queue: 0";
            // 
            // consumersNumLabel
            // 
            this.consumersNumLabel.AutoSize = true;
            this.consumersNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumersNumLabel.Location = new System.Drawing.Point(365, 49);
            this.consumersNumLabel.Name = "consumersNumLabel";
            this.consumersNumLabel.Size = new System.Drawing.Size(161, 29);
            this.consumersNumLabel.TabIndex = 2;
            this.consumersNumLabel.Text = "Consumers: 0\r\n";
            // 
            // agent0Label
            // 
            this.agent0Label.AutoSize = true;
            this.agent0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent0Label.Location = new System.Drawing.Point(187, 118);
            this.agent0Label.Name = "agent0Label";
            this.agent0Label.Size = new System.Drawing.Size(0, 29);
            this.agent0Label.TabIndex = 3;
            // 
            // agent1Label
            // 
            this.agent1Label.AutoSize = true;
            this.agent1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent1Label.Location = new System.Drawing.Point(187, 157);
            this.agent1Label.Name = "agent1Label";
            this.agent1Label.Size = new System.Drawing.Size(0, 29);
            this.agent1Label.TabIndex = 4;
            // 
            // agent2Label
            // 
            this.agent2Label.AutoSize = true;
            this.agent2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent2Label.Location = new System.Drawing.Point(187, 196);
            this.agent2Label.Name = "agent2Label";
            this.agent2Label.Size = new System.Drawing.Size(0, 29);
            this.agent2Label.TabIndex = 5;
            // 
            // agent3Label
            // 
            this.agent3Label.AutoSize = true;
            this.agent3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent3Label.Location = new System.Drawing.Point(187, 235);
            this.agent3Label.Name = "agent3Label";
            this.agent3Label.Size = new System.Drawing.Size(0, 29);
            this.agent3Label.TabIndex = 6;
            // 
            // agent4Label
            // 
            this.agent4Label.AutoSize = true;
            this.agent4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent4Label.Location = new System.Drawing.Point(187, 276);
            this.agent4Label.Name = "agent4Label";
            this.agent4Label.Size = new System.Drawing.Size(0, 29);
            this.agent4Label.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Agent 4:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Agent 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Agent 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Agent 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Agent 0:";
            // 
            // eventTimeLabel
            // 
            this.eventTimeLabel.AutoSize = true;
            this.eventTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTimeLabel.Location = new System.Drawing.Point(43, 342);
            this.eventTimeLabel.Name = "eventTimeLabel";
            this.eventTimeLabel.Size = new System.Drawing.Size(157, 29);
            this.eventTimeLabel.TabIndex = 13;
            this.eventTimeLabel.Text = "Next event in:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.eventTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agent4Label);
            this.Controls.Add(this.agent3Label);
            this.Controls.Add(this.agent2Label);
            this.Controls.Add(this.agent1Label);
            this.Controls.Add(this.agent0Label);
            this.Controls.Add(this.consumersNumLabel);
            this.Controls.Add(this.inQueueLabel);
            this.Controls.Add(this.timeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label inQueueLabel;
        private System.Windows.Forms.Label consumersNumLabel;
        private System.Windows.Forms.Label agent0Label;
        private System.Windows.Forms.Label agent1Label;
        private System.Windows.Forms.Label agent2Label;
        private System.Windows.Forms.Label agent3Label;
        private System.Windows.Forms.Label agent4Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eventTimeLabel;
    }
}

