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
    public partial class KayitForm : Form
    {

        public KayitForm()
        {
            InitializeComponent();
        }

        private void KayitForm_Load(object sender, EventArgs e)
        {
            cbAbone.Items.AddRange(Vt.AbonelikGetir());
            cbUlke.Items.AddRange(Vt.UlkeGetir());
            cbAbone.SelectedIndex = 0;
            cbUlke.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbKadi.Text!=""&&tbSifre.Text!=""&&tbSifreTekrar.Text!="")
            {
                if (tbSifre.Text!=tbSifreTekrar.Text)
                {
                    MessageBox.Show("Girilen şifreler uyuşmuyor!");
                }
                else
                {
                    Kullanici kullanici = new Kullanici();
                    int abonelik = int.Parse(cbAbone.SelectedItem.ToString().Split('-')[0].Trim());
                    int ulke = int.Parse(cbUlke.SelectedItem.ToString().Split('-')[0].Trim());
                    kullanici.UlkeID = ulke;
                    kullanici.AbonelikTuru = abonelik;
                    kullanici.KullaniciAdi = tbKadi.Text;
                    kullanici.Sifre = tbSifre.Text;
                    kullanici.Email = tbEposta.Text;
                    kullanici.Odendimi = 0;
                    Vt.db.Kullanicilar.Add(kullanici);
                    Vt.db.SaveChanges();
                    MessageBox.Show("Kaydınız başarıyla oluşturuldu!");
                    this.Close();
                }
            }
        }

        private void KayitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vt.db.SaveChanges();
        }

        private void tbSifre_TextChanged(object sender, EventArgs e)
        {
            tbSifre.PasswordChar = '*';
        }

        private void tbSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            tbSifreTekrar.PasswordChar = '*';
        }
    }
}
