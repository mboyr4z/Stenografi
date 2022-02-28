
namespace SiberGuvenlikProje
{
    partial class Alici
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sifrecoz = new System.Windows.Forms.Button();
            this.txt_cozulmusSifre = new System.Windows.Forms.TextBox();
            this.btn_baglan = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 253);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sifrecoz
            // 
            this.btn_sifrecoz.Location = new System.Drawing.Point(450, 18);
            this.btn_sifrecoz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sifrecoz.Name = "btn_sifrecoz";
            this.btn_sifrecoz.Size = new System.Drawing.Size(179, 49);
            this.btn_sifrecoz.TabIndex = 1;
            this.btn_sifrecoz.Text = "SİFRE CÖZ";
            this.btn_sifrecoz.UseVisualStyleBackColor = true;
            this.btn_sifrecoz.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cozulmusSifre
            // 
            this.txt_cozulmusSifre.Location = new System.Drawing.Point(450, 80);
            this.txt_cozulmusSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cozulmusSifre.Name = "txt_cozulmusSifre";
            this.txt_cozulmusSifre.Size = new System.Drawing.Size(180, 23);
            this.txt_cozulmusSifre.TabIndex = 2;
            // 
            // btn_baglan
            // 
            this.btn_baglan.Location = new System.Drawing.Point(450, 204);
            this.btn_baglan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Size = new System.Drawing.Size(207, 22);
            this.btn_baglan.TabIndex = 3;
            this.btn_baglan.Text = "BAGLAN";
            this.btn_baglan.UseVisualStyleBackColor = true;
            this.btn_baglan.Click += new System.EventHandler(this.btn_baglan_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 236);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 23);
            this.textBox2.TabIndex = 4;
            // 
            // Alici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_baglan);
            this.Controls.Add(this.txt_cozulmusSifre);
            this.Controls.Add(this.btn_sifrecoz);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Alici";
            this.Text = "Alici";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sifrecoz;
        private System.Windows.Forms.TextBox txt_cozulmusSifre;
        private System.Windows.Forms.Button btn_baglan;
        private System.Windows.Forms.TextBox textBox2;
    }
}