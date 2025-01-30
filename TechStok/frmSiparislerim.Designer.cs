namespace TechStok
{
    partial class frmSiparislerim
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ParcaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ls_Siparisler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_SiparisTarih = new System.Windows.Forms.Label();
            this.lbl_SiparisDurum = new System.Windows.Forms.Label();
            this.lbl_ToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParcaId,
            this.ParcaAdi,
            this.Marka,
            this.Model,
            this.Adet,
            this.BirimFiyati});
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // ParcaId
            // 
            this.ParcaId.DataPropertyName = "ParcaId";
            this.ParcaId.HeaderText = "ParcaId";
            this.ParcaId.MinimumWidth = 6;
            this.ParcaId.Name = "ParcaId";
            this.ParcaId.ReadOnly = true;
            this.ParcaId.Width = 125;
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
            this.Marka.Width = 125;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 125;
            // 
            // Adet
            // 
            this.Adet.DataPropertyName = "Adet";
            this.Adet.HeaderText = "Adet";
            this.Adet.MinimumWidth = 6;
            this.Adet.Name = "Adet";
            this.Adet.ReadOnly = true;
            this.Adet.Width = 125;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.DataPropertyName = "BirimFiyati";
            this.BirimFiyati.HeaderText = "BirimFiyati";
            this.BirimFiyati.MinimumWidth = 6;
            this.BirimFiyati.Name = "BirimFiyati";
            this.BirimFiyati.ReadOnly = true;
            this.BirimFiyati.Width = 125;
            // 
            // ls_Siparisler
            // 
            this.ls_Siparisler.FormattingEnabled = true;
            this.ls_Siparisler.ItemHeight = 16;
            this.ls_Siparisler.Location = new System.Drawing.Point(13, 13);
            this.ls_Siparisler.Name = "ls_Siparisler";
            this.ls_Siparisler.Size = new System.Drawing.Size(424, 276);
            this.ls_Siparisler.TabIndex = 1;
            this.ls_Siparisler.DoubleClick += new System.EventHandler(this.ls_Siparisler_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(704, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sipariş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(704, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Tutar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(704, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sipariş Durumu :";
            // 
            // lbl_SiparisTarih
            // 
            this.lbl_SiparisTarih.AutoSize = true;
            this.lbl_SiparisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SiparisTarih.Location = new System.Drawing.Point(879, 56);
            this.lbl_SiparisTarih.Name = "lbl_SiparisTarih";
            this.lbl_SiparisTarih.Size = new System.Drawing.Size(16, 22);
            this.lbl_SiparisTarih.TabIndex = 5;
            this.lbl_SiparisTarih.Text = "-";
            // 
            // lbl_SiparisDurum
            // 
            this.lbl_SiparisDurum.AutoSize = true;
            this.lbl_SiparisDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SiparisDurum.Location = new System.Drawing.Point(879, 100);
            this.lbl_SiparisDurum.Name = "lbl_SiparisDurum";
            this.lbl_SiparisDurum.Size = new System.Drawing.Size(16, 22);
            this.lbl_SiparisDurum.TabIndex = 6;
            this.lbl_SiparisDurum.Text = "-";
            // 
            // lbl_ToplamTutar
            // 
            this.lbl_ToplamTutar.AutoSize = true;
            this.lbl_ToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ToplamTutar.Location = new System.Drawing.Point(879, 144);
            this.lbl_ToplamTutar.Name = "lbl_ToplamTutar";
            this.lbl_ToplamTutar.Size = new System.Drawing.Size(16, 22);
            this.lbl_ToplamTutar.TabIndex = 7;
            this.lbl_ToplamTutar.Text = "-";
            // 
            // frmSiparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 569);
            this.Controls.Add(this.lbl_ToplamTutar);
            this.Controls.Add(this.lbl_SiparisDurum);
            this.Controls.Add(this.lbl_SiparisTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ls_Siparisler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSiparislerim";
            this.Text = "frmSiparislerim";
            this.Load += new System.EventHandler(this.frmSiparislerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox ls_Siparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_SiparisTarih;
        private System.Windows.Forms.Label lbl_SiparisDurum;
        private System.Windows.Forms.Label lbl_ToplamTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyati;
    }
}