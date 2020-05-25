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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.numOfExperimentsTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.chiSquaredLabel = new System.Windows.Forms.Label();
            this.chiSquaredLogicLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.range_textBox = new System.Windows.Forms.TextBox();
            this.Dx_textBox = new System.Windows.Forms.TextBox();
            this.Ex_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(337, 31);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(437, 291);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Name = "Title1";
            title1.Text = "freq.";
            this.chart1.Titles.Add(title1);
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
            this.generateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(87, 321);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 42);
            this.generateButton.TabIndex = 13;
            this.generateButton.Text = "Start";
            this.generateButton.UseVisualStyleBackColor = false;
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
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.Location = new System.Drawing.Point(332, 338);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(92, 25);
            this.averageLabel.TabIndex = 16;
            this.averageLabel.Text = "Average:";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varianceLabel.Location = new System.Drawing.Point(332, 363);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(96, 25);
            this.varianceLabel.TabIndex = 17;
            this.varianceLabel.Text = "Variance:";
            // 
            // chiSquaredLabel
            // 
            this.chiSquaredLabel.AutoSize = true;
            this.chiSquaredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiSquaredLabel.Location = new System.Drawing.Point(332, 402);
            this.chiSquaredLabel.Name = "chiSquaredLabel";
            this.chiSquaredLabel.Size = new System.Drawing.Size(126, 25);
            this.chiSquaredLabel.TabIndex = 18;
            this.chiSquaredLabel.Text = "Chi-squared:";
            // 
            // chiSquaredLogicLabel
            // 
            this.chiSquaredLogicLabel.AutoSize = true;
            this.chiSquaredLogicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiSquaredLogicLabel.Location = new System.Drawing.Point(647, 402);
            this.chiSquaredLogicLabel.Name = "chiSquaredLogicLabel";
            this.chiSquaredLogicLabel.Size = new System.Drawing.Size(0, 25);
            this.chiSquaredLogicLabel.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Variance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Range";
            // 
            // range_textBox
            // 
            this.range_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_textBox.Location = new System.Drawing.Point(242, 204);
            this.range_textBox.Name = "range_textBox";
            this.range_textBox.Size = new System.Drawing.Size(75, 27);
            this.range_textBox.TabIndex = 22;
            this.range_textBox.Text = "10";
            this.range_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dx_textBox
            // 
            this.Dx_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dx_textBox.Location = new System.Drawing.Point(242, 152);
            this.Dx_textBox.Name = "Dx_textBox";
            this.Dx_textBox.Size = new System.Drawing.Size(75, 27);
            this.Dx_textBox.TabIndex = 23;
            this.Dx_textBox.Text = "1";
            this.Dx_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ex_textBox
            // 
            this.Ex_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex_textBox.Location = new System.Drawing.Point(242, 102);
            this.Ex_textBox.Name = "Ex_textBox";
            this.Ex_textBox.Size = new System.Drawing.Size(75, 27);
            this.Ex_textBox.TabIndex = 24;
            this.Ex_textBox.Text = "0";
            this.Ex_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ex_textBox);
            this.Controls.Add(this.Dx_textBox);
            this.Controls.Add(this.range_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chiSquaredLogicLabel);
            this.Controls.Add(this.chiSquaredLabel);
            this.Controls.Add(this.varianceLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numOfExperimentsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numOfExperimentsTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label varianceLabel;
        private System.Windows.Forms.Label chiSquaredLabel;
        private System.Windows.Forms.Label chiSquaredLogicLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox range_textBox;
        private System.Windows.Forms.TextBox Dx_textBox;
        private System.Windows.Forms.TextBox Ex_textBox;
        private System.Windows.Forms.Label label3;
    }
}

