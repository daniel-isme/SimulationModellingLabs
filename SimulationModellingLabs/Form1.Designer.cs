namespace CurrencySimulation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.inputPrice = new System.Windows.Forms.NumericUpDown();
            this.inputDays = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.inputSpeed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputEuros = new System.Windows.Forms.NumericUpDown();
            this.btnBuy = new System.Windows.Forms.Button();
            this.textRubles = new System.Windows.Forms.Label();
            this.textEuros = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEuros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 210);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.DarkGreen;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "f4";
            series3.Legend = "Legend1";
            series3.Name = "Euro";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(852, 395);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Days";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(19, 118);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(167, 52);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // inputPrice
            // 
            this.inputPrice.DecimalPlaces = 4;
            this.inputPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPrice.Location = new System.Drawing.Point(154, 21);
            this.inputPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(166, 36);
            this.inputPrice.TabIndex = 4;
            this.inputPrice.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // inputDays
            // 
            this.inputDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDays.Location = new System.Drawing.Point(154, 71);
            this.inputDays.Name = "inputDays";
            this.inputDays.Size = new System.Drawing.Size(120, 36);
            this.inputDays.TabIndex = 5;
            this.inputDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.inputDays.ValueChanged += new System.EventHandler(this.inputDays_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed";
            // 
            // inputSpeed
            // 
            this.inputSpeed.Location = new System.Drawing.Point(482, 13);
            this.inputSpeed.Maximum = 40;
            this.inputSpeed.Minimum = 1;
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(333, 56);
            this.inputSpeed.TabIndex = 8;
            this.inputSpeed.Value = 5;
            this.inputSpeed.Scroll += new System.EventHandler(this.inputSpeed_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Slow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(780, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fast";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Euros";
            // 
            // inputEuros
            // 
            this.inputEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEuros.Location = new System.Drawing.Point(496, 77);
            this.inputEuros.Name = "inputEuros";
            this.inputEuros.Size = new System.Drawing.Size(120, 36);
            this.inputEuros.TabIndex = 13;
            this.inputEuros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(402, 124);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(103, 46);
            this.btnBuy.TabIndex = 14;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // textRubles
            // 
            this.textRubles.AutoSize = true;
            this.textRubles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRubles.Location = new System.Drawing.Point(16, 32);
            this.textRubles.Name = "textRubles";
            this.textRubles.Size = new System.Drawing.Size(91, 36);
            this.textRubles.TabIndex = 15;
            this.textRubles.Text = "500 ₽";
            // 
            // textEuros
            // 
            this.textEuros.AutoSize = true;
            this.textEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEuros.Location = new System.Drawing.Point(16, 65);
            this.textEuros.Name = "textEuros";
            this.textEuros.Size = new System.Drawing.Size(57, 36);
            this.textEuros.TabIndex = 16;
            this.textEuros.Text = "0 €";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 617);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRubles);
            this.groupBox1.Controls.Add(this.textEuros);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(664, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 104);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank";
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Location = new System.Drawing.Point(511, 124);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(105, 46);
            this.btnSell.TabIndex = 18;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 617);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.inputEuros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputDays);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEuros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown inputPrice;
        private System.Windows.Forms.NumericUpDown inputDays;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar inputSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown inputEuros;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label textRubles;
        private System.Windows.Forms.Label textEuros;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSell;
    }
}

