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
    public partial class AlbumEkle : Form
    {
        int albumID = 0;
        public AlbumEkle(int albumID)
        {
            this.albumID = albumID;
            InitializeComponent();
        }

        private void AlbumEkle_Load(object sender, EventArgs e)
        {
            cbTur.Items.AddRange(Vt.TurGetir());
            cbTur.SelectedIndex = 0;
            lbSanatcilar.Items.AddRange(Vt.SanatciGetir());
            if (albumID != 0)
            {
                Album aranan = Vt.db.Albumler.Find(albumID);
                if (aranan == null)
                {
                    MessageBox.Show("Albüm bulunamadı, bir hata oluştu.");
                    this.Close();
                }
                else
                {
                    tbAlbumAdi.Text = aranan.AlbumAdi;
                }
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void cbTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int turID = int.Parse(cbTur.SelectedItem.ToString().Split('-')[0].Trim());
            if (albumID == 0)
            {
                if (lbEklenecekSarkilar.Items.Count == 0 || lbEklenecekSanatcilar.Items.Count == 0)
                {
                    MessageBox.Show("Albüme en az 1 şarkı ve sanatçı eklemelisiniz.");
                }
                else if (tbAlbumAdi.Text == "")
                {
                    MessageBox.Show("Albüm adı giriniz.");
                }
                else
                {

                    Album album = new Album();
                    album.AlbumAdi = tbAlbumAdi.Text;
                    album.Tarih = dtTarih.Value;
                    album.TurID = turID;
                    foreach (object item in lbEklenecekSanatcilar.Items)
                    {
                        int sanatciID = int.Parse(item.ToString().Split('-')[0].Trim());
                        AlbumSanatci albumSanatci = new AlbumSanatci();
                        albumSanatci.Album = album;
                        albumSanatci.SanatciID = sanatciID;
                        album.AlbumSanatcilari.Add(albumSanatci);
                    }
                    foreach (object item in lbEklenecekSarkilar.Items)
                    {
                        int sarkiID = int.Parse(item.ToString().Split('-')[0].Trim());
                        AlbumSarki albumSarki = new AlbumSarki();
                        albumSarki.SarkiID = sarkiID;
                        albumSarki.Album = album;
                        album.AlbumSarkilari.Add(albumSarki);
                    }
                    Vt.db.Albumler.Add(album);
                    Vt.db.SaveChanges();
                    MessageBox.Show("Veriler kaydedildi.");
                    this.Close();
                }
            }
            else
            {
                Album aranan = Vt.db.Albumler.Find(albumID);
                if (aranan == null)
                {
                    MessageBox.Show("Albüm bulunamadı, bir hata oluştu.");
                    this.Close();
                }
                else
                {
                    aranan.AlbumAdi = tbAlbumAdi.Text;
                    aranan.Tarih = dtTarih.Value;
                    aranan.TurID = turID;
                    Vt.db.SaveChanges();
                    MessageBox.Show("Veriler kaydedildi.");
                    this.Close();
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lbEklenecekSanatcilar.SelectedIndex >= 0)
            {
                lbSanatcilar.Items.Add(lbEklenecekSanatcilar.SelectedItem);
                lbEklenecekSanatcilar.Items.Remove(lbEklenecekSanatcilar.SelectedItem);
            }

            lbSarkilar.Items.Clear();
            lbEklenecekSarkilar.Items.Clear();
            for (int i = 0; i < lbEklenecekSanatcilar.Items.Count; i++)
            {
                int sanatciID = int.Parse(lbEklenecekSanatcilar.Items[i].ToString().Split('-')[0].Trim());
                lbSarkilar.Items.AddRange(Vt.SanatciSarkisiGetir(sanatciID));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbSanatcilar.SelectedIndex >= 0)
            {
                lbEklenecekSanatcilar.Items.Add(lbSanatcilar.SelectedItem);
                lbSanatcilar.Items.Remove(lbSanatcilar.SelectedItem);
            }
            lbSarkilar.Items.Clear();
            lbEklenecekSarkilar.Items.Clear();
            for (int i = 0; i < lbEklenecekSanatcilar.Items.Count; i++)
            {
                int sanatciID = int.Parse(lbEklenecekSanatcilar.Items[i].ToString().Split('-')[0].Trim());
                lbSarkilar.Items.AddRange(Vt.SanatciSarkisiGetir(sanatciID));
            }
        }

        private void lbSanatcilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbEklenecekSanatcilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (lbSarkilar.SelectedIndex >= 0)
            {
                lbEklenecekSarkilar.Items.Add(lbSarkilar.SelectedItem);
                lbSarkilar.Items.Remove(lbSarkilar.SelectedItem);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (lbEklenecekSarkilar.SelectedIndex >= 0)
            {
                lbSarkilar.Items.Add(lbEklenecekSarkilar.SelectedItem);
                lbEklenecekSarkilar.Items.Remove(lbEklenecekSarkilar.SelectedItem);
            }

        }
    }
}
