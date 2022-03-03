
namespace SiberGuvenlikProje
{
    partial class Baslangic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baslangic));
            this.btn_gndrci = new System.Windows.Forms.Button();
            this.btn_alici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gndrci
            // 
            this.btn_gndrci.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_gndrci.Location = new System.Drawing.Point(12, 12);
            this.btn_gndrci.Name = "btn_gndrci";
            this.btn_gndrci.Size = new System.Drawing.Size(208, 119);
            this.btn_gndrci.TabIndex = 1;
            this.btn_gndrci.Text = "GÖNDERİCİ";
            this.btn_gndrci.UseVisualStyleBackColor = false;
            this.btn_gndrci.Click += new System.EventHandler(this.btn_gndrci_Click);
            // 
            // btn_alici
            // 
            this.btn_alici.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_alici.Location = new System.Drawing.Point(242, 12);
            this.btn_alici.Name = "btn_alici";
            this.btn_alici.Size = new System.Drawing.Size(208, 119);
            this.btn_alici.TabIndex = 2;
            this.btn_alici.Text = "ALİCİ";
            this.btn_alici.UseVisualStyleBackColor = false;
            this.btn_alici.Click += new System.EventHandler(this.btn_alici_Click);
            // 
            // Baslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(462, 141);
            this.Controls.Add(this.btn_alici);
            this.Controls.Add(this.btn_gndrci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Baslangic";
            this.Text = "Baslangic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gndrci;
        private System.Windows.Forms.Button btn_alici;
    }
}