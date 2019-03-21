using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cstech
{
    public partial class OyunMain : Form
    {
        int oyunsira;
        int tutulansayi = 0;
        int basamaksayisi = 4;
        int[] tutulanrakamlar = new int[4] { -1, -1, -1, -1 };
        Dictionary<int, char[]> ornekuzay = new Dictionary<int, char[]>();
        public OyunMain()
        {
            InitializeComponent();
        }
        
        private void OyunMain_Load(object sender, EventArgs e)
        {
            ekranhazirla(1);
            ornekuzayolustur();
            oyunsira = 1;
            sayitut();
        }

        private void btnio_Click(object sender, EventArgs e)
        {
            try
            {
                if (oyunsira == 1)
                {
                    int val = Convert.ToInt32(nudio.Value);
                    if (val < 1233 || val > 9876)
                    {
                        MessageBox.Show("Sayı doğru aralıklarda değil. Lütfen rakamları farklı 4 basamaklı sayı giriniz.");
                        return;
                    }
                    kulsira();
                    oyunsira = 2;
                    ekranhazirla(2);
                    nudio.Value = Convert.ToDecimal(sayisoyle(null));


                }
                else
                {

                    if (nudPuanim.Value == 4)
                    {
                        MessageBox.Show("Kazandım");
                        Application.Restart();
                    }
                    else
                    {
                        int deger = Convert.ToInt32(nudio.Value);
                        int eksideger = Math.Abs(Convert.ToInt32(nudeksi.Value));
                        
                        int artideger = Math.Abs(Convert.ToInt32(nudPuanim.Value));
                        if ( eksideger>4 || artideger>4)
                        {
                            MessageBox.Show("4 den büyük puan veremezsiniz.");
                            return;
                        }
                        string a = deger.ToString().Substring(0, 1) + deger.ToString().Substring(2);
                        kombinasyoncikar(deger, eksideger, artideger);
                        oyunsira = 1;
                        ekranhazirla(1);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Restart();
            }


        }
        /// <summary>
        /// Olabilecek tüm örneklemlerden örnek uzay çıkartıyor.
        /// </summary>
        private void ornekuzayolustur()
        {
            for (int i = 1234; i < 9877; i++)
            {
                char[] basamakdegerler = i.ToString().ToCharArray();
                int ekle = 1;
                foreach (char item in basamakdegerler)
                {

                    if (basamakdegerler.Count(a => a.Equals(item)) > 1)
                    {
                        ekle = 0;
                        break;
                    }
                }
                if (ekle == 1)
                {
                    ornekuzay.Add(i, i.ToString().ToCharArray());
                }


            }

        }
        /// <summary>
        /// Örnek Uzayda eleme yapıyor
        /// </summary>
        /// <param name="verilensayi">kullanıcının tahmini </param>
        /// <param name="eksipuan">kullanıcının verdigi eksi puan</param>
        /// <param name="artipuan">kullanıcının verdiği artı puan</param>
        private void kombinasyoncikar(int verilensayi, int eksipuan, int artipuan)
        {
            int toplamdogru = artipuan + eksipuan;
            char[] verilensayichararray = verilensayi.ToString().ToCharArray();
            ornekuzay.Remove(verilensayi);
            if (artipuan > 0)
            {
                switch (artipuan)
                {
                    case 1:
                        ornekuzay = ornekuzay.Where(x => x.Value[0] == verilensayichararray[0] || x.Value[1] == verilensayichararray[1] || x.Value[2] == verilensayichararray[2] || x.Value[3] == verilensayichararray[3]).ToDictionary(a => a.Key, b => b.Value);
                        break;
                    case 2:
                        ornekuzay = ornekuzay.Where(x => (x.Value[0] == verilensayichararray[0] && x.Value[1] == verilensayichararray[1]) || (x.Value[0] == verilensayichararray[0] && x.Value[2] == verilensayichararray[2]) || (x.Value[0] == verilensayichararray[0] && x.Value[3] == verilensayichararray[3]) || (x.Value[1] == verilensayichararray[1] && x.Value[2] == verilensayichararray[2]) || (x.Value[1] == verilensayichararray[1] && x.Value[3] == verilensayichararray[3]) || (x.Value[2] == verilensayichararray[2] && x.Value[3] == verilensayichararray[3])).ToDictionary(a => a.Key, b => b.Value);
                        break;
                    case 3:
                        ornekuzay = ornekuzay.Where(x => (x.Value[0] == verilensayichararray[0] && x.Value[1] == verilensayichararray[1] && x.Value[2] == verilensayichararray[2]) || (x.Value[1] == verilensayichararray[1] && x.Value[2] == verilensayichararray[2] && x.Value[3] == verilensayichararray[3]) || (x.Value[0] == verilensayichararray[0] && x.Value[2] == verilensayichararray[2] && x.Value[3] == verilensayichararray[3]) || (x.Value[0] == verilensayichararray[0] && x.Value[1] == verilensayichararray[1] && x.Value[3] == verilensayichararray[3])).ToDictionary(a => a.Key, b => b.Value);
                        break;
                    default:
                        break;
                }
            }
            if (eksipuan > 0)
            {
                switch (eksipuan)
                {
                    case 1:
                        ornekuzay = ornekuzay.Where(x => (
                        x.Value[0] != verilensayichararray[0] &&
                        (x.Key.ToString().Substring(1).ToCharArray().Contains(verilensayichararray[0])))
                        ||
                        (x.Value[1] != verilensayichararray[1] &&
                        ((x.Key.ToString().Substring(0, 1) + x.Key.ToString().Substring(2)).ToCharArray().Contains(verilensayichararray[1])))
                        ||
                        (x.Value[2] != verilensayichararray[2] &&
                        ((x.Key.ToString().Substring(0, 2) + x.Key.ToString().Substring(3)).ToCharArray().Contains(verilensayichararray[2])))
                        ||
                        (x.Value[3] != verilensayichararray[3] &&
                        ((x.Key.ToString().Substring(0, 3)).ToCharArray().Contains(verilensayichararray[3])))).ToDictionary(a => a.Key, b => b.Value);
                        break;
                    case 2:
                        ornekuzay = ornekuzay.Where(x =>
                        (x.Value[0] != verilensayichararray[0] &&
                        x.Value[1] != verilensayichararray[1] &&
                        x.Key.ToString().Substring(1).ToCharArray().Contains(verilensayichararray[0]) &&
                        (x.Key.ToString().Substring(0, 1) + x.Key.ToString().Substring(2)).ToCharArray().Contains(verilensayichararray[1])
                        )
                        ||
                        (x.Value[0] != verilensayichararray[0] &&
                        x.Value[2] != verilensayichararray[2] &&
                        x.Key.ToString().Substring(1).ToCharArray().Contains(verilensayichararray[0]) &&
                        (x.Key.ToString().Substring(0, 2) + x.Key.ToString().Substring(3)).ToCharArray().Contains(verilensayichararray[2])
                        )
                        ||

                        (x.Value[0] != verilensayichararray[0] &&
                        x.Value[3] != verilensayichararray[3] &&
                        x.Key.ToString().Substring(1).ToCharArray().Contains(verilensayichararray[0]) &&
                        (x.Key.ToString().Substring(0, 3)).ToCharArray().Contains(verilensayichararray[3]))
                        ||
                        (x.Value[1] != verilensayichararray[1] &&
                        x.Value[2] != verilensayichararray[2] &&
                        (x.Key.ToString().Substring(0, 1) + x.Key.ToString().Substring(2)).ToCharArray().Contains(verilensayichararray[1]) &&
                        (x.Key.ToString().Substring(0, 2) + x.Key.ToString().Substring(3)).ToCharArray().Contains(verilensayichararray[2]))
                        ||
                        (x.Value[1] != verilensayichararray[1] &&
                        x.Value[3] != verilensayichararray[3] &&
                        (x.Key.ToString().Substring(0, 1) + x.Key.ToString().Substring(2)).ToCharArray().Contains(verilensayichararray[1]) &&
                        (x.Key.ToString().Substring(0, 3)).ToCharArray().Contains(verilensayichararray[3]))
                        ||
                        (x.Value[2] != verilensayichararray[2] &&
                        x.Value[3] != verilensayichararray[3] &&
                        (x.Key.ToString().Substring(0, 2) + x.Key.ToString().Substring(3)).ToCharArray().Contains(verilensayichararray[2]) &&
                        (x.Key.ToString().Substring(0, 3)).ToCharArray().Contains(verilensayichararray[3]))
                        ).ToDictionary(a => a.Key, b => b.Value);
                        break;
                    case 3:
                        ornekuzay = ornekuzay.Where(x => (
                         (x.Value[0] != verilensayichararray[0] &&
                         x.Value[1] != verilensayichararray[1] &&
                         x.Value[2] != verilensayichararray[2] &&
                         x.Key.ToString().Substring(1).ToCharArray().Contains(verilensayichararray[0]) &&
                         (x.Key.ToString().Substring(0, 1) + x.Key.ToString().Substring(2)).ToCharArray().Contains(verilensayichararray[1]) &&
                         (x.Key.ToString().Substring(0, 2) + x.Key.ToString().Substring(3)).ToCharArray().Contains(verilensayichararray[2]))
                         ||
                         (x.Value[0] != verilensayichararray[0] &&
                         x.Value[2] != verilensayichararray[2] &&
                         x.Value[3] != verilensayichararray[3] &&
                         x.Key.ToString().Substring(1).ToCharArray().Contains(verilensayichararray[0]) &&
                         (x.Key.ToString().Substring(0, 2) + x.Key.ToString().Substring(3)).ToCharArray().Contains(verilensayichararray[2]) &&
                         x.Key.ToString().Substring(0, 3).ToCharArray().Contains(verilensayichararray[3]))
                         ||
                         (x.Value[1] != verilensayichararray[1] &&
                         x.Value[2] != verilensayichararray[2] &&
                         x.Value[3] != verilensayichararray[3] &&
                         (x.Key.ToString().Substring(0, 1) + x.Key.ToString().Substring(2)).ToCharArray().Contains(verilensayichararray[1]) &&
                         (x.Key.ToString().Substring(0, 2) + x.Key.ToString().Substring(3)).ToCharArray().Contains(verilensayichararray[2]) &&
                         x.Key.ToString().Substring(0, 3).ToCharArray().Contains(verilensayichararray[3])
                         ) ||
                         (x.Value[0] != verilensayichararray[0] &&
                         x.Value[1] != verilensayichararray[1] &&
                         x.Value[3] != verilensayichararray[3] &&
                         x.Key.ToString().Substring(1).ToCharArray().Contains(verilensayichararray[0]) &&
                         (x.Key.ToString().Substring(0, 1) + x.Key.ToString().Substring(2)).ToCharArray().Contains(verilensayichararray[1]) &&
                         x.Key.ToString().Substring(0, 3).ToCharArray().Contains(verilensayichararray[3])
                         ))).ToDictionary(a => a.Key, b => b.Value);
                        break;

                    case 4:
                        ornekuzay=ornekuzay.Where(x=>(
                        x.Value[0]!= verilensayichararray[0] &&
                        x.Value[1] != verilensayichararray[1] &&
                        x.Value[2] != verilensayichararray[2] &&
                        x.Value[3] != verilensayichararray[3] &&
                        x.Key.ToString().Substring(1).ToCharArray().Contains(verilensayichararray[0]) &&
                        (x.Key.ToString().Substring(0,1)+ x.Key.ToString().Substring(2)).ToCharArray().Contains(verilensayichararray[1]) &&
                        (x.Key.ToString().Substring(0, 2) + x.Key.ToString().Substring(3)).ToCharArray().Contains(verilensayichararray[2]) &&
                        (x.Key.ToString().Substring(0, 3)).ToCharArray().Contains(verilensayichararray[3])
                        )).ToDictionary(a => a.Key, b => b.Value);
                        break;
                    default:
                        break;
                }
            }
            //if (toplamdogru == 0)
            //{
            //    return;
            //}
            //else if (toplamdogru > 0)
            //{
            //    if (artipuan>0)
            //    {

            //    }
            //    //int carpim = 1;
            //    ////foreach (var charitem in verilensayichararray)
            //    ////{
            //    ////    int deger = int.Parse(charitem.ToString());
            //    ////    if (deger>0)
            //    ////    {
            //    ////        carpim = carpim * deger;
            //    ////    }

            //    ////}
            //    //var list = ornekuzaybolunebilirlik.Where(x => x.Value % verilensayichararray[0]> 0 || x.Value % verilensayichararray[1] > 0 || x.Value % verilensayichararray[2] > 0 || x.Value % verilensayichararray[3] > 0).ToList();
            //    //foreach (var item in list)
            //    //{
            //    //    ornekuzaybolunebilirlik.Remove(item.Key);
            //    //}

            //}


        }
        /// <summary>
        /// Tahmin edilecek bir sonraki sayıyı getirir. Örnek uzaydan rasgele bir sayı getirir.
        /// </summary>
        /// <param name="say">Özellikle belirtilmesi istenen sayı varsa doldurulur yoksa null değeri geçilmelidir.</param>
        /// <returns></returns>
        private int sayisoyle(int? say)
        {
            if (say.HasValue)
            {
                return say.Value;
            }
            Random rdm = new Random();
            int deger = rdm.Next(0, ornekuzay.Count);
            return ornekuzay.ElementAt(deger).Key;


        }
        /// <summary>
        /// Bilgisayarın sayı tutması sağlanır sadece başlangıçta çalışacak.
        /// </summary>
        private void sayitut()
        {

            if (ornekuzay.Count<=0)
            {
                MessageBox.Show("Olası bir sayı kalmadı sayıdan emin misiniz?");
                Application.Restart();
                return;
            }
            for (int i = 0; i < basamaksayisi; i++)
            {
                int gelensayi = 0;
                Random rdm = new Random();
                if (i == 0)
                {
                    gelensayi = rdm.Next(1, 9);


                }
                else
                {
                    gelensayi = rdm.Next(0, 9);
                    int index = Array.IndexOf(tutulanrakamlar, gelensayi);
                    while (index >= 0)
                    {
                        gelensayi = rdm.Next(0, 9);
                        index = Array.IndexOf(tutulanrakamlar, gelensayi);
                    }

                }
                tutulansayi += Convert.ToInt32(gelensayi * Math.Pow(10, basamaksayisi - i - 1));

                tutulanrakamlar[i] = gelensayi;
            }

        }
        /// <summary>
        /// Sıra kullanıcı iken yapılan işlemler
        /// </summary>
        private void kulsira()
        {

            int tahmin = Convert.ToInt32(nudio.Value);
            if (tahmin == tutulansayi)
            {
                MessageBox.Show("Bildiniz");
            }
            else
            {
                int kulpuanarti = 0;
                int kulpuaneksi = 0;
                char[] tahimedilenca = tahmin.ToString().ToCharArray();
                char[] tutulansayica = tutulansayi.ToString().ToCharArray();
                for (int i = 0; i < tutulansayica.Length; i++)
                {
                    if (tahimedilenca[i]==tutulansayica[i])
                    {
                        kulpuanarti++;
                    }
                    else
                    {
                        if (tahimedilenca.Contains(tutulansayica[i]))
                        {
                            kulpuaneksi--;
                        }
                    }
                }
                MessageBox.Show($"Puanınız artı değeri {kulpuanarti.ToString() } eksi değeri {kulpuaneksi.ToString()}");
            }
        }
        /// <summary>
        /// Sıra PC'de iken yapılan işlemler
        /// </summary>
        private void pcsira()
        {



        }
        /// <summary>
        /// Ekranın hazırlanmasını sağlayan method
        /// </summary>
        /// <param name="gelensira">Sıra hangi tarafa geçti</param>
        private void ekranhazirla(int gelensira)
        {
            if (gelensira == 1)
            {
                lblSira.Text = "Tahmin edin";
                lblAciklama.Text = "Rakamları farklı 4 basamaklı sayı tuttum.Tahmininiz?";
                btnio.Text = "Doğrula";
                nudio.Enabled = true;
                nudio.Value = 0;
                nudeksi.Value = 0;
                nudPuanim.Value = 0;
                lblPuanim.Visible = false;
                nudPuanim.Visible = false;
                
                nudeksi.Visible = false;
                lbleksi.Visible = false;
            }
            else
            {
                lblSira.Text = "Sıra Bende";
                lblAciklama.Text = "Tahimn Ettiğim sayı";
                nudio.Enabled = false;
                btnio.Text = "Doğru";
                lblPuanim.Visible = true;
                nudPuanim.Visible = true;
                
                nudeksi.Visible = true;
                lbleksi.Visible = true;
            }

        }

    }
}
