namespace TechStok
{
    partial class frmUrunSatinAl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Kategori = new System.Windows.Forms.ComboBox();
            this.dgv_Urunler = new System.Windows.Forms.DataGridView();
            this.ParcaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Toplam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Sepet = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdeti_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyati_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SatınAl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Urunler)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sepet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_Kategori);
            this.panel1.Controls.Add(this.dgv_Urunler);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 647);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(279, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürünler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.FormattingEnabled = true;
            this.cmb_Kategori.Location = new System.Drawing.Point(97, 68);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Size = new System.Drawing.Size(121, 24);
            this.cmb_Kategori.TabIndex = 3;
            this.cmb_Kategori.SelectedIndexChanged += new System.EventHandler(this.cmb_Kategori_SelectedIndexChanged);
            // 
            // dgv_Urunler
            // 
            this.dgv_Urunler.AllowUserToAddRows = false;
            this.dgv_Urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Urunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParcaID,
            this.ParcaAdi,
            this.Marka,
            this.Model,
            this.StokAdeti,
            this.BirimFiyati});
            this.dgv_Urunler.Location = new System.Drawing.Point(0, 98);
            this.dgv_Urunler.Name = "dgv_Urunler";
            this.dgv_Urunler.ReadOnly = true;
            this.dgv_Urunler.RowHeadersWidth = 51;
            this.dgv_Urunler.RowTemplate.Height = 24;
            this.dgv_Urunler.Size = new System.Drawing.Size(743, 476);
            this.dgv_Urunler.TabIndex = 0;
            this.dgv_Urunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Urunler_CellContentClick);
            this.dgv_Urunler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Urunler_CellDoubleClick);
            // 
            // ParcaID
            // 
            this.ParcaID.DataPropertyName = "ParcaID";
            this.ParcaID.HeaderText = "ParcaID";
            this.ParcaID.MinimumWidth = 6;
            this.ParcaID.Name = "ParcaID";
            this.ParcaID.ReadOnly = true;
            this.ParcaID.Width = 50;
            // 
            // ParcaAdi
            // 
            this.ParcaAdi.DataPropertyName = "ParcaAdi";
            this.ParcaAdi.HeaderText = "ParcaAdi";
            this.ParcaAdi.MinimumWidth = 6;
            this.ParcaAdi.Name = "ParcaAdi";
            this.ParcaAdi.ReadOnly = true;
            this.ParcaAdi.Width = 125;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Marka";
            this.Marka.MinimumWidth = 6;
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            this.Marka.Width = 75;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 75;
            // 
            // StokAdeti
            // 
            this.StokAdeti.DataPropertyName = "StokAdeti";
            this.StokAdeti.HeaderText = "StokAdeti";
            this.StokAdeti.MinimumWidth = 6;
            this.StokAdeti.Name = "StokAdeti";
            this.StokAdeti.ReadOnly = true;
            this.StokAdeti.Width = 75;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.DataPropertyName = "BirimFiyati";
            this.BirimFiyati.HeaderText = "BirimFiyati";
            this.BirimFiyati.MinimumWidth = 6;
            this.BirimFiyati.Name = "BirimFiyati";
            this.BirimFiyati.ReadOnly = true;
            this.BirimFiyati.Width = 75;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_SatınAl);
            this.panel2.Controls.Add(this.lbl_Toplam);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgv_Sepet);
            this.panel2.Location = new System.Drawing.Point(764, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 647);
            this.panel2.TabIndex = 2;
            // 
            // lbl_Toplam
            // 
            this.lbl_Toplam.AutoSize = true;
            this.lbl_Toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Toplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Toplam.Location = new System.Drawing.Point(163, 593);
            this.lbl_Toplam.Name = "lbl_Toplam";
            this.lbl_Toplam.Size = new System.Drawing.Size(15, 20);
            this.lbl_Toplam.TabIndex = 8;
            this.lbl_Toplam.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam Tutar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(318, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sepet";
            // 
            // dgv_Sepet
            // 
            this.dgv_Sepet.AllowUserToAddRows = false;
            this.dgv_Sepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Adi,
            this.Marka_S,
            this.Model_S,
            this.StokAdeti_S,
            this.BirimFiyati_S,
            this.Adet});
            this.dgv_Sepet.Location = new System.Drawing.Point(0, 98);
            this.dgv_Sepet.Name = "dgv_Sepet";
            this.dgv_Sepet.RowHeadersWidth = 51;
            this.dgv_Sepet.RowTemplate.Height = 24;
            this.dgv_Sepet.Size = new System.Drawing.Size(719, 476);
            this.dgv_Sepet.TabIndex = 0;
            this.dgv_Sepet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sepet_CellDoubleClick);
            this.dgv_Sepet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sepet_CellValueChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ParcaId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "ParcaAdi";
            this.Adi.HeaderText = "Adi";
            this.Adi.MinimumWidth = 6;
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            this.Adi.Width = 125;
            // 
            // Marka_S
            // 
            this.Marka_S.DataPropertyName = "Marka";
            this.Marka_S.HeaderText = "Marka_S";
            this.Marka_S.MinimumWidth = 6;
            this.Marka_S.Name = "Marka_S";
            this.Marka_S.ReadOnly = true;
            this.Marka_S.Width = 75;
            // 
            // Model_S
            // 
            this.Model_S.DataPropertyName = "Model";
            this.Model_S.HeaderText = "Model_S";
            this.Model_S.MinimumWidth = 6;
            this.Model_S.Name = "Model_S";
            this.Model_S.ReadOnly = true;
            this.Model_S.Width = 75;
            // 
            // StokAdeti_S
            // 
            this.StokAdeti_S.DataPropertyName = "StokAdeti";
            this.StokAdeti_S.HeaderText = "StokAdeti_S";
            this.StokAdeti_S.MinimumWidth = 6;
            this.StokAdeti_S.Name = "StokAdeti_S";
            this.StokAdeti_S.ReadOnly = true;
            this.StokAdeti_S.Width = 50;
            // 
            // BirimFiyati_S
            // 
            this.BirimFiyati_S.DataPropertyName = "BirimFiyati";
            this.BirimFiyati_S.HeaderText = "BirimFiyati_S";
            this.BirimFiyati_S.MinimumWidth = 6;
            this.BirimFiyati_S.Name = "BirimFiyati_S";
            this.BirimFiyati_S.ReadOnly = true;
            this.BirimFiyati_S.Width = 75;
            // 
            // Adet
            // 
            this.Adet.DataPropertyName = "Adet";
            this.Adet.HeaderText = "Adet";
            this.Adet.MinimumWidth = 6;
            this.Adet.Name = "Adet";
            this.Adet.Width = 50;
            // 
            // btn_SatınAl
            // 
            this.btn_SatınAl.Location = new System.Drawing.Point(528, 588);
            this.btn_SatınAl.Name = "btn_SatınAl";
            this.btn_SatınAl.Size = new System.Drawing.Size(107, 36);
            this.btn_SatınAl.TabIndex = 9;
            this.btn_SatınAl.Text = "Satın Al";
            this.btn_SatınAl.UseVisualStyleBackColor = true;
            this.btn_SatınAl.Click += new System.EventHandler(this.btn_SatınAl_Click);
            // 
            // frmUrunSatinAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 715);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUrunSatinAl";
            this.Text = "frmUrunSatinAl";
            this.Load += new System.EventHandler(this.frmUrunSatinAl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Urunler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Urunler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Sepet;
        private System.Windows.Forms.ComboBox cmb_Kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Toplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdeti_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyati_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.Button btn_SatınAl;
    }
}