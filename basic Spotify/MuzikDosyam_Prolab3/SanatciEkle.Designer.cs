namespace MuzikDosyam_Prolab3
{
    partial class SanatciEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoyadi = new System.Windows.Forms.TextBox();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUlke = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSoyadi);
            this.groupBox1.Controls.Add(this.tbAdi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbUlke);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 149);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sanatçı Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // tbSoyadi
            // 
            this.tbSoyadi.Location = new System.Drawing.Point(108, 56);
            this.tbSoyadi.Name = "tbSoyadi";
            this.tbSoyadi.Size = new System.Drawing.Size(100, 20);
            this.tbSoyadi.TabIndex = 1;
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(108, 30);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(100, 20);
            this.tbAdi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kayıt Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ülkesi";
            // 
            // cbUlke
            // 
            this.cbUlke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUlke.FormattingEnabled = true;
            this.cbUlke.Location = new System.Drawing.Point(108, 82);
            this.cbUlke.Name = "cbUlke";
            this.cbUlke.Size = new System.Drawing.Size(100, 21);
            this.cbUlke.TabIndex = 2;
            // 
            // SanatciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 168);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(274, 207);
            this.MinimumSize = new System.Drawing.Size(274, 207);
            this.Name = "SanatciEkle";
            this.Text = "Sanatçı Ekle";
            this.Load += new System.EventHandler(this.SanatciEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoyadi;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUlke;
    }
}