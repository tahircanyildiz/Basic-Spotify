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
    public partial class Profil : Form
    {
        Kullanici aktifKullanici;
        Kullanici hedef;
        public Profil(Kullanici aktifKullanici,Kullanici hedef)
        {
            this.aktifKullanici = aktifKullanici;
            this.hedef = hedef;
            InitializeComponent();
        }
        void Yenile()
        {
            foreach (CalmaListesi item in hedef.CalmaListeleri)
            {
                if (item.Tur.TurAdi == "Pop")
                {
                    popliste.Items.Add(item.Id + " - " + item.Sarki.Adi);
                }
                else if (item.Tur.TurAdi == "Jazz")
                {
                    jazliste.Items.Add(item.Id + " - " + item.Sarki.Adi);
                }
                else
                {
                    klasikliste.Items.Add(item.Id + " - " + item.Sarki.Adi);
                }
            }
        }
        private void Profil_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = hedef.KullaniciAdi + " Adlı Kullanıcının Çalma Listesi";
            Yenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SarkiEkle(jazliste))
            {
                MessageBox.Show("Şarkı listenize başarıyla eklendi.");
            }
            else MessageBox.Show("Bu şarkı zaten listenizde var.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SarkiEkle(popliste))
            {
                MessageBox.Show("Şarkı listenize başarıyla eklendi.");
            }
            else MessageBox.Show("Bu şarkı zaten listenizde var.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SarkiEkle(klasikliste))
            {
                MessageBox.Show("Şarkı listenize başarıyla eklendi.");
            }
            else MessageBox.Show("Bu şarkı zaten listenizde var.");
        }
        bool SarkiEkle(ListBox listbox)
        {
            if (listbox.SelectedIndex >= 0)
            {
                int id = int.Parse(listbox.SelectedItem.ToString().Split('-')[0].Trim());
                CalmaListesi liste = hedef.CalmaListeleri.Where(x => x.Id == id).FirstOrDefault();
                bool ekle = true;
                foreach (CalmaListesi cl in aktifKullanici.CalmaListeleri)
                {
                    if (cl.SarkiID == liste.SarkiID)
                    {
                        ekle = false;
                        break;
                    }
                }
                if (ekle)
                {
                    CalmaListesi yeni = new CalmaListesi();
                    yeni.SarkiID = liste.SarkiID;
                    yeni.TurID = liste.Sarki.TurID;
                    yeni.Tur = liste.Sarki.Tur;
                    yeni.KullaniciID = aktifKullanici.KullaniciID;
                    aktifKullanici.CalmaListeleri.Add(yeni);
                    Vt.db.SaveChanges();
                    aktifKullanici = Vt.db.Kullanicilar.Find(aktifKullanici.KullaniciID);
                }
                return ekle;
            }
            else return false;
        }
        void TumunuEkle(ListBox listbox)
        {
            foreach (string sarki in listbox.Items)
            {
                int id = int.Parse(sarki.Split('-')[0].Trim());
                CalmaListesi liste = hedef.CalmaListeleri.Where(x => x.Id == id).FirstOrDefault();
                bool ekle = true;
                foreach (CalmaListesi cl in aktifKullanici.CalmaListeleri)
                {
                    if (cl.SarkiID == liste.SarkiID)
                    {
                        ekle = false;
                        break;
                    }
                }
                if (ekle)
                {
                    MessageBox.Show(sarki + "Eklendi");
                    CalmaListesi yeni = new CalmaListesi();
                    yeni.SarkiID = liste.SarkiID;
                    yeni.TurID = liste.Sarki.TurID;
                    yeni.Tur = liste.Sarki.Tur;
                    yeni.KullaniciID = aktifKullanici.KullaniciID;
                    aktifKullanici.CalmaListeleri.Add(yeni);
                }
            }
            Vt.db.SaveChanges();
            aktifKullanici = Vt.db.Kullanicilar.Find(aktifKullanici.KullaniciID);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (jazliste.Items.Count>0)
            {
                TumunuEkle(jazliste);
                MessageBox.Show("Jazz listesindeki tüm şarkılar listenize eklendi.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (popliste.Items.Count > 0)
            {
                TumunuEkle(popliste);
                MessageBox.Show("Pop listesindeki tüm şarkılar listenize eklendi.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (klasikliste.Items.Count > 0)
            {
                TumunuEkle(klasikliste);
                MessageBox.Show("Klasik listesindeki tüm şarkılar listenize eklendi.");
            }
        }
    }
}
