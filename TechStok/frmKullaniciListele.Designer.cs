namespace TechStok
{
    partial class frmKullaniciListele
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
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.SicilNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiSeviyesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SicilNo,
            this.KullaniciAdi,
            this.Ad,
            this.Soyad,
            this.Email,
            this.YetkiAdi,
            this.YetkiSeviyesi});
            this.dgv_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_1.Location = new System.Drawing.Point(0, 0);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(931, 450);
            this.dgv_1.TabIndex = 0;
            // 
            // SicilNo
            // 
            this.SicilNo.DataPropertyName = "SicilNo";
            this.SicilNo.HeaderText = "SicilNo";
            this.SicilNo.MinimumWidth = 6;
            this.SicilNo.Name = "SicilNo";
            this.SicilNo.Width = 125;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.DataPropertyName = "KullaniciAdi";
            this.KullaniciAdi.HeaderText = "KullaniciAdi";
            this.KullaniciAdi.MinimumWidth = 6;
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Width = 125;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.Width = 125;
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // YetkiAdi
            // 
            this.YetkiAdi.DataPropertyName = "YetkiAdi";
            this.YetkiAdi.HeaderText = "YetkiAdi";
            this.YetkiAdi.MinimumWidth = 6;
            this.YetkiAdi.Name = "YetkiAdi";
            this.YetkiAdi.Width = 125;
            // 
            // YetkiSeviyesi
            // 
            this.YetkiSeviyesi.DataPropertyName = "YetkiSeviyesi";
            this.YetkiSeviyesi.HeaderText = "YetkiSeviyesi";
            this.YetkiSeviyesi.MinimumWidth = 6;
            this.YetkiSeviyesi.Name = "YetkiSeviyesi";
            this.YetkiSeviyesi.Width = 125;
            // 
            // frmKullaniciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.dgv_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmKullaniciListele";
            this.Text = "frmKullaniciListele";
            this.Load += new System.EventHandler(this.frmKullaniciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SicilNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiSeviyesi;
    }
}