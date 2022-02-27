using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiberGuvenlikProje
{
    public partial class Gonderici : Form
    {
        private string IP = "";

        private int PORT = 9999;

        private Bitmap goruntu;

        private string dosyaYolu = "";

        int kalan;


        public Gonderici()
        {
            InitializeComponent();
        }

        private void Gonderici_Load(object sender, EventArgs e)
        {

        }

        private void btn_baglan_Click(object sender, EventArgs e)
        {
            IP = txt_baglanilanIP.Text;
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT); //gönderen kisi ipsi
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                client.Connect(iep);

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input.ToUpper().Equals("QUIT"))
                    {
                        break;
                    }
                    else
                    {
                        // receive data
                        byte[] buffer = new byte[1000000];
                        client.Receive(buffer, buffer.Length, SocketFlags.None);
                        Console.WriteLine("Receive success");

                        File.WriteAllBytes("gonderilecek.png", buffer);
                    }
                }
            }
        }

        private void btn_resimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = " Resim Dosyası|*.png";
            file.ShowDialog();  // openfiledialog ekranını açıyoruz.

            if (file.FileName != "")
            {
                dosyaYolu = file.FileName;
            }
            else
            {

            }

            pictureBox1.Image = Image.FromFile(dosyaYolu);
        }

        private void btn_ipgstr_Click(object sender, EventArgs e)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    txt_GosterilenIP.Text = ip.ToString();
                    break;
                }
            }
        }

        private void btn_sifrele_Click(object sender, EventArgs e)
        {
            goruntu = new Bitmap(dosyaYolu);
            string sifre = text_sifre.Text;

            


            Color pixel = goruntu.GetPixel(goruntu.Width - 1, goruntu.Height - 1);
            int kacHanedeBirSifrelenecek = (pixel.R % 5) + 1;

            Color pixel2 = goruntu.GetPixel(goruntu.Width - 2, goruntu.Height - 1);
            int HangiRGb = (pixel.G % 3);




            int sayac = 0;
            int harfsayaci = 0;

            for (int i = 0; i < goruntu.Height; i++)//resmi yatay olarak taramak için
            {
                for (int j = 0; j < goruntu.Width; j++)//resmi dikey olarak taramak için
                {

                    if (sayac % kacHanedeBirSifrelenecek == 0)
                    {
                      
                        Color Pixel = goruntu.GetPixel(j, i);//color sınıfını ile pixel rengini alıyoruz.
                        switch (HangiRGb)
                        {
                            case 0:
                                kalan = pixel.R % 35;
                                break;
                            case 1:
                                kalan = pixel.G % 35;
                                break;
                            case 2:

                                kalan = pixel.B % 35;
                                break;
                        }

                        int asciiKalan = ((int)sifre[harfsayaci]) % 97;

                        //richTextBox1.Text += kalan.ToString() +" " + (asciiKalan).ToString() +  " \n";
                        int fark = asciiKalan - kalan;
                      
                   
                        switch (HangiRGb)
                        {
                            case 0:
                                if (pixel.R > 215)
                                {
                                    fark -= 35;
                                }
                                
                                goruntu.SetPixel(j,i,Color.FromArgb(255,pixel.R + fark, pixel.G,pixel.B));
                                break;
                            case 1:
                                if (pixel.G > 215)
                                {
                                    fark -= 35;
                                }
                                goruntu.SetPixel(j, i, Color.FromArgb(255, pixel.R , pixel.G + fark, pixel.B));
                                break;
                            case 2:
                                if (pixel.B > 215)
                                {
                                    fark -= 35;
                                }
                                goruntu.SetPixel(j, i, Color.FromArgb(255, pixel.R, pixel.G, pixel.B + fark));
                                break;
                        }


                        harfsayaci++;
                        sayac = 0;
                    }
                    sayac++;

                    if (harfsayaci == sifre.Length)
                    {
                        pictureBox1.Image = goruntu;
                        btn_sifrele.Text = "Şifrelendi";
                        goruntu.Save("gonderilecek", ImageFormat.Png);
                        return;
                    }
                }

            }

        }


    }
}