namespace MuzikDosyam_Prolab3
{
    partial class EnCokDinlenenler
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
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtTablo = new System.Windows.Forms.DataGridView();
            this.cbUlke = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTur
            // 
            this.cbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(51, 6);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(97, 21);
            this.cbTur.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tür";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtTablo
            // 
            this.dtTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTablo.Location = new System.Drawing.Point(12, 70);
            this.dtTablo.Name = "dtTablo";
            this.dtTablo.Size = new System.Drawing.Size(532, 302);
            this.dtTablo.TabIndex = 3;
            // 
            // cbUlke
            // 
            this.cbUlke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUlke.FormattingEnabled = true;
            this.cbUlke.Location = new System.Drawing.Point(366, 6);
            this.cbUlke.Name = "cbUlke";
            this.cbUlke.Size = new System.Drawing.Size(97, 21);
            this.cbUlke.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ülke";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Görüntüle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "TOP 10";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Genel Top 10";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EnCokDinlenenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtTablo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUlke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTur);
            this.MaximumSize = new System.Drawing.Size(580, 419);
            this.MinimumSize = new System.Drawing.Size(580, 419);
            this.Name = "EnCokDinlenenler";
            this.Text = "Top 10";
            this.Load += new System.EventHandler(this.EnCokDinlenenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtTablo;
        private System.Windows.Forms.ComboBox cbUlke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}