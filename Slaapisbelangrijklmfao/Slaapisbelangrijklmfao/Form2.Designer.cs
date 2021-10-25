
namespace Slaapisbelangrijklmfao
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeunSpreekt = new System.Windows.Forms.TextBox();
            this.TeunsImput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TeunsImput);
            this.panel1.Controls.Add(this.TeunSpreekt);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 329);
            this.panel1.TabIndex = 0;
            // 
            // TeunSpreekt
            // 
            this.TeunSpreekt.BackColor = System.Drawing.Color.White;
            this.TeunSpreekt.Location = new System.Drawing.Point(16, 170);
            this.TeunSpreekt.Multiline = true;
            this.TeunSpreekt.Name = "TeunSpreekt";
            this.TeunSpreekt.ReadOnly = true;
            this.TeunSpreekt.Size = new System.Drawing.Size(180, 140);
            this.TeunSpreekt.TabIndex = 0;
            // 
            // TeunsImput
            // 
            this.TeunsImput.Location = new System.Drawing.Point(16, 60);
            this.TeunsImput.Name = "TeunsImput";
            this.TeunsImput.Size = new System.Drawing.Size(180, 26);
            this.TeunsImput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stuurlol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teun geeft een compliment";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Slaapisbelangrijklmfao.Properties.Resources.WhatsApp_Image_2021_10_25_at_12_39_33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 705);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Teuuuuuuuuuuuuuuuuuuuuuuuuuuun";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TeunsImput;
        private System.Windows.Forms.TextBox TeunSpreekt;
        private System.Windows.Forms.Label label1;
    }
}