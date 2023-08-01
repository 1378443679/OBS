namespace OgrencıOtomasyonu
{
    partial class frmKayitSilme
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
            this.msktxtTCKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKayitSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(236, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // msktxtTCKimlikNo
            // 
            this.msktxtTCKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtTCKimlikNo.Location = new System.Drawing.Point(402, 24);
            this.msktxtTCKimlikNo.Mask = "00000000000";
            this.msktxtTCKimlikNo.Name = "msktxtTCKimlikNo";
            this.msktxtTCKimlikNo.Size = new System.Drawing.Size(216, 30);
            this.msktxtTCKimlikNo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(984, 459);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitSil.Location = new System.Drawing.Point(402, 76);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(181, 45);
            this.btnKayitSil.TabIndex = 5;
            this.btnKayitSil.Text = "Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // frmKayitSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1020, 598);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.msktxtTCKimlikNo);
            this.Controls.Add(this.label1);
            this.Name = "frmKayitSilme";
            this.Text = "Kayit Silme";
            this.Load += new System.EventHandler(this.frmKayitSilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxtTCKimlikNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKayitSil;
    }
}