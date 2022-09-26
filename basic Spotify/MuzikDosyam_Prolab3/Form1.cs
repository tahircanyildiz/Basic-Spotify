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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici aranan = Vt.db.Kullanicilar.Where(x => x.KullaniciAdi == tbKadi.Text && x.Sifre == tbSifre.Text && x.Abonelik.AbonelikTuru == "Normal").FirstOrDefault();
            if (aranan!=null)
            {
                //Normal Giriş
                new KullaniciPanel(aranan).Show();
                this.Hide();
            }
            else
            {
                //Premium Giriş
                aranan = Vt.db.Kullanicilar.Where(x => x.KullaniciAdi == tbKadi.Text && x.Sifre == tbSifre.Text && x.Abonelik.AbonelikTuru == "Premium").FirstOrDefault();
                if (aranan!=null)
                {
                    new KullaniciPanel(aranan).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bu bilgilere ait kayıt bulunamadı.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kullanici aranan = Vt.db.Kullanicilar.Where(x => x.KullaniciAdi == tbYoneticiKadi.Text && x.Sifre == tbYoneticiSifre.Text && x.Abonelik.AbonelikTuru == "Admin").FirstOrDefault();
            if (aranan==null)
            {
                MessageBox.Show("Bu bilgilere ait yönetici kaydı bulunamadı.");
            }
            else
            {
                //Yönetici Girişi
                new Yonetici().Show();
                this.Hide();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vt.db.SaveChanges();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new KayitForm().ShowDialog();
        }

        private void tbSifre_TextChanged(object sender, EventArgs e)
        {
            tbSifre.PasswordChar = '*';
        }

        private void tbYoneticiSifre_TextChanged(object sender, EventArgs e)
        {
            tbYoneticiSifre.PasswordChar = '*';
        }
    }
}
