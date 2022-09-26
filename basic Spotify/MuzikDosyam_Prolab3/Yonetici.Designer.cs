namespace MuzikDosyam_Prolab3
{
    partial class Yonetici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtTablo = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtSarki = new System.Windows.Forms.DataGridView();
            this.dtSanatci = new System.Windows.Forms.DataGridView();
            this.btnSanatciSil = new System.Windows.Forms.Button();
            this.btnSanatciGuncelle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSarkiCikar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtSanatciAlbum = new System.Windows.Forms.DataGridView();
            this.dtAlbumSarkilar = new System.Windows.Forms.DataGridView();
            this.dbAlbumler = new System.Windows.Forms.DataGridView();
            this.btnSanatciCikar = new System.Windows.Forms.Button();
            this.btnAlbumSil = new System.Windows.Forms.Button();
            this.btnAlbumGuncelle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTablo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSarki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSanatci)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSanatciAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlbumSarkilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAlbumler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.dtTablo);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Şarkı İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(8, 359);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(897, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Şarkı Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtTablo
            // 
            this.dtTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTablo.Location = new System.Drawing.Point(8, 6);
            this.dtTablo.Name = "dtTablo";
            this.dtTablo.Size = new System.Drawing.Size(895, 347);
            this.dtTablo.TabIndex = 6;
            this.dtTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTablo_CellContentClick);
            this.dtTablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTablo_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(8, 417);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(897, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Seçili Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(8, 388);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(897, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Seçili Kaydı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dtSarki);
            this.tabPage2.Controls.Add(this.dtSanatci);
            this.tabPage2.Controls.Add(this.btnSanatciSil);
            this.tabPage2.Controls.Add(this.btnSanatciGuncelle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sanatçı İşlemleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şarkıları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sanatçılar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(895, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sanatçı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtSarki
            // 
            this.dtSarki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSarki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSarki.Location = new System.Drawing.Point(374, 23);
            this.dtSarki.Name = "dtSarki";
            this.dtSarki.Size = new System.Drawing.Size(529, 330);
            this.dtSarki.TabIndex = 10;
            // 
            // dtSanatci
            // 
            this.dtSanatci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSanatci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSanatci.Location = new System.Drawing.Point(8, 26);
            this.dtSanatci.Name = "dtSanatci";
            this.dtSanatci.Size = new System.Drawing.Size(360, 330);
            this.dtSanatci.TabIndex = 10;
            this.dtSanatci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtSanatci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSanatciSil
            // 
            this.btnSanatciSil.Enabled = false;
            this.btnSanatciSil.Location = new System.Drawing.Point(8, 417);
            this.btnSanatciSil.Name = "btnSanatciSil";
            this.btnSanatciSil.Size = new System.Drawing.Size(895, 23);
            this.btnSanatciSil.TabIndex = 8;
            this.btnSanatciSil.Text = "Seçili Kaydı Sil";
            this.btnSanatciSil.UseVisualStyleBackColor = true;
            this.btnSanatciSil.Click += new System.EventHandler(this.btnSanatciSil_Click);
            // 
            // btnSanatciGuncelle
            // 
            this.btnSanatciGuncelle.Enabled = false;
            this.btnSanatciGuncelle.Location = new System.Drawing.Point(8, 388);
            this.btnSanatciGuncelle.Name = "btnSanatciGuncelle";
            this.btnSanatciGuncelle.Size = new System.Drawing.Size(895, 23);
            this.btnSanatciGuncelle.TabIndex = 9;
            this.btnSanatciGuncelle.Text = "Seçili Kaydı Güncelle";
            this.btnSanatciGuncelle.UseVisualStyleBackColor = true;
            this.btnSanatciGuncelle.Click += new System.EventHandler(this.btnSanatciGuncelle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnSarkiCikar);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.dtSanatciAlbum);
            this.tabPage3.Controls.Add(this.dtAlbumSarkilar);
            this.tabPage3.Controls.Add(this.dbAlbumler);
            this.tabPage3.Controls.Add(this.btnSanatciCikar);
            this.tabPage3.Controls.Add(this.btnAlbumSil);
            this.tabPage3.Controls.Add(this.btnAlbumGuncelle);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(911, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Albüm İşlemleri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sanatçılar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Albüm İçeriği";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Albümler";
            // 
            // btnSarkiCikar
            // 
            this.btnSarkiCikar.Enabled = false;
            this.btnSarkiCikar.Location = new System.Drawing.Point(367, 359);
            this.btnSarkiCikar.Name = "btnSarkiCikar";
            this.btnSarkiCikar.Size = new System.Drawing.Size(442, 23);
            this.btnSarkiCikar.TabIndex = 17;
            this.btnSarkiCikar.Text = "Seçilen Şarkıyı Çıkar";
            this.btnSarkiCikar.UseVisualStyleBackColor = true;
            this.btnSarkiCikar.Click += new System.EventHandler(this.btnSarkiCikar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Albüm Oluştur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtSanatciAlbum
            // 
            this.dtSanatciAlbum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSanatciAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSanatciAlbum.Location = new System.Drawing.Point(313, 225);
            this.dtSanatciAlbum.Name = "dtSanatciAlbum";
            this.dtSanatciAlbum.Size = new System.Drawing.Size(585, 128);
            this.dtSanatciAlbum.TabIndex = 15;
            this.dtSanatciAlbum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSanatciAlbum_CellContentClick);
            this.dtSanatciAlbum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSanatciAlbum_CellContentClick);
            // 
            // dtAlbumSarkilar
            // 
            this.dtAlbumSarkilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAlbumSarkilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlbumSarkilar.Location = new System.Drawing.Point(313, 30);
            this.dtAlbumSarkilar.Name = "dtAlbumSarkilar";
            this.dtAlbumSarkilar.Size = new System.Drawing.Size(590, 166);
            this.dtAlbumSarkilar.TabIndex = 15;
            this.dtAlbumSarkilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAlbumSarkilar_CellContentClick);
            this.dtAlbumSarkilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAlbumSarkilar_CellContentClick);
            // 
            // dbAlbumler
            // 
            this.dbAlbumler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbAlbumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbAlbumler.Location = new System.Drawing.Point(8, 30);
            this.dbAlbumler.Name = "dbAlbumler";
            this.dbAlbumler.Size = new System.Drawing.Size(294, 323);
            this.dbAlbumler.TabIndex = 16;
            this.dbAlbumler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbAlbumler_CellContentClick);
            this.dbAlbumler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbAlbumler_CellContentClick);
            // 
            // btnSanatciCikar
            // 
            this.btnSanatciCikar.Enabled = false;
            this.btnSanatciCikar.Location = new System.Drawing.Point(367, 388);
            this.btnSanatciCikar.Name = "btnSanatciCikar";
            this.btnSanatciCikar.Size = new System.Drawing.Size(442, 23);
            this.btnSanatciCikar.TabIndex = 14;
            this.btnSanatciCikar.Text = "Seçilen Sanatçıyı Çıar";
            this.btnSanatciCikar.UseVisualStyleBackColor = true;
            this.btnSanatciCikar.Click += new System.EventHandler(this.btnSanatciCikar_Click);
            // 
            // btnAlbumSil
            // 
            this.btnAlbumSil.Enabled = false;
            this.btnAlbumSil.Location = new System.Drawing.Point(3, 417);
            this.btnAlbumSil.Name = "btnAlbumSil";
            this.btnAlbumSil.Size = new System.Drawing.Size(294, 23);
            this.btnAlbumSil.TabIndex = 13;
            this.btnAlbumSil.Text = "Seçilen Albümü Sil";
            this.btnAlbumSil.UseVisualStyleBackColor = true;
            this.btnAlbumSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAlbumGuncelle
            // 
            this.btnAlbumGuncelle.Enabled = false;
            this.btnAlbumGuncelle.Location = new System.Drawing.Point(3, 388);
            this.btnAlbumGuncelle.Name = "btnAlbumGuncelle";
            this.btnAlbumGuncelle.Size = new System.Drawing.Size(294, 23);
            this.btnAlbumGuncelle.TabIndex = 14;
            this.btnAlbumGuncelle.Text = "Albümü Düzenle";
            this.btnAlbumGuncelle.UseVisualStyleBackColor = true;
            this.btnAlbumGuncelle.Click += new System.EventHandler(this.button4_Click);
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 474);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(935, 513);
            this.MinimumSize = new System.Drawing.Size(935, 513);
            this.Name = "Yonetici";
            this.Text = "Yonetici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Yonetici_FormClosing);
            this.Load += new System.EventHandler(this.Yonetici_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTablo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSarki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSanatci)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSanatciAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlbumSarkilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAlbumler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dtTablo;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtSanatci;
        private System.Windows.Forms.Button btnSanatciSil;
        private System.Windows.Forms.Button btnSanatciGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtSarki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtAlbumSarkilar;
        private System.Windows.Forms.DataGridView dbAlbumler;
        private System.Windows.Forms.Button btnAlbumSil;
        private System.Windows.Forms.Button btnAlbumGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtSanatciAlbum;
        private System.Windows.Forms.Button btnSarkiCikar;
        private System.Windows.Forms.Button btnSanatciCikar;
    }
}