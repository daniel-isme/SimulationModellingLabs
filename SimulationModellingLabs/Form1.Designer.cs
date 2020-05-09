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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prob1TextBox = new System.Windows.Forms.TextBox();
            this.prob2TextBox = new System.Windows.Forms.TextBox();
            this.prob3TextBox = new System.Windows.Forms.TextBox();
            this.prob4TextBox = new System.Windows.Forms.TextBox();
            this.prob5TextBox = new System.Windows.Forms.TextBox();
            this.numOfExperimentsTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(337, 31);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(437, 374);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.Name = "Title1";
            title2.Text = "freq.";
            this.chart1.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prob 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prob 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prob 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prob 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prob 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number of experiments";
            // 
            // prob1TextBox
            // 
            this.prob1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prob1TextBox.Location = new System.Drawing.Point(87, 66);
            this.prob1TextBox.Name = "prob1TextBox";
            this.prob1TextBox.Size = new System.Drawing.Size(81, 27);
            this.prob1TextBox.TabIndex = 7;
            this.prob1TextBox.Text = "0.18536";
            this.prob1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prob2TextBox
            // 
            this.prob2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prob2TextBox.Location = new System.Drawing.Point(87, 100);
            this.prob2TextBox.Name = "prob2TextBox";
            this.prob2TextBox.Size = new System.Drawing.Size(81, 27);
            this.prob2TextBox.TabIndex = 8;
            this.prob2TextBox.Text = "0.25852";
            this.prob2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prob3TextBox
            // 
            this.prob3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prob3TextBox.Location = new System.Drawing.Point(87, 134);
            this.prob3TextBox.Name = "prob3TextBox";
            this.prob3TextBox.Size = new System.Drawing.Size(81, 27);
            this.prob3TextBox.TabIndex = 9;
            this.prob3TextBox.Text = "0.156432";
            this.prob3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prob4TextBox
            // 
            this.prob4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prob4TextBox.Location = new System.Drawing.Point(87, 169);
            this.prob4TextBox.Name = "prob4TextBox";
            this.prob4TextBox.Size = new System.Drawing.Size(81, 27);
            this.prob4TextBox.TabIndex = 10;
            this.prob4TextBox.Text = "0.28765";
            this.prob4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prob5TextBox
            // 
            this.prob5TextBox.Enabled = false;
            this.prob5TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prob5TextBox.Location = new System.Drawing.Point(87, 203);
            this.prob5TextBox.Name = "prob5TextBox";
            this.prob5TextBox.Size = new System.Drawing.Size(81, 27);
            this.prob5TextBox.TabIndex = 11;
            this.prob5TextBox.Text = "auto";
            this.prob5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numOfExperimentsTextBox
            // 
            this.numOfExperimentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfExperimentsTextBox.Location = new System.Drawing.Point(242, 256);
            this.numOfExperimentsTextBox.Name = "numOfExperimentsTextBox";
            this.numOfExperimentsTextBox.Size = new System.Drawing.Size(75, 27);
            this.numOfExperimentsTextBox.TabIndex = 12;
            this.numOfExperimentsTextBox.Text = "100";
            this.numOfExperimentsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(87, 321);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(138, 42);
            this.generateButton.TabIndex = 13;
            this.generateButton.Text = "GENERATE";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(14, 380);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 25);
            this.errorLabel.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numOfExperimentsTextBox);
            this.Controls.Add(this.prob5TextBox);
            this.Controls.Add(this.prob4TextBox);
            this.Controls.Add(this.prob3TextBox);
            this.Controls.Add(this.prob2TextBox);
            this.Controls.Add(this.prob1TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prob1TextBox;
        private System.Windows.Forms.TextBox prob2TextBox;
        private System.Windows.Forms.TextBox prob3TextBox;
        private System.Windows.Forms.TextBox prob4TextBox;
        private System.Windows.Forms.TextBox prob5TextBox;
        private System.Windows.Forms.TextBox numOfExperimentsTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button button1;
    }
}

