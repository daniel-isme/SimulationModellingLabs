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
            this.display_richTextBox = new System.Windows.Forms.RichTextBox();
            this.teams_richTextBox = new System.Windows.Forms.RichTextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display_richTextBox
            // 
            this.display_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_richTextBox.Location = new System.Drawing.Point(161, 199);
            this.display_richTextBox.Name = "display_richTextBox";
            this.display_richTextBox.Size = new System.Drawing.Size(459, 303);
            this.display_richTextBox.TabIndex = 0;
            this.display_richTextBox.Text = "Team name - Points / Wins / Draws / Loses";
            // 
            // teams_richTextBox
            // 
            this.teams_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teams_richTextBox.Location = new System.Drawing.Point(219, 41);
            this.teams_richTextBox.Name = "teams_richTextBox";
            this.teams_richTextBox.Size = new System.Drawing.Size(345, 85);
            this.teams_richTextBox.TabIndex = 1;
            this.teams_richTextBox.Text = "West Ham, Manchester City, Arsenal, Chealsea, Liverpool, Spurs, Everton, Manchest" +
    "er United, Leister, Wolves";
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(333, 142);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 42);
            this.generateButton.TabIndex = 14;
            this.generateButton.Text = "Start";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter team names with a comma \",\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.teams_richTextBox);
            this.Controls.Add(this.display_richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox display_richTextBox;
        private System.Windows.Forms.RichTextBox teams_richTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label1;
    }
}

