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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
        void Yenile()
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
                             }).ToList();
            dtTablo.DataSource = bs;
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = (from r in Vt.db.Sanatcilar
                              select new
                              {
                                  ID = r.Id,
                                  Adı = r.Adi,
                                  Soyadı = r.Soyadi
                              }).ToList();
            dtSanatci.DataSource = bs2;
            BindingSource bs3 = new BindingSource();
            bs3.DataSource = (from r in Vt.db.Albumler
                              select new
                              {
                                  ID = r.AlbumID,
                                  Albüm_Adı = r.AlbumAdi,
                                  Çıkış_Tarihi = r.Tarih
                              }).ToList();
            dbAlbumler.DataSource = bs3;
        }
        private void Yonetici_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SarkiEkle(0).ShowDialog();
            Yenile();
        }
        int sarkiID = 0;
        private void dtTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
                sarkiID = int.Parse(dtTablo.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
                sarkiID = 0;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (sarkiID != 0)
            {
                new SarkiEkle(sarkiID).ShowDialog();
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
                Yenile();
            }
            else MessageBox.Show("Bir şarkı seçiniz.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (sarkiID != 0)
            {
                Sarki silinecek = Vt.db.Sarkilar.Find(sarkiID);
                if (silinecek == null)
                {
                    MessageBox.Show("Geçerli bir şarkı seçiniz.");
                }
                else
                {
                    Vt.db.Sarkilar.Remove(silinecek);
                }
                Vt.db.SaveChanges();
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
                Yenile();
            }
            else MessageBox.Show("Bir şarkı seçiniz.");
        }

        private void Yonetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new SanatciEkle(0).ShowDialog();
            Yenile();
        }
        int sanatciID = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int sanatciID = int.Parse(dtSanatci.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.sanatciID = sanatciID;
                btnSanatciGuncelle.Enabled = true;
                btnSanatciSil.Enabled = true;
                BindingSource bs2 = new BindingSource();
                bs2.DataSource = (from r in Vt.db.Sarkilar
                                  where (r.SanatciID == sanatciID)
                                  select new
                                  {
                                      ID = r.SarkiID,
                                      Şarkı_Adı = r.Adi,
                                      Tür = r.Tur.TurAdi,
                                      Süre = r.Sure,
                                      Sanatçı = r.Sanatci.Adi + " " + r.Sanatci.Soyadi,
                                      Dinlenme_Sayısı = r.DinlenmeSayisi,
                                      Çıkış_Tarihi = r.Tarih
                                  }).ToList();
                dtSarki.DataSource = bs2;
            }
            catch (Exception)
            {
                dtSarki.Rows.Clear();
                dtSarki.Refresh();
                this.sanatciID = 0;
                btnSanatciGuncelle.Enabled = false;
                btnSanatciSil.Enabled = false;
            }
        }

        private void btnSanatciGuncelle_Click(object sender, EventArgs e)
        {
            if (sanatciID != 0)
            {
                new SanatciEkle(sanatciID).ShowDialog();
                btnSanatciGuncelle.Enabled = false;
                btnSanatciSil.Enabled = false;
                Yenile();
            }
            else MessageBox.Show("Bir Sanatçı seçiniz.");
        }
        private void btnSanatciSil_Click(object sender, EventArgs e)
        {

            if (sanatciID != 0)
            {
                Sanatci silinecek = Vt.db.Sanatcilar.Find(sanatciID);
                if (silinecek == null)
                {
                    MessageBox.Show("Geçerli bir sanatçı seçiniz.");
                }
                else
                {
                    Vt.db.Sanatcilar.Remove(silinecek);
                }
                Vt.db.SaveChanges();
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
                sanatciID = 0;
                Yenile();
            }
            else MessageBox.Show("Bir Sanatçı seçiniz.");
        }
        int albumID;
        private void button2_Click(object sender, EventArgs e)
        {
            new AlbumEkle(0).ShowDialog();
            Yenile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AlbumEkle(albumID).ShowDialog();
            Yenile();
            AlbumBilgisiGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (albumID != 0)
            {
                Album silinecek = Vt.db.Albumler.Find(albumID);
                if (silinecek == null)
                {
                    MessageBox.Show("Geçerli bir albüm seçiniz.");
                }
                else
                {
                    Vt.db.Albumler.Remove(silinecek);
                }
                Vt.db.SaveChanges();
                btnAlbumGuncelle.Enabled = false;
                btnAlbumSil.Enabled = false;
                albumID = 0;
                Yenile();
            }
            else MessageBox.Show("Bir Albüm seçiniz.");
            AlbumBilgisiGoster();
        }
        void AlbumBilgisiGoster()
        {
            if (albumID==0)
            {
                dtAlbumSarkilar.Rows.Clear();
                dtSanatciAlbum.Rows.Clear();
                dtAlbumSarkilar.Refresh();
                dtSanatciAlbum.Refresh();
            }
            else
            {
                Album secilenAlbum = Vt.db.Albumler.Find(albumID);
                if (secilenAlbum!=null)
                {
                    BindingSource bs2 = new BindingSource();
                    bs2.DataSource = (from r in secilenAlbum.AlbumSarkilari
                                      select new
                                      {
                                          ID = r.SarkiID,
                                          Şarkı_Adı = r.Sarki.Adi,
                                          Tür = r.Sarki.Tur.TurAdi,
                                          Süre = r.Sarki.Sure,
                                          Sanatçı = r.Sarki.Sanatci.Adi + " " + r.Sarki.Sanatci.Soyadi,
                                          Dinlenme_Sayısı = r.Sarki.DinlenmeSayisi,
                                          Çıkış_Tarihi = r.Sarki.Tarih
                                      }).ToList();
                    dtAlbumSarkilar.DataSource = bs2;
                    BindingSource bs3 = new BindingSource();
                    bs3.DataSource = (from r in secilenAlbum.AlbumSanatcilari
                                      select new
                                      {
                                          ID = r.Sanatci.Id,
                                          Adı = r.Sanatci.Adi,
                                          Soyadı= r.Sanatci.Soyadi,
                                          Ülke = r.Sanatci.Ulke.UlkeAdi
                                      }).ToList();
                    dtSanatciAlbum.DataSource = bs3;
                }
            }
        }
        private void dbAlbumler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAlbumGuncelle.Enabled = true;
                btnAlbumSil.Enabled = true;
                albumID = int.Parse(dbAlbumler.Rows[e.RowIndex].Cells[0].Value.ToString());
                AlbumBilgisiGoster();
            }
            catch (Exception ex)
            {
                btnAlbumGuncelle.Enabled = false;
                btnAlbumSil.Enabled = false;
                albumID = 0;
            }
        }
        int sarkiSilID=0;
        private void dtAlbumSarkilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSarkiCikar.Enabled = true;
                sarkiSilID = int.Parse(dtAlbumSarkilar.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                btnSarkiCikar.Enabled = false;
                sarkiSilID = 0;
            }
        }

        private void btnSarkiCikar_Click(object sender, EventArgs e)
        {
            if (sarkiSilID != 0)
            {
                AlbumSarki silinecek = Vt.db.AlbumSarkilari.Find(sarkiSilID);
                Album secilen = Vt.db.Albumler.Find(albumID);
                if (silinecek != null && secilen != null)
                {
                    secilen.AlbumSarkilari.Remove(silinecek);
                    MessageBox.Show("Şarkı, albümden çıkarıld.");
                    Vt.db.SaveChanges();
                    sarkiSilID = 0;
                    AlbumBilgisiGoster();
                }
                else MessageBox.Show("Bir hata oluştu, doğru seçim yaptığınıza emin olun.");
            }
            else MessageBox.Show("Bir şarkı seçiniz.");
        }
        int sanatciSilID=0;
        private void btnSanatciCikar_Click(object sender, EventArgs e)
        {
            if (sanatciSilID != 0)
            {
                AlbumSanatci silinecek = Vt.db.AlbumSanatcilari.Find(sanatciSilID);
                Album secilen = Vt.db.Albumler.Find(albumID);
                if (silinecek != null && secilen != null)
                {
                    List<AlbumSarki> sanatciSarkilari = secilen.AlbumSarkilari.Where(x => x.Sarki.SanatciID == sanatciSilID).ToList();
                    foreach (AlbumSarki item in sanatciSarkilari)
                    {
                        secilen.AlbumSarkilari.Remove(item);
                    }
                    secilen.AlbumSanatcilari.Remove(silinecek);
                    MessageBox.Show("Sanatçı ve şarkıları albümden çıkarıld.");
                    Vt.db.SaveChanges();
                    btnSanatciCikar.Enabled = false;
                    sanatciSilID = 0;
                    AlbumBilgisiGoster();
                }
                else MessageBox.Show("Bir hata oluştu, doğru seçim yaptığınıza emin olun.");
            }
            else MessageBox.Show("Bir şarkı seçiniz.");
        }

        private void dtSanatciAlbum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSanatciCikar.Enabled = true;
                sanatciSilID = int.Parse(dtSanatciAlbum.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                btnSanatciCikar.Enabled = false;
                sanatciSilID = 0;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
