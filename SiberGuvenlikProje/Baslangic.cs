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
        public Baslangic()
        {
            InitializeComponent();
        }

        private void btn_gndrci_Click(object sender, EventArgs e)
        {
            Gonderici gonderici = new Gonderici();
            gonderici.Show();
            CloseWindow();

        }

        private void btn_alici_Click(object sender, EventArgs e)
        {
            Alici alici = new Alici();
            alici.Show();
            CloseWindow();


        }

        private void CloseWindow()
        {
            this.Hide();
        }
    }
}
