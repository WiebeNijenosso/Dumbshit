
namespace Slaapisbelangrijklmfao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nickInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NicksMeeeeeeeeeeeeeeeeeening = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NicksMeeeeeeeeeeeeeeeeeening);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nickInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 456);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nick vertelt iets over jou! \r\nVul hier uw naam in alstublieft";
            // 
            // nickInput
            // 
            this.nickInput.Location = new System.Drawing.Point(51, 86);
            this.nickInput.Name = "nickInput";
            this.nickInput.Size = new System.Drawing.Size(79, 26);
            this.nickInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stuur lol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NicksMeeeeeeeeeeeeeeeeeening
            // 
            this.NicksMeeeeeeeeeeeeeeeeeening.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NicksMeeeeeeeeeeeeeeeeeening.Location = new System.Drawing.Point(13, 241);
            this.NicksMeeeeeeeeeeeeeeeeeening.Multiline = true;
            this.NicksMeeeeeeeeeeeeeeeeeening.Name = "NicksMeeeeeeeeeeeeeeeeeening";
            this.NicksMeeeeeeeeeeeeeeeeeening.ReadOnly = true;
            this.NicksMeeeeeeeeeeeeeeeeeening.Size = new System.Drawing.Size(309, 202);
            this.NicksMeeeeeeeeeeeeeeeeeening.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 454);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Nick Franken heeft een mening";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NicksMeeeeeeeeeeeeeeeeeening;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nickInput;
    }
}

