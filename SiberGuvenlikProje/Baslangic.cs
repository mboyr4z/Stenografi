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
        public static Baslangic baslangic;
        public static bool geritusumu;
        public static bool sifrelendimi;
        public static bool ipbaglandimi;
        public Baslangic()
        {
             alici = new Alici();
             gonderici = new Gonderici();
             baslangic = this;

            geritusumu = false;
            


            InitializeComponent();
        }

        private void btn_gndrci_Click(object sender, EventArgs e)
        {
            geritusumu = false;
            ipbaglandimi = false;
            sifrelendimi = false;
            gonderici.Show();
            CloseWindow();

        }

        private void btn_alici_Click(object sender, EventArgs e)
        {
            geritusumu = false;
            alici.Show();
            CloseWindow();

        }

        private void CloseWindow()
        {
            this.Hide();
        }
    }
}
