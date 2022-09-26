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
    public partial class SanatciEkle : Form
    {
        int sanatciID=0;
        public SanatciEkle(int ID)
        {
            sanatciID = ID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ulkeID = int.Parse(cbUlke.SelectedItem.ToString().Split('-')[0].Trim());
            if (sanatciID==0)
            {
                Sanatci yeniKayit = new Sanatci();
                yeniKayit.Adi = tbAdi.Text;
                yeniKayit.Soyadi = tbSoyadi.Text;
                yeniKayit.UlkeID = ulkeID;
                Vt.db.Sanatcilar.Add(yeniKayit);
                MessageBox.Show("Kayıt başarılı!");
            }
            else
            {
                Sanatci aranan = Vt.db.Sanatcilar.Find(sanatciID);
                aranan.Adi = tbAdi.Text;
                aranan.Soyadi = tbSoyadi.Text;
                aranan.UlkeID = ulkeID;
                MessageBox.Show("Güncelleme başarılı!");
            }
            Vt.db.SaveChanges();
            this.Close();
        }

        private void SanatciEkle_Load(object sender, EventArgs e)
        {
            cbUlke.Items.AddRange(Vt.UlkeGetir());
            cbUlke.SelectedIndex = 0;
            if (sanatciID!=0)
            {
                button1.Text = "Güncelle";
                Sanatci aranan = Vt.db.Sanatcilar.Find(sanatciID);
                if (aranan==null)
                {
                    MessageBox.Show("Bir hata oluştu, sanatçı bulunamad.");
                    this.Close();
                }
                else
                {
                    tbAdi.Text = aranan.Adi;
                    tbSoyadi.Text = aranan.Soyadi;
                }
            }
            

        }
    }
}
