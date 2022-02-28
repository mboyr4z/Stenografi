using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SiberGuvenlikProje
{

    public enum Renkler
    {
        R,
        G,
        B
    }
    public partial class Alici : Form
    {
        string baglanilacakIP = "";


        


        public Alici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sifreUzunluk;
            Renkler WhichRGB;
            Bitmap goruntu = new Bitmap(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\gelenResim.png");
            //pictureBox1.Image = goruntu;
            int yukseklik = goruntu.Height, genislik = goruntu.Width;
           // cikti.al(yukseklik.ToString() + " " + genislik.ToString());

            Color sonPixel = goruntu.GetPixel(genislik - 1, yukseklik - 1);
            int kacHanedeBirSifrelenecek = (sonPixel.R % 5) + 1;

            //cikti.al(sonPixel.ToString());

            Color sonBirPixel = goruntu.GetPixel(genislik - 2, yukseklik - 1);
            int HangiRGB = (sonBirPixel.G % 3);

            switch (HangiRGB)
            {
                case 0:
                    WhichRGB = Renkler.R;
                    break;
                case 1:
                    WhichRGB = Renkler.G;
                    break;

                case 2:
                    WhichRGB = Renkler.B;
                    break;
                default:
                    WhichRGB = Renkler.R;
                    break;
            }


            Color sondanIkinciPixel = goruntu.GetPixel(genislik - 3, yukseklik - 1);
            sifreUzunluk = (sondanIkinciPixel.R % 10 * 100) + (sondanIkinciPixel.G % 10 * 10) + (sondanIkinciPixel.B % 10);
            sifreKir(goruntu, sifreUzunluk, WhichRGB, kacHanedeBirSifrelenecek);


        }

        private void sifreKir(Bitmap goruntu, int sifreUzunluk, Renkler WhichRGB, int kacHanedeBirSifrelenecek)
        {
            int sayac = 0;
            int harfSayaci = 0;
            Color pixel;
            int sifreDegeri;
            string cozulmusSifre = "";
            int ascii;

            cikti.al("sifreUzunluk :  " + sifreUzunluk);
            cikti.al("whichRGB :  " + WhichRGB);
            cikti.al("Kac Hanede :  " + kacHanedeBirSifrelenecek.ToString());

            for (int i = 0; i < goruntu.Height; i++)
            {
                for (int j = 0; j < goruntu.Width; j++)
                {

                    if(sayac % kacHanedeBirSifrelenecek == 0)
                    {
                        pixel = goruntu.GetPixel(j,i);
                        cikti.al(pixel.ToString());
                        

                        switch (WhichRGB)       // hangi renk koduna göre sifreDegeri belli olur
                        {
                            case Renkler.R:
                                sifreDegeri = pixel.R ;
                                break;
                            case Renkler.G:
                                sifreDegeri = pixel.G;
                                break;
                            case Renkler.B:
                                sifreDegeri = pixel.B;
                                break;
                            default:
                                sifreDegeri = pixel.R;
                                break;
                        }
                        sifreDegeri %= 37;

                        if (sifreDegeri >= 0 && sifreDegeri <= 25)       // harftir
                        {
                            ascii = sifreDegeri +  97;
                        }

                        else if (sifreDegeri >= 26 && sifreDegeri <= 35)      // sayı
                        {
                            ascii = sifreDegeri + (48 - 26);       // 
                        }   
                        else{       // SPACE TUŞU
                            ascii = 32;
                        }


                        char harf = (char)ascii;

                     
                        cozulmusSifre += harf;
                      

                        sayac = 0;
                        harfSayaci++;
                    }



                    if (harfSayaci == sifreUzunluk)
                    {
                        txt_cozulmusSifre.Text = cozulmusSifre;
                        return; 
                    }
                    sayac++;
                }
            }
        }





        private void btn_baglan_Click(object sender, EventArgs e)
        {
            baglanilacakIP = textBox2.Text;
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(baglanilacakIP), 9999); //gönderen kisi ipsi
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                client.Connect(iep);

                
                    
                        // receive data
                        byte[] buffer = new byte[1000000];
                        client.Receive(buffer, buffer.Length, SocketFlags.None);
                        Console.WriteLine("Receive success");

                        File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\gelenResim.png", buffer);
                              
                
                pictureBox1.Image = new Bitmap(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\gelenResim.png");
            }

        }

       
    }
}
