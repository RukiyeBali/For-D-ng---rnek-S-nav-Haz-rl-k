using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dongu_ornekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstNotlar.Items.Clear();
            Random rnd=new Random();

            for (int i = 1; i <= 40; i++)
            {
               lstNotlar.Items.Add(rnd.Next(1, 101));
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstKalanlar.Items.Clear();
            lstGecenler.Items.Clear();
            int not;
            int gecenSayisi = 0;
            int kalanSayisi = 0;
            int tesekkurSayisi = 0;
            int takdirSayisi = 0;
            int duzGecen = 0;

            int enYuksekPuan = 0;

            int enDusukPuan = 100;

            double sinifToplam = 0;
            double sinifOrtalama=0;





            for(int i = 0; i < lstNotlar.Items.Count; i++)
            {
                not = Convert.ToInt32(lstNotlar.Items[i]);

                if (not >= 50)
                {
                    lstGecenler.Items.Add(not);
                    gecenSayisi++;
                }
                else
                {
                    lstKalanlar.Items.Add(not);
                    kalanSayisi++;
                }
                if(not>=70 && not < 85)
                {
                    tesekkurSayisi++;
                }
                if (not >= 85)
                {
                    takdirSayisi++;
                }
                if (not>=50&& not < 70)
                {
                    duzGecen++;
                }


                if (not > enYuksekPuan)
                {
                    enYuksekPuan = not;
                }

                if (not < enDusukPuan)
                {
                    enDusukPuan = not;
                }



                sinifToplam += not;




            }










            label3.Text = "Geçen: " + gecenSayisi;
            label4.Text="Kalan: " + kalanSayisi;
            label5.Text = "Teşekkür Belgesi: " + tesekkurSayisi;
            label6.Text = "Takdir Belgesi. " + takdirSayisi;
            label7.Text = "Belge Almadan Geçen: " + duzGecen;
            label8.Text = "En Yüksek Not: " + enYuksekPuan;
            label9.Text = "En Düşük Not: " + enDusukPuan;
            label10.Text = "Sınıf Ortalaması: " + sinifOrtalama;



        }
    }
}
