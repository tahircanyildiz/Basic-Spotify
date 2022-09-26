namespace MuzikDosyam_Prolab3
{
    partial class SarkiEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSarkiAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSure = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSanatci = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSure)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSarkiAdi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSure);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSanatci);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtCikisTarihi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 201);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şarkı Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şarkı Adı";
            // 
            // tbSarkiAdi
            // 
            this.tbSarkiAdi.Location = new System.Drawing.Point(108, 30);
            this.tbSarkiAdi.Name = "tbSarkiAdi";
            this.tbSarkiAdi.Size = new System.Drawing.Size(100, 20);
            this.tbSarkiAdi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kayıt Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çıkış Tarihi";
            // 
            // tbSure
            // 
            this.tbSure.Location = new System.Drawing.Point(108, 109);
            this.tbSure.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tbSure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbSure.Name = "tbSure";
            this.tbSure.Size = new System.Drawing.Size(100, 20);
            this.tbSure.TabIndex = 3;
            this.tbSure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tür";
            // 
            // cbSanatci
            // 
            this.cbSanatci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanatci.FormattingEnabled = true;
            this.cbSanatci.Location = new System.Drawing.Point(108, 135);
            this.cbSanatci.Name = "cbSanatci";
            this.cbSanatci.Size = new System.Drawing.Size(100, 21);
            this.cbSanatci.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Süre (Saniye)";
            // 
            // cbTur
            // 
            this.cbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(108, 82);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(100, 21);
            this.cbTur.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sanatçı";
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Location = new System.Drawing.Point(108, 56);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(100, 20);
            this.dtCikisTarihi.TabIndex = 1;
            // 
            // SarkiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 220);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(269, 259);
            this.MinimumSize = new System.Drawing.Size(269, 259);
            this.Name = "SarkiEkle";
            this.Text = "Şarkı Kaydı";
            this.Load += new System.EventHandler(this.SarkiEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSarkiAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSanatci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
    }
}