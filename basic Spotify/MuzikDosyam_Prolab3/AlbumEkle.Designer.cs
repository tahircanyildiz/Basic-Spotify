namespace MuzikDosyam_Prolab3
{
    partial class AlbumEkle
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
            this.tbAlbumAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSanatcilar = new System.Windows.Forms.ListBox();
            this.lbEklenecekSanatcilar = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSarkilar = new System.Windows.Forms.ListBox();
            this.lbEklenecekSarkilar = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAlbumAdi
            // 
            this.tbAlbumAdi.Location = new System.Drawing.Point(175, 27);
            this.tbAlbumAdi.Name = "tbAlbumAdi";
            this.tbAlbumAdi.Size = new System.Drawing.Size(100, 20);
            this.tbAlbumAdi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Albüm Adı";
            // 
            // cbTur
            // 
            this.cbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(175, 53);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(100, 21);
            this.cbTur.TabIndex = 1;
            this.cbTur.SelectedIndexChanged += new System.EventHandler(this.cbTur_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Albüm Türü";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(175, 80);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(100, 20);
            this.dtTarih.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbSanatcilar);
            this.groupBox2.Controls.Add(this.lbEklenecekSanatcilar);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 184);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sanatçı Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sanatçılar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Eklenecek Sanatçılar";
            // 
            // lbSanatcilar
            // 
            this.lbSanatcilar.FormattingEnabled = true;
            this.lbSanatcilar.Location = new System.Drawing.Point(14, 50);
            this.lbSanatcilar.Name = "lbSanatcilar";
            this.lbSanatcilar.Size = new System.Drawing.Size(120, 121);
            this.lbSanatcilar.TabIndex = 5;
            this.lbSanatcilar.SelectedIndexChanged += new System.EventHandler(this.lbSanatcilar_SelectedIndexChanged);
            // 
            // lbEklenecekSanatcilar
            // 
            this.lbEklenecekSanatcilar.FormattingEnabled = true;
            this.lbEklenecekSanatcilar.Location = new System.Drawing.Point(262, 50);
            this.lbEklenecekSanatcilar.Name = "lbEklenecekSanatcilar";
            this.lbEklenecekSanatcilar.Size = new System.Drawing.Size(120, 121);
            this.lbEklenecekSanatcilar.TabIndex = 5;
            this.lbEklenecekSanatcilar.SelectedIndexChanged += new System.EventHandler(this.lbEklenecekSanatcilar_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(160, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbSarkilar);
            this.groupBox1.Controls.Add(this.lbEklenecekSarkilar);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 184);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şarkı Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seçilen Sanatçılara Ait Şarkılar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Eklenecek Şarkılar";
            // 
            // lbSarkilar
            // 
            this.lbSarkilar.FormattingEnabled = true;
            this.lbSarkilar.Location = new System.Drawing.Point(14, 50);
            this.lbSarkilar.Name = "lbSarkilar";
            this.lbSarkilar.Size = new System.Drawing.Size(120, 121);
            this.lbSarkilar.TabIndex = 5;
            // 
            // lbEklenecekSarkilar
            // 
            this.lbEklenecekSarkilar.FormattingEnabled = true;
            this.lbEklenecekSarkilar.Location = new System.Drawing.Point(262, 50);
            this.lbEklenecekSarkilar.Name = "lbEklenecekSarkilar";
            this.lbEklenecekSarkilar.Size = new System.Drawing.Size(120, 121);
            this.lbEklenecekSarkilar.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AlbumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAlbumAdi);
            this.MaximumSize = new System.Drawing.Size(447, 586);
            this.MinimumSize = new System.Drawing.Size(447, 586);
            this.Name = "AlbumEkle";
            this.Text = "Albüm Oluştur";
            this.Load += new System.EventHandler(this.AlbumEkle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAlbumAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbSanatcilar;
        private System.Windows.Forms.ListBox lbEklenecekSanatcilar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbSarkilar;
        private System.Windows.Forms.ListBox lbEklenecekSarkilar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}