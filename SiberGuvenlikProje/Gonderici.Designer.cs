
namespace SiberGuvenlikProje
{
    partial class Gonderici
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
            this.text_sifre = new System.Windows.Forms.TextBox();
            this.btn_ipgstr = new System.Windows.Forms.Button();
            this.txt_GosterilenIP = new System.Windows.Forms.TextBox();
            this.btn_baglan = new System.Windows.Forms.Button();
            this.txt_baglanilanIP = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_resimSec
            // 
            this.btn_resimSec.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_resimSec.Location = new System.Drawing.Point(14, 16);
            this.btn_resimSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_resimSec.Name = "btn_resimSec";
            this.btn_resimSec.Size = new System.Drawing.Size(149, 40);
            this.btn_resimSec.TabIndex = 0;
            this.btn_resimSec.Text = "RESİM SEÇ";
            this.btn_resimSec.UseVisualStyleBackColor = false;
            this.btn_resimSec.Click += new System.EventHandler(this.btn_resimSec_Click);
            // 
            // btn_sifrele
            // 
            this.btn_sifrele.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_sifrele.Location = new System.Drawing.Point(500, 195);
            this.btn_sifrele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sifrele.Name = "btn_sifrele";
            this.btn_sifrele.Size = new System.Drawing.Size(149, 40);
            this.btn_sifrele.TabIndex = 1;
            this.btn_sifrele.Text = "RESMİ ŞİFRELE";
            this.btn_sifrele.UseVisualStyleBackColor = false;
            this.btn_sifrele.Click += new System.EventHandler(this.btn_sifrele_Click);
            // 
            // btn_gonder
            // 
            this.btn_gonder.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_gonder.Location = new System.Drawing.Point(792, 237);
            this.btn_gonder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(110, 33);
            this.btn_gonder.TabIndex = 2;
            this.btn_gonder.Text = "GÖNDER";
            this.btn_gonder.UseVisualStyleBackColor = false;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // text_sifre
            // 
            this.text_sifre.Location = new System.Drawing.Point(655, 202);
            this.text_sifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_sifre.Name = "text_sifre";
            this.text_sifre.Size = new System.Drawing.Size(247, 27);
            this.text_sifre.TabIndex = 5;
            // 
            // btn_ipgstr
            // 
            this.btn_ipgstr.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ipgstr.Location = new System.Drawing.Point(500, 60);
            this.btn_ipgstr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ipgstr.Name = "btn_ipgstr";
            this.btn_ipgstr.Size = new System.Drawing.Size(149, 40);
            this.btn_ipgstr.TabIndex = 6;
            this.btn_ipgstr.Text = "IP GÖSTER";
            this.btn_ipgstr.UseVisualStyleBackColor = false;
            this.btn_ipgstr.Click += new System.EventHandler(this.btn_ipgstr_Click);
            // 
            // txt_GosterilenIP
            // 
            this.txt_GosterilenIP.Location = new System.Drawing.Point(655, 67);
            this.txt_GosterilenIP.Name = "txt_GosterilenIP";
            this.txt_GosterilenIP.Size = new System.Drawing.Size(247, 27);
            this.txt_GosterilenIP.TabIndex = 7;
            this.txt_GosterilenIP.TextChanged += new System.EventHandler(this.txt_GosterilenIP_TextChanged);
            // 
            // btn_baglan
            // 
            this.btn_baglan.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_baglan.Location = new System.Drawing.Point(500, 127);
            this.btn_baglan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Size = new System.Drawing.Size(149, 40);
            this.btn_baglan.TabIndex = 8;
            this.btn_baglan.Text = "IP BAĞLAN";
            this.btn_baglan.UseVisualStyleBackColor = false;
            this.btn_baglan.Click += new System.EventHandler(this.btn_baglan_Click);
            // 
            // txt_baglanilanIP
            // 
            this.txt_baglanilanIP.Location = new System.Drawing.Point(655, 134);
            this.txt_baglanilanIP.Name = "txt_baglanilanIP";
            this.txt_baglanilanIP.Size = new System.Drawing.Size(247, 27);
            this.txt_baglanilanIP.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(497, 277);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(405, 272);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Gonderici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txt_baglanilanIP);
            this.Controls.Add(this.btn_baglan);
            this.Controls.Add(this.txt_GosterilenIP);
            this.Controls.Add(this.btn_ipgstr);
            this.Controls.Add(this.text_sifre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.btn_sifrele);
            this.Controls.Add(this.btn_resimSec);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Gonderici";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Gonderici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resimSec;
        private System.Windows.Forms.Button btn_sifrele;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_sifre;
        private System.Windows.Forms.Button btn_ipgstr;
        private System.Windows.Forms.TextBox txt_GosterilenIP;
        private System.Windows.Forms.Button btn_baglan;
        private System.Windows.Forms.TextBox txt_baglanilanIP;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

