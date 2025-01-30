namespace TechStok
{
    partial class frmUrunEkle
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
            this.txt_ParcaAdi = new System.Windows.Forms.TextBox();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TeknikDetaylar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_StokAdeti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_BirimFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Kategori = new System.Windows.Forms.ComboBox();
            this.btn_UrunEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parça Adı :";
            // 
            // txt_ParcaAdi
            // 
            this.txt_ParcaAdi.Location = new System.Drawing.Point(114, 64);
            this.txt_ParcaAdi.Name = "txt_ParcaAdi";
            this.txt_ParcaAdi.Size = new System.Drawing.Size(144, 22);
            this.txt_ParcaAdi.TabIndex = 1;
            // 
            // txt_Marka
            // 
            this.txt_Marka.Location = new System.Drawing.Point(114, 96);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(144, 22);
            this.txt_Marka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka :";
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(114, 128);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(144, 22);
            this.txt_Model.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model :";
            // 
            // txt_TeknikDetaylar
            // 
            this.txt_TeknikDetaylar.Location = new System.Drawing.Point(114, 224);
            this.txt_TeknikDetaylar.Multiline = true;
            this.txt_TeknikDetaylar.Name = "txt_TeknikDetaylar";
            this.txt_TeknikDetaylar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_TeknikDetaylar.Size = new System.Drawing.Size(474, 123);
            this.txt_TeknikDetaylar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teknik Detaylar :";
            // 
            // txt_StokAdeti
            // 
            this.txt_StokAdeti.Location = new System.Drawing.Point(114, 160);
            this.txt_StokAdeti.Name = "txt_StokAdeti";
            this.txt_StokAdeti.Size = new System.Drawing.Size(144, 22);
            this.txt_StokAdeti.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stok Adeti :";
            // 
            // txt_BirimFiyati
            // 
            this.txt_BirimFiyati.Location = new System.Drawing.Point(114, 192);
            this.txt_BirimFiyati.Name = "txt_BirimFiyati";
            this.txt_BirimFiyati.Size = new System.Drawing.Size(144, 22);
            this.txt_BirimFiyati.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Birim Fiyatı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kategori Adı :";
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.FormattingEnabled = true;
            this.cmb_Kategori.Location = new System.Drawing.Point(114, 33);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Size = new System.Drawing.Size(144, 24);
            this.cmb_Kategori.TabIndex = 13;
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.Location = new System.Drawing.Point(275, 362);
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.Size = new System.Drawing.Size(110, 32);
            this.btn_UrunEkle.TabIndex = 14;
            this.btn_UrunEkle.Text = "Parça Ekle";
            this.btn_UrunEkle.UseVisualStyleBackColor = true;
            this.btn_UrunEkle.Click += new System.EventHandler(this.btn_UrunEkle_Click);
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 415);
            this.Controls.Add(this.btn_UrunEkle);
            this.Controls.Add(this.cmb_Kategori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_BirimFiyati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_StokAdeti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TeknikDetaylar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Marka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ParcaAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUrunEkle";
            this.Text = "frmUrunEkle";
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ParcaAdi;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TeknikDetaylar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_StokAdeti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_BirimFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Kategori;
        private System.Windows.Forms.Button btn_UrunEkle;
    }
}