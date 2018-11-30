namespace MokiniuPazymiai
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
            this.comboMokinys = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textVidurkis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPazymiuMasyvai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textVisiPazymiai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboMokinys
            // 
            this.comboMokinys.FormattingEnabled = true;
            this.comboMokinys.Location = new System.Drawing.Point(36, 81);
            this.comboMokinys.Name = "comboMokinys";
            this.comboMokinys.Size = new System.Drawing.Size(214, 37);
            this.comboMokinys.TabIndex = 0;
            this.comboMokinys.SelectedIndexChanged += new System.EventHandler(this.comboMokinys_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mokinys";
            // 
            // textVidurkis
            // 
            this.textVidurkis.Location = new System.Drawing.Point(621, 81);
            this.textVidurkis.Name = "textVidurkis";
            this.textVidurkis.Size = new System.Drawing.Size(100, 35);
            this.textVidurkis.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vidurkis";
            // 
            // textPazymiuMasyvai
            // 
            this.textPazymiuMasyvai.Location = new System.Drawing.Point(36, 235);
            this.textPazymiuMasyvai.Multiline = true;
            this.textPazymiuMasyvai.Name = "textPazymiuMasyvai";
            this.textPazymiuMasyvai.Size = new System.Drawing.Size(591, 71);
            this.textPazymiuMasyvai.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pazymiai";
            // 
            // textVisiPazymiai
            // 
            this.textVisiPazymiai.Location = new System.Drawing.Point(36, 356);
            this.textVisiPazymiai.Multiline = true;
            this.textVisiPazymiai.Name = "textVisiPazymiai";
            this.textVisiPazymiai.Size = new System.Drawing.Size(591, 342);
            this.textVisiPazymiai.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 803);
            this.Controls.Add(this.textVisiPazymiai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPazymiuMasyvai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textVidurkis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMokinys);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMokinys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textVidurkis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPazymiuMasyvai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textVisiPazymiai;
    }
}

