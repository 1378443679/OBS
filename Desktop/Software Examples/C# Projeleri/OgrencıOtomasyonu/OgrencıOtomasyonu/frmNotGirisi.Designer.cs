namespace OgrencıOtomasyonu
{
    partial class frmNotGirisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBolumListe = new System.Windows.Forms.ComboBox();
            this.cmbTCKimlikNoListe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.msktxtVize = new System.Windows.Forms.MaskedTextBox();
            this.msktxtFinal = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölüm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vize:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(34, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ortalama:";
            // 
            // cmbBolumListe
            // 
            this.cmbBolumListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolumListe.FormattingEnabled = true;
            this.cmbBolumListe.Items.AddRange(new object[] {
            "Bilgisayar",
            "Elektronik",
            "Elektrik",
            "Makina\t",
            "İnşaat",
            "Enerji",
            "Maden",
            "Yazılım",
            "Haberleşme",
            "Ziraat"});
            this.cmbBolumListe.Location = new System.Drawing.Point(209, 56);
            this.cmbBolumListe.Name = "cmbBolumListe";
            this.cmbBolumListe.Size = new System.Drawing.Size(293, 33);
            this.cmbBolumListe.TabIndex = 7;
            this.cmbBolumListe.TextChanged += new System.EventHandler(this.cmbBolumListe_TextChanged);
            // 
            // cmbTCKimlikNoListe
            // 
            this.cmbTCKimlikNoListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTCKimlikNoListe.FormattingEnabled = true;
            this.cmbTCKimlikNoListe.Location = new System.Drawing.Point(209, 107);
            this.cmbTCKimlikNoListe.Name = "cmbTCKimlikNoListe";
            this.cmbTCKimlikNoListe.Size = new System.Drawing.Size(293, 33);
            this.cmbTCKimlikNoListe.TabIndex = 8;
            this.cmbTCKimlikNoListe.TextChanged += new System.EventHandler(this.cmbTCKimlikNoListe_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(204, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 9;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(204, 170);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 25);
            this.lblAdSoyad.TabIndex = 10;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.Location = new System.Drawing.Point(204, 341);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(0, 25);
            this.lblOrtalama.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(209, 411);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(219, 75);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // msktxtVize
            // 
            this.msktxtVize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtVize.Location = new System.Drawing.Point(209, 222);
            this.msktxtVize.Mask = "000";
            this.msktxtVize.Name = "msktxtVize";
            this.msktxtVize.Size = new System.Drawing.Size(293, 30);
            this.msktxtVize.TabIndex = 13;
            // 
            // msktxtFinal
            // 
            this.msktxtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtFinal.Location = new System.Drawing.Point(209, 278);
            this.msktxtFinal.Mask = "000";
            this.msktxtFinal.Name = "msktxtFinal";
            this.msktxtFinal.Size = new System.Drawing.Size(293, 30);
            this.msktxtFinal.TabIndex = 14;
            // 
            // frmNotGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(534, 586);
            this.Controls.Add(this.msktxtFinal);
            this.Controls.Add(this.msktxtVize);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTCKimlikNoListe);
            this.Controls.Add(this.cmbBolumListe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNotGirisi";
            this.Text = "frmNotGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBolumListe;
        private System.Windows.Forms.ComboBox cmbTCKimlikNoListe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox msktxtVize;
        private System.Windows.Forms.MaskedTextBox msktxtFinal;
    }
}