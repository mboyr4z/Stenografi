
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
            this.btn_chooseImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_chooseImage
            // 
            this.btn_chooseImage.Location = new System.Drawing.Point(115, 60);
            this.btn_chooseImage.Name = "btn_chooseImage";
            this.btn_chooseImage.Size = new System.Drawing.Size(75, 23);
            this.btn_chooseImage.TabIndex = 0;
            this.btn_chooseImage.Text = "button1";
            this.btn_chooseImage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_chooseImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_chooseImage;
    }
}

