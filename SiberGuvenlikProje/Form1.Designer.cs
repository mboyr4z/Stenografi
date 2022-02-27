
namespace SiberGuvenlikProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_resimSec = new System.Windows.Forms.Button();
            this.btn_sifrele = new System.Windows.Forms.Button();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sifreCoz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_resimSec
            // 
            this.btn_resimSec.Location = new System.Drawing.Point(12, 12);
            this.btn_resimSec.Name = "btn_resimSec";
            this.btn_resimSec.Size = new System.Drawing.Size(130, 30);
            this.btn_resimSec.TabIndex = 0;
            this.btn_resimSec.Text = "Resim Seç";
            this.btn_resimSec.UseVisualStyleBackColor = true;
            // 
            // btn_sifrele
            // 
            this.btn_sifrele.Location = new System.Drawing.Point(435, 48);
            this.btn_sifrele.Name = "btn_sifrele";
            this.btn_sifrele.Size = new System.Drawing.Size(130, 30);
            this.btn_sifrele.TabIndex = 1;
            this.btn_sifrele.Text = "Şifrele";
            this.btn_sifrele.UseVisualStyleBackColor = true;
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(435, 84);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(130, 30);
            this.btn_gonder.TabIndex = 2;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 390);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sifreCoz
            // 
            this.btn_sifreCoz.Location = new System.Drawing.Point(435, 120);
            this.btn_sifreCoz.Name = "btn_sifreCoz";
            this.btn_sifreCoz.Size = new System.Drawing.Size(130, 30);
            this.btn_sifreCoz.TabIndex = 4;
            this.btn_sifreCoz.Text = "Şifre Çöz";
            this.btn_sifreCoz.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 23);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_sifreCoz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.btn_sifrele);
            this.Controls.Add(this.btn_resimSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resimSec;
        private System.Windows.Forms.Button btn_sifrele;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sifreCoz;
        private System.Windows.Forms.TextBox textBox1;
    }
}

