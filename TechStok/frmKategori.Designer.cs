namespace TechStok
{
    partial class frmKategori
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
            this.txt_KategoriAdi = new System.Windows.Forms.TextBox();
            this.txt_KategoriAciklama = new System.Windows.Forms.TextBox();
            this.btn_KategoriEkle = new System.Windows.Forms.Button();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.btn_KategoriGuncelle = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_KategoriSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Açıklama :";
            // 
            // txt_KategoriAdi
            // 
            this.txt_KategoriAdi.Location = new System.Drawing.Point(155, 71);
            this.txt_KategoriAdi.Name = "txt_KategoriAdi";
            this.txt_KategoriAdi.Size = new System.Drawing.Size(135, 22);
            this.txt_KategoriAdi.TabIndex = 2;
            // 
            // txt_KategoriAciklama
            // 
            this.txt_KategoriAciklama.Location = new System.Drawing.Point(155, 106);
            this.txt_KategoriAciklama.Name = "txt_KategoriAciklama";
            this.txt_KategoriAciklama.Size = new System.Drawing.Size(135, 22);
            this.txt_KategoriAciklama.TabIndex = 3;
            // 
            // btn_KategoriEkle
            // 
            this.btn_KategoriEkle.Location = new System.Drawing.Point(339, 31);
            this.btn_KategoriEkle.Name = "btn_KategoriEkle";
            this.btn_KategoriEkle.Size = new System.Drawing.Size(141, 32);
            this.btn_KategoriEkle.TabIndex = 4;
            this.btn_KategoriEkle.Text = "Kategori Ekle";
            this.btn_KategoriEkle.UseVisualStyleBackColor = true;
            this.btn_KategoriEkle.Click += new System.EventHandler(this.btn_KategoriEkle_Click);
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KategoriAdi,
            this.KategoriAciklama});
            this.dgv_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_1.Location = new System.Drawing.Point(0, 156);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(806, 294);
            this.dgv_1.TabIndex = 5;
            this.dgv_1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellDoubleClick);
            // 
            // btn_KategoriGuncelle
            // 
            this.btn_KategoriGuncelle.Location = new System.Drawing.Point(339, 71);
            this.btn_KategoriGuncelle.Name = "btn_KategoriGuncelle";
            this.btn_KategoriGuncelle.Size = new System.Drawing.Size(141, 32);
            this.btn_KategoriGuncelle.TabIndex = 6;
            this.btn_KategoriGuncelle.Text = "Kategori Güncelle";
            this.btn_KategoriGuncelle.UseVisualStyleBackColor = true;
            this.btn_KategoriGuncelle.Click += new System.EventHandler(this.btn_KategoriGuncelle_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(155, 43);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(135, 22);
            this.txt_ID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori ID :";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "KategoriId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.DataPropertyName = "KategoriAdi";
            this.KategoriAdi.HeaderText = "KategoriAdi";
            this.KategoriAdi.MinimumWidth = 6;
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.Width = 300;
            // 
            // KategoriAciklama
            // 
            this.KategoriAciklama.DataPropertyName = "KategoriAciklama";
            this.KategoriAciklama.HeaderText = "KategoriAciklama";
            this.KategoriAciklama.MinimumWidth = 6;
            this.KategoriAciklama.Name = "KategoriAciklama";
            this.KategoriAciklama.Width = 450;
            // 
            // btn_KategoriSil
            // 
            this.btn_KategoriSil.Location = new System.Drawing.Point(339, 109);
            this.btn_KategoriSil.Name = "btn_KategoriSil";
            this.btn_KategoriSil.Size = new System.Drawing.Size(141, 32);
            this.btn_KategoriSil.TabIndex = 9;
            this.btn_KategoriSil.Text = "Kategori Sil";
            this.btn_KategoriSil.UseVisualStyleBackColor = true;
            this.btn_KategoriSil.Click += new System.EventHandler(this.btn_KategoriSil_Click);
            // 
            // frmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.btn_KategoriSil);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_KategoriGuncelle);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.btn_KategoriEkle);
            this.Controls.Add(this.txt_KategoriAciklama);
            this.Controls.Add(this.txt_KategoriAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmKategori";
            this.Text = "frmKategoriEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KategoriAdi;
        private System.Windows.Forms.TextBox txt_KategoriAciklama;
        private System.Windows.Forms.Button btn_KategoriEkle;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Button btn_KategoriGuncelle;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAciklama;
        private System.Windows.Forms.Button btn_KategoriSil;
    }
}