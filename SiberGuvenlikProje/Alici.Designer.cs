
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_baglan = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 337);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sifrecoz
            // 
            this.btn_sifrecoz.Location = new System.Drawing.Point(514, 24);
            this.btn_sifrecoz.Name = "btn_sifrecoz";
            this.btn_sifrecoz.Size = new System.Drawing.Size(205, 65);
            this.btn_sifrecoz.TabIndex = 1;
            this.btn_sifrecoz.Text = "SİFRE CÖZ";
            this.btn_sifrecoz.UseVisualStyleBackColor = true;
            this.btn_sifrecoz.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_baglan
            // 
            this.btn_baglan.Location = new System.Drawing.Point(514, 272);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Size = new System.Drawing.Size(237, 29);
            this.btn_baglan.TabIndex = 3;
            this.btn_baglan.Text = "BAGLAN";
            this.btn_baglan.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(514, 314);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 27);
            this.textBox2.TabIndex = 4;
            // 
            // Alici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_baglan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_sifrecoz);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_baglan;
        private System.Windows.Forms.TextBox textBox2;
    }
}