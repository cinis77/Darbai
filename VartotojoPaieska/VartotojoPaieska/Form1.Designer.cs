namespace VartotojoPaieska
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
            this.textIeskomasis = new System.Windows.Forms.TextBox();
            this.textBoxRezultatai = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textIeskomasis
            // 
            this.textIeskomasis.Location = new System.Drawing.Point(36, 93);
            this.textIeskomasis.Name = "textIeskomasis";
            this.textIeskomasis.Size = new System.Drawing.Size(267, 35);
            this.textIeskomasis.TabIndex = 0;
            // 
            // textBoxRezultatai
            // 
            this.textBoxRezultatai.Location = new System.Drawing.Point(568, 74);
            this.textBoxRezultatai.Multiline = true;
            this.textBoxRezultatai.Name = "textBoxRezultatai";
            this.textBoxRezultatai.Size = new System.Drawing.Size(330, 499);
            this.textBoxRezultatai.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Paieska";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 851);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRezultatai);
            this.Controls.Add(this.textIeskomasis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIeskomasis;
        private System.Windows.Forms.TextBox textBoxRezultatai;
        private System.Windows.Forms.Button button1;
    }
}

