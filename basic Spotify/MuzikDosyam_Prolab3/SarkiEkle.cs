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
    public partial class SarkiEkle : Form
    {
        int sarkiID;
        public SarkiEkle(int id)
        {
            sarkiID = id;
            InitializeComponent();
        }

        private void SarkiEkle_Load(object sender, EventArgs e)
        {
            cbSanatci.Items.AddRange(Vt.SanatciGetir());
            cbTur.Items.AddRange(Vt.TurGetir());
            try
            {
                cbTur.SelectedIndex = 0;
                cbSanatci.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde hiç sanatçı yok.");
                this.Close();
            }
            if (sarkiID!=0)
            {
                button1.Text = "Güncelle";
                Sarki aranan = Vt.db.Sarkilar.Find(sarkiID);
                if (aranan == null)
                {
                    MessageBox.Show("Bir hata oluştu, şarkı bilgisi bulunamadı.");
                    this.Close();
                }
                else
                {
                    tbSarkiAdi.Text = aranan.Adi;
                    tbSure.Value = decimal.Parse(aranan.Sure.ToString());
                    dtCikisTarihi.Value = (DateTime)aranan.Tarih;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int turID = int.Parse(cbTur.SelectedItem.ToString().Split('-')[0].Trim());
            int sanatciID = int.Parse(cbSanatci.SelectedItem.ToString().Split('-')[0].Trim());
            if (sarkiID!=0)
            {
                Sarki aranan = Vt.db.Sarkilar.Find(sarkiID);
                if (aranan == null)
                {
                    MessageBox.Show("Bir hata oluştu, şarkı bilgisi bulunamadı.");
                    this.Close();
                }
                else
                {
                    aranan.Adi = tbSarkiAdi.Text;
                    aranan.TurID = turID;
                    aranan.SanatciID = sanatciID;
                    aranan.Sure = (int)tbSure.Value;
                    aranan.Tarih = dtCikisTarihi.Value;
                }
            }
            else
            {
                Sarki yeniSarki = new Sarki();
                yeniSarki.Adi = tbSarkiAdi.Text;
                yeniSarki.TurID = turID;
                yeniSarki.SanatciID = sanatciID;
                yeniSarki.Sure = (int)tbSure.Value;
                yeniSarki.Tarih = dtCikisTarihi.Value;
                yeniSarki.DinlenmeSayisi = 0;
                Vt.db.Sarkilar.Add(yeniSarki);
                MessageBox.Show("İşlem başarılı");
            }
            Vt.db.SaveChanges();
            this.Close();
        }
    }
}
