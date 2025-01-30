namespace TechStok
{
    partial class frmUrunListele
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
            this.cmb_Kategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.btn_Tumu = new System.Windows.Forms.Button();
            this.ParcaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeknikDetaylar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.FormattingEnabled = true;
            this.cmb_Kategori.Location = new System.Drawing.Point(115, 35);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Size = new System.Drawing.Size(143, 24);
            this.cmb_Kategori.TabIndex = 0;
            this.cmb_Kategori.SelectedIndexChanged += new System.EventHandler(this.cmb_Kategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adı :";
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParcaID,
            this.ParcaAdi,
            this.Marka,
            this.Model,
            this.TeknikDetaylar,
            this.StokAdeti,
            this.BirimFiyati,
            this.KategoriAdi});
            this.dgv_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_1.Location = new System.Drawing.Point(0, 97);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(929, 360);
            this.dgv_1.TabIndex = 2;
            // 
            // btn_Tumu
            // 
            this.btn_Tumu.Location = new System.Drawing.Point(292, 25);
            this.btn_Tumu.Name = "btn_Tumu";
            this.btn_Tumu.Size = new System.Drawing.Size(95, 43);
            this.btn_Tumu.TabIndex = 3;
            this.btn_Tumu.Text = "Tümünü Göster";
            this.btn_Tumu.UseVisualStyleBackColor = true;
            this.btn_Tumu.Click += new System.EventHandler(this.btn_Tumu_Click);
            // 
            // ParcaID
            // 
            this.ParcaID.DataPropertyName = "ParcaID";
            this.ParcaID.HeaderText = "ParcaID";
            this.ParcaID.MinimumWidth = 6;
            this.ParcaID.Name = "ParcaID";
            this.ParcaID.Width = 125;
            // 
            // ParcaAdi
            // 
            this.ParcaAdi.DataPropertyName = "ParcaAdi";
            this.ParcaAdi.HeaderText = "ParcaAdi";
            this.ParcaAdi.MinimumWidth = 6;
            this.ParcaAdi.Name = "ParcaAdi";
            this.ParcaAdi.Width = 125;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Marka";
            this.Marka.MinimumWidth = 6;
            this.Marka.Name = "Marka";
            this.Marka.Width = 125;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.Width = 125;
            // 
            // TeknikDetaylar
            // 
            this.TeknikDetaylar.DataPropertyName = "TeknikDetaylar";
            this.TeknikDetaylar.HeaderText = "TeknikDetaylar";
            this.TeknikDetaylar.MinimumWidth = 6;
            this.TeknikDetaylar.Name = "TeknikDetaylar";
            this.TeknikDetaylar.Width = 125;
            // 
            // StokAdeti
            // 
            this.StokAdeti.DataPropertyName = "StokAdeti";
            this.StokAdeti.HeaderText = "StokAdeti";
            this.StokAdeti.MinimumWidth = 6;
            this.StokAdeti.Name = "StokAdeti";
            this.StokAdeti.Width = 125;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.DataPropertyName = "BirimFiyati";
            this.BirimFiyati.HeaderText = "BirimFiyati";
            this.BirimFiyati.MinimumWidth = 6;
            this.BirimFiyati.Name = "BirimFiyati";
            this.BirimFiyati.Width = 125;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.DataPropertyName = "KategoriAdi";
            this.KategoriAdi.HeaderText = "KategoriAdi";
            this.KategoriAdi.MinimumWidth = 6;
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.Width = 125;
            // 
            // frmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 457);
            this.Controls.Add(this.btn_Tumu);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Kategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUrunListele";
            this.Text = "frmUrunListele";
            this.Load += new System.EventHandler(this.frmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Button btn_Tumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeknikDetaylar;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAdi;
    }
}