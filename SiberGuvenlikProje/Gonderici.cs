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
            Image newImage = Image.FromFile(dosyaYolu);
            goruntu = CreateNonIndexedImage(newImage);
            string sifre = text_sifre.Text;


            Color pixel = goruntu.GetPixel(goruntu.Width - 1, goruntu.Height - 1);
            int kacHanedeBirSifrelenecek = (pixel.R % 5) + 1;

            cikti.al("Kac Hanede : " + kacHanedeBirSifrelenecek.ToString());

            pixel = goruntu.GetPixel(goruntu.Width - 2, goruntu.Height - 1);
            int HangiRGb = (pixel.G % 3);
            cikti.al("Hangi RGB : " + HangiRGb.ToString());

            




            int sayac = 0;
            int harfsayaci = 0;
            int asciiKalan = 0;

            for (int i = 0; i < goruntu.Height; i++)//resmi yatay olarak taramak için
            {
                for (int j = 0; j < goruntu.Width; j++)//resmi dikey olarak taramak için
                {

                    if (sayac % kacHanedeBirSifrelenecek == 0)
                    {
                        pixel = goruntu.GetPixel(j, i);
                      

                        if ((int)sifre[harfsayaci] == 32)       // space tuşu için
                        {
                            asciiKalan = 35;
                        }

                        else if ((int)sifre[harfsayaci] >= 97)      // harfler çin
                        {
                            asciiKalan = ((int)sifre[harfsayaci]) % 97;
                        }
                        else if((int)sifre[harfsayaci] >= 48 && (int)sifre[harfsayaci] <= 57)       // sayılar için
                        {
                            asciiKalan = ((int)sifre[harfsayaci]) % 48   + 26;
                        }
                        
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
                        
                        

                        int fark = asciiKalan - kalan;

                        int r, g, b;
                        r = pixel.R;
                        g = pixel.G;
                        b = pixel.B;

            
                        switch (HangiRGb)
                        {
                            case 0:
                              
                                if (pixel.R > 215)
                                {
                                    fark -= 35;
                                }
                                r += fark;
                                break;
                            case 1:
                                if (pixel.G > 215)
                                {
                                    fark -= 35;
                                }
                                g += fark;
                                break;
                            case 2:
                                if (pixel.B > 215)
                                {
                                    fark -= 35;
                                }
                                b += fark;
                                break;
                        }

                        goruntu.SetPixel(j, i, Color.FromArgb(r, g, b));


                        harfsayaci++;
                        sayac = 0;
                    }
                    sayac++;
              
                    if (harfsayaci == sifre.Length)
                    {
                      
                        pictureBox1.Image = goruntu;
                        btn_sifrele.Text = "Şifrelendi";
                        pixel = goruntu.GetPixel(goruntu.Width - 3, goruntu.Height - 1);
                        int r = (pixel.R - pixel.R % 10);
                        int g = (pixel.G - pixel.G % 10);
                        int b = (pixel.B - pixel.B % 10);

                        if(r > 240)
                        {
                            r -= 10;
                        }

                        if(g > 240)
                        {
                            g -= 10;
                        }

                        if (b > 240)
                        {
                            b -= 10;
                        }


                        goruntu.SetPixel(goruntu.Width - 3, goruntu.Height - 1, Color.FromArgb(r + sifre.Length / 100, g + sifre.Length / 10, b + sifre.Length % 10));
                        goruntu.Save("C:\\Users\\zeuss\\OneDrive\\Masaüstü\\gonderilecek.png", ImageFormat.Png);
                        return;
                    }
                }

            }

          
          


        }

        public Bitmap CreateNonIndexedImage(Image src)
        {
            Bitmap newBmp = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics gfx = Graphics.FromImage(newBmp))
            {
                gfx.DrawImage(src, 0, 0);
            }

            return newBmp;
        }


    }
}