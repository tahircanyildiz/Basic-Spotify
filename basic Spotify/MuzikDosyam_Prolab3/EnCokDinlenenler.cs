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
    public partial class EnCokDinlenenler : Form
    {
        public EnCokDinlenenler()
        {
            InitializeComponent();
        }

        private void EnCokDinlenenler_Load(object sender, EventArgs e)
        {
            cbTur.Items.AddRange(Vt.TurGetir());
            cbUlke.Items.AddRange(Vt.UlkeGetir());
            cbTur.SelectedIndex = 0;
            cbUlke.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tur = cbTur.SelectedItem.ToString().Split('-')[1].Trim();
            BindingSource bs = new BindingSource();
            bs.DataSource = (from r in Vt.db.Sarkilar where r.Tur.TurAdi==tur
                             select new
                             {
                                 ID = r.SarkiID,
                                 Şarkı_Adı = r.Adi,
                                 Tür = r.Tur.TurAdi,
                                 Süre = r.Sure,
                                 Sanatçı = r.Sanatci.Adi + " " + r.Sanatci.Soyadi,
                                 Dinlenme_Sayısı = r.DinlenmeSayisi,
                                 Çıkış_Tarihi = r.Tarih
                             }).Take(10).OrderByDescending(x=>x.Dinlenme_Sayısı).ToList();
            dtTablo.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ulkeadi = cbUlke.SelectedItem.ToString().Split('-')[1].Trim();
            BindingSource bs = new BindingSource();
            bs.DataSource = (from r in Vt.db.Sarkilar where r.Sanatci.Ulke.UlkeAdi == ulkeadi
                             select new
                             {
                                 ID = r.SarkiID,
                                 Şarkı_Adı = r.Adi,
                                 Tür = r.Tur.TurAdi,
                                 Süre = r.Sure,
                                 Sanatçı = r.Sanatci.Adi + " " + r.Sanatci.Soyadi,
                                 Dinlenme_Sayısı = r.DinlenmeSayisi,
                                 Çıkış_Tarihi = r.Tarih
                             }).Take(10).ToList().OrderByDescending(x => x.Dinlenme_Sayısı);
            dtTablo.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = (from r in Vt.db.Sarkilar
                             select new
                             {
                                 ID = r.SarkiID,
                                 Şarkı_Adı = r.Adi,
                                 Tür = r.Tur.TurAdi,
                                 Süre = r.Sure,
                                 Sanatçı = r.Sanatci.Adi + " " + r.Sanatci.Soyadi,
                                 Dinlenme_Sayısı = r.DinlenmeSayisi,
                                 Çıkış_Tarihi = r.Tarih
                             }).Take(10).ToList().OrderByDescending(x => x.Dinlenme_Sayısı);
            dtTablo.DataSource = bs;
        }
    }
}
