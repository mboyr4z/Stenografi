using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SiberGuvenlikProje
{
    public partial class Baslangic : Form
    {
        public static Gonderici gonderici;
        public static Alici alici;
        public static  Baslangic baslangic;
        public Baslangic()
        {
             alici = new Alici();
             gonderici = new Gonderici();
            baslangic = this;
            


            InitializeComponent();
        }

        private void btn_gndrci_Click(object sender, EventArgs e)
        {
            gonderici.Show();
            CloseWindow();

        }

        private void btn_alici_Click(object sender, EventArgs e)
        {
            alici.Show();
            CloseWindow();


        }

        private void CloseWindow()
        {
            this.Hide();
        }
    }
}
