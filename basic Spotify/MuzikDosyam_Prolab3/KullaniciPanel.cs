using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikDosyam_Prolab3
{
    public partial class KullaniciPanel : Form
    {
        Kullanici kullanici;
        public KullaniciPanel(Kullanici kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
        }
        void Yenile()
        {
            Vt.db.SaveChanges();
            takipPanel.Controls.Clear();
            takipEdilenPanel.Controls.Clear();
            List<Kullanici> takipEdilenler = new List<Kullanici>();
            foreach (Takipci takipedilen in kullanici.TakipEdilenler)
            {
                takipEdilenler.Add(takipedilen.TakipEden);
            }
            foreach (Kullanici uye in Vt.db.Kullanicilar)
            {
                if (kullanici!=uye&&uye.AbonelikTuru==2&&!takipEdilenler.Contains(uye))
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(takipPanel.Width, 50);
                    panel.Parent = takipPanel;
                    Button btn = new Button();
                    btn.Parent = panel;
                    btn.Text = "Takip Et";
                    btn.Size = new Size(150, 50);
                    btn.Location = new Point(150,0);
                    btn.Font = label1.Font;
                    btn.Name = uye.KullaniciID.ToString();
                    btn.Click += Btn_Click;
                    Label lbl = new Label();
                    lbl.Text = uye.KullaniciAdi;
                    lbl.Font = label1.Font;
                    lbl.Parent = panel;
                    lbl.Size = new Size(200,50);
                    lbl.Location = new Point(0, 0);
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                }
                else if (uye.AbonelikTuru == 2 && kullanici != uye)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(takipEdilenPanel.Width, 50);
                    panel.Parent = takipEdilenPanel;
                    Button btn = new Button();
                    btn.Parent = panel;
                    btn.Text = "Takipten Çık";
                    btn.Size = new Size(100, 50);
                    btn.Location = new Point(100, 0);
                    btn.Font = label1.Font;
                    btn.Click += Btn_Click1;
                    btn.Name = uye.KullaniciID.ToString();
                    Button btn2 = new Button();
                    btn2.Parent = panel;
                    btn2.Text = "Profili Görüntüle";
                    btn2.Size = new Size(100, 50);
                    btn2.Location = new Point(200, 0);
                    btn2.Font = label1.Font;
                    btn2.Name = uye.KullaniciID.ToString()+"_";
                    btn2.Click += Btn2_Click;
                    Label lbl = new Label();
                    lbl.Text = uye.KullaniciAdi;
                    lbl.Font = label1.Font;
                    lbl.Parent = panel;
                    lbl.Size = new Size(150, 50);
                    lbl.Location = new Point(0, 0);
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                }
            }
            sarkiliste.Items.Clear();
            string[] sarkilar = Vt.SarkiGetir();
            bool ekle;
            foreach (string sarki in sarkilar)
            {
                int id = int.Parse(sarki.Split('-')[0].Trim());
                ekle = true;
                foreach (CalmaListesi liste in kullanici.CalmaListeleri)
                {
                    if (id == liste.SarkiID)
                    {
                        ekle = false;
                        break;
                    }
                }
                if (ekle)
                {
                    sarkiliste.Items.Add(sarki);
                }
            }
            jazliste.Items.Clear();
            popliste.Items.Clear();
            klasikliste.Items.Clear();
            foreach (CalmaListesi item in kullanici.CalmaListeleri)
            {
                if (item.Tur.TurAdi=="Pop")
                {
                    popliste.Items.Add(item.Id + " - " + item.Sarki.Adi);
                }
                else if (item.Tur.TurAdi== "Jazz")
                {
                    jazliste.Items.Add(item.Id + " - " + item.Sarki.Adi);
                }
                else
                {
                    klasikliste.Items.Add(item.Id + " - " + item.Sarki.Adi);
                }
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            int kullaniciID = int.Parse(((Button)sender).Name.Replace("_",string.Empty));
            Kullanici diger = Vt.db.Kullanicilar.Find(kullaniciID);
            new Profil(kullanici, diger).ShowDialog();
            Yenile();
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            int kullaniciID = int.Parse(((Button)sender).Name);
            Kullanici takipEdilen = Vt.db.Kullanicilar.Find(kullaniciID);
            Takipci takip = Vt.db.Takipciler.Where(x => x.TakipedilenID== kullanici.KullaniciID && x.TakipedenID==kullaniciID).FirstOrDefault();
            takipEdilen.Takipciler.Remove(takip);
            kullanici.TakipEdilenler.Remove(takip);
            Yenile();
            kullanici = Vt.db.Kullanicilar.Find(kullanici.KullaniciID);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int kullaniciID = int.Parse(((Button)sender).Name);
            Kullanici takipEdilecek = Vt.db.Kullanicilar.Find(kullaniciID);
            Takipci takip = new Takipci();
            takip.TakipedilenID=kullaniciID;
            takip.TakipedenID = kullanici.KullaniciID;
            kullanici.TakipEdilenler.Add(takip);
            takipEdilecek.Takipciler.Add(takip);
            Vt.db.Takipciler.Add(takip);
            Yenile();
            kullanici = Vt.db.Kullanicilar.Find(kullanici.KullaniciID);
        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            Yenile();
            kullanici = Vt.db.Kullanicilar.Find(kullanici.KullaniciID);
        }

        private void KullaniciPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vt.db.SaveChanges();
            new Form1().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sarkiliste.SelectedIndex>=0)
            {
                int sarkiID = int.Parse(sarkiliste.SelectedItem.ToString().Split('-')[0].Trim());
                Sarki sarki = Vt.db.Sarkilar.Find(sarkiID);
                if (sarki!=null)
                {
                    CalmaListesi yeni = new CalmaListesi();
                    yeni.SarkiID = sarkiID;
                    yeni.TurID = sarki.TurID;
                    yeni.Tur = sarki.Tur;
                    yeni.KullaniciID = kullanici.KullaniciID;
                    kullanici.CalmaListeleri.Add(yeni);
                    Yenile();
                    kullanici = Vt.db.Kullanicilar.Find(kullanici.KullaniciID);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jazliste.SelectedIndex>=0)
            {
                int id = int.Parse(jazliste.SelectedItem.ToString().Split('-')[0].Trim());
                kullanici.CalmaListeleri.Remove(kullanici.CalmaListeleri.Where(x => x.Id == id).FirstOrDefault());
                Yenile();
                kullanici = Vt.db.Kullanicilar.Find(kullanici.KullaniciID);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (popliste.SelectedIndex >= 0)
            {
                int id = int.Parse(popliste.SelectedItem.ToString().Split('-')[0].Trim());
                kullanici.CalmaListeleri.Remove(kullanici.CalmaListeleri.Where(x => x.Id == id).FirstOrDefault());
                Yenile();
                kullanici = Vt.db.Kullanicilar.Find(kullanici.KullaniciID);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (klasikliste.SelectedIndex >= 0)
            {
                int id = int.Parse(klasikliste.SelectedItem.ToString().Split('-')[0].Trim());
                kullanici.CalmaListeleri.Remove(kullanici.CalmaListeleri.Where(x => x.Id == id).FirstOrDefault());
                Yenile();
                kullanici = Vt.db.Kullanicilar.Find(kullanici.KullaniciID);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jazliste.SelectedIndex >= 0)
            {
                int id = int.Parse(jazliste.SelectedItem.ToString().Split('-')[0].Trim());
                CalmaListesi cl = Vt.db.CalmaListeleri.Find(id);
                Vt.db.Sarkilar.Find(cl.SarkiID).DinlenmeSayisi++;
                MessageBox.Show(jazliste.SelectedItem.ToString().Split('-')[1].Trim() + " Şarkısını dinlediniz.");
                Yenile();
                kullanici = Vt.db.Kullanicilar.Find(kullanici.KullaniciID);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (klasikliste.SelectedIndex >= 0)
            {
                int id = int.Parse(klasikliste.SelectedItem.ToString().Split('-')[0].Trim());
                Vt.db.Sarkilar.Find(Vt.db.CalmaListeleri.Find(id).SarkiID).DinlenmeSayisi++;
                MessageBox.Show(klasikliste.SelectedItem.ToString().Split('-')[1].Trim() + " Şarkısını dinlediniz.");
                Yenile();
                kullanici = Vt.db.Kullanicilar.Find(kullanici.KullaniciID);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (popliste.SelectedIndex >= 0)
            {
                int id = int.Parse(popliste.SelectedItem.ToString().Split('-')[0].Trim());
                Vt.db.Sarkilar.Find(Vt.db.CalmaListeleri.Find(id).SarkiID).DinlenmeSayisi++;
                MessageBox.Show(popliste.SelectedItem.ToString().Split('-')[1].Trim() + " Şarkısını dinlediniz.");
                Yenile();
                kullanici = Vt.db.Kullanicilar.Find(kullanici.KullaniciID);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new EnCokDinlenenler().ShowDialog();
        }

        private void ödemeYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanici.Odendimi = 1;
            MessageBox.Show("Ödemeniz alınmıştır.");
            Vt.db.SaveChanges();
        }
    }
}
