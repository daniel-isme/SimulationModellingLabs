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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display_richTextBox
            // 
            this.display_richTextBox.Location = new System.Drawing.Point(129, 192);
            this.display_richTextBox.Name = "display_richTextBox";
            this.display_richTextBox.Size = new System.Drawing.Size(542, 214);
            this.display_richTextBox.TabIndex = 0;
            this.display_richTextBox.Text = "";
            // 
            // teams_richTextBox
            // 
            this.teams_richTextBox.Location = new System.Drawing.Point(267, 27);
            this.teams_richTextBox.Name = "teams_richTextBox";
            this.teams_richTextBox.Size = new System.Drawing.Size(240, 85);
            this.teams_richTextBox.TabIndex = 1;
            this.teams_richTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teams_richTextBox);
            this.Controls.Add(this.display_richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox display_richTextBox;
        private System.Windows.Forms.RichTextBox teams_richTextBox;
        private System.Windows.Forms.Button button1;
    }
}

