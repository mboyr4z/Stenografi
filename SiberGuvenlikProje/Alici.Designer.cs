
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alici));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sifrecoz = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_cozulmusSifre = new System.Windows.Forms.TextBox();
            this.btn_baglan = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 307);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_sifrecoz
            // 
            this.btn_sifrecoz.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_sifrecoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sifrecoz.Enabled = false;
            this.btn_sifrecoz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sifrecoz.ImageKey = "kilit.ico";
            this.btn_sifrecoz.ImageList = this.ımageList1;
            this.btn_sifrecoz.Location = new System.Drawing.Point(546, 148);
            this.btn_sifrecoz.Name = "btn_sifrecoz";
            this.btn_sifrecoz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_sifrecoz.Size = new System.Drawing.Size(181, 51);
            this.btn_sifrecoz.TabIndex = 1;
            this.btn_sifrecoz.Text = "ŞİFREYİ  ÇÖZ     ";
            this.btn_sifrecoz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sifrecoz.UseVisualStyleBackColor = false;
            this.btn_sifrecoz.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kilit.ico");
            // 
            // txt_cozulmusSifre
            // 
            this.txt_cozulmusSifre.Location = new System.Drawing.Point(546, 205);
            this.txt_cozulmusSifre.Name = "txt_cozulmusSifre";
            this.txt_cozulmusSifre.Size = new System.Drawing.Size(181, 27);
            this.txt_cozulmusSifre.TabIndex = 2;
            // 
            // btn_baglan
            // 
            this.btn_baglan.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_baglan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_baglan.ImageKey = "connection-removebg-preview.png";
            this.btn_baglan.ImageList = this.ımageList2;
            this.btn_baglan.Location = new System.Drawing.Point(546, 12);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_baglan.Size = new System.Drawing.Size(183, 51);
            this.btn_baglan.TabIndex = 3;
            this.btn_baglan.Text = "IP BAĞLAN";
            this.btn_baglan.UseVisualStyleBackColor = false;
            this.btn_baglan.Click += new System.EventHandler(this.btn_baglan_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "connection-removebg-preview.png");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(546, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Moccasin;
            this.btn_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_geri.BackgroundImage")));
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_geri.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.Location = new System.Drawing.Point(12, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(49, 47);
            this.btn_geri.TabIndex = 12;
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Alici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(784, 328);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_baglan);
            this.Controls.Add(this.txt_cozulmusSifre);
            this.Controls.Add(this.btn_sifrecoz);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alici";
            this.Text = "Alici";
            this.Load += new System.EventHandler(this.Alici_Load);
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
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btn_geri;
    }
}