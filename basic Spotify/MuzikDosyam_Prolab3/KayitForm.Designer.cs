namespace MuzikDosyam_Prolab3
{
    partial class KayitForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbKadi = new System.Windows.Forms.TextBox();
            this.tbSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUlke = new System.Windows.Forms.ComboBox();
            this.cbAbone = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kayit Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(201, 81);
            this.tbSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(132, 22);
            this.tbSifre.TabIndex = 1;
            this.tbSifre.TextChanged += new System.EventHandler(this.tbSifre_TextChanged);
            // 
            // tbKadi
            // 
            this.tbKadi.Location = new System.Drawing.Point(201, 49);
            this.tbKadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKadi.Name = "tbKadi";
            this.tbKadi.Size = new System.Drawing.Size(132, 22);
            this.tbKadi.TabIndex = 0;
            // 
            // tbSifreTekrar
            // 
            this.tbSifreTekrar.Location = new System.Drawing.Point(201, 113);
            this.tbSifreTekrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSifreTekrar.Name = "tbSifreTekrar";
            this.tbSifreTekrar.Size = new System.Drawing.Size(132, 22);
            this.tbSifreTekrar.TabIndex = 2;
            this.tbSifreTekrar.TextChanged += new System.EventHandler(this.tbSifreTekrar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre (Tekrar)";
            // 
            // tbEposta
            // 
            this.tbEposta.Location = new System.Drawing.Point(201, 145);
            this.tbEposta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEposta.Name = "tbEposta";
            this.tbEposta.Size = new System.Drawing.Size(132, 22);
            this.tbEposta.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Eposta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ülke";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Abonelik Türü";
            // 
            // cbUlke
            // 
            this.cbUlke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUlke.FormattingEnabled = true;
            this.cbUlke.Location = new System.Drawing.Point(201, 176);
            this.cbUlke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUlke.Name = "cbUlke";
            this.cbUlke.Size = new System.Drawing.Size(132, 24);
            this.cbUlke.TabIndex = 4;
            // 
            // cbAbone
            // 
            this.cbAbone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbone.FormattingEnabled = true;
            this.cbAbone.Location = new System.Drawing.Point(201, 208);
            this.cbAbone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAbone.Name = "cbAbone";
            this.cbAbone.Size = new System.Drawing.Size(132, 24);
            this.cbAbone.TabIndex = 5;
            // 
            // KayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 314);
            this.Controls.Add(this.cbAbone);
            this.Controls.Add(this.cbUlke);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSifreTekrar);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbEposta);
            this.Controls.Add(this.tbKadi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(478, 361);
            this.MinimumSize = new System.Drawing.Size(478, 361);
            this.Name = "KayitForm";
            this.Text = "Kayıt Ol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KayitForm_FormClosing);
            this.Load += new System.EventHandler(this.KayitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbKadi;
        private System.Windows.Forms.TextBox tbSifreTekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUlke;
        private System.Windows.Forms.ComboBox cbAbone;
    }
}