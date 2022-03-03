
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
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 337);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sifrecoz
            // 
            this.btn_sifrecoz.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_sifrecoz.Location = new System.Drawing.Point(546, 26);
            this.btn_sifrecoz.Name = "btn_sifrecoz";
            this.btn_sifrecoz.Size = new System.Drawing.Size(205, 65);
            this.btn_sifrecoz.TabIndex = 1;
            this.btn_sifrecoz.Text = "ŞİFREYİ  ÇÖZ";
            this.btn_sifrecoz.UseVisualStyleBackColor = false;
            this.btn_sifrecoz.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cozulmusSifre
            // 
            this.txt_cozulmusSifre.Location = new System.Drawing.Point(546, 107);
            this.txt_cozulmusSifre.Name = "txt_cozulmusSifre";
            this.txt_cozulmusSifre.Size = new System.Drawing.Size(205, 27);
            this.txt_cozulmusSifre.TabIndex = 2;
            // 
            // btn_baglan
            // 
            this.btn_baglan.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_baglan.Location = new System.Drawing.Point(531, 228);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Size = new System.Drawing.Size(237, 29);
            this.btn_baglan.TabIndex = 3;
            this.btn_baglan.Text = "IP BAĞLAN";
            this.btn_baglan.UseVisualStyleBackColor = false;
            this.btn_baglan.Click += new System.EventHandler(this.btn_baglan_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(531, 276);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Alici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(784, 366);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_baglan);
            this.Controls.Add(this.txt_cozulmusSifre);
            this.Controls.Add(this.btn_sifrecoz);
            this.Controls.Add(this.pictureBox1);
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