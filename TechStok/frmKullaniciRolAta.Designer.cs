namespace TechStok
{
    partial class frmKullaniciRolAta
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
            this.txt_SicilNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.btn_Sorgula = new System.Windows.Forms.Button();
            this.cmb_Yetki = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_RolAta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_SicilNo
            // 
            this.txt_SicilNo.Location = new System.Drawing.Point(89, 30);
            this.txt_SicilNo.Name = "txt_SicilNo";
            this.txt_SicilNo.Size = new System.Drawing.Size(149, 22);
            this.txt_SicilNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sicil No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad - Soyad :";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Enabled = false;
            this.txt_AdSoyad.Location = new System.Drawing.Point(89, 82);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(149, 22);
            this.txt_AdSoyad.TabIndex = 2;
            // 
            // btn_Sorgula
            // 
            this.btn_Sorgula.Location = new System.Drawing.Point(287, 33);
            this.btn_Sorgula.Name = "btn_Sorgula";
            this.btn_Sorgula.Size = new System.Drawing.Size(90, 29);
            this.btn_Sorgula.TabIndex = 4;
            this.btn_Sorgula.Text = "SicilNo Bul";
            this.btn_Sorgula.UseVisualStyleBackColor = true;
            this.btn_Sorgula.Click += new System.EventHandler(this.btn_Sorgula_Click);
            // 
            // cmb_Yetki
            // 
            this.cmb_Yetki.FormattingEnabled = true;
            this.cmb_Yetki.Location = new System.Drawing.Point(89, 125);
            this.cmb_Yetki.Name = "cmb_Yetki";
            this.cmb_Yetki.Size = new System.Drawing.Size(149, 24);
            this.cmb_Yetki.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yetkiler :";
            // 
            // btn_RolAta
            // 
            this.btn_RolAta.Location = new System.Drawing.Point(100, 199);
            this.btn_RolAta.Name = "btn_RolAta";
            this.btn_RolAta.Size = new System.Drawing.Size(117, 29);
            this.btn_RolAta.TabIndex = 7;
            this.btn_RolAta.Text = "Rol Ata";
            this.btn_RolAta.UseVisualStyleBackColor = true;
            this.btn_RolAta.Click += new System.EventHandler(this.btn_RolAta_Click);
            // 
            // frmKullaniciRolAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 271);
            this.Controls.Add(this.btn_RolAta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Yetki);
            this.Controls.Add(this.btn_Sorgula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SicilNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKullaniciRolAta";
            this.Text = "frmKullaniciRolAta";
            this.Load += new System.EventHandler(this.frmKullaniciRolAta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SicilNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Button btn_Sorgula;
        private System.Windows.Forms.ComboBox cmb_Yetki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_RolAta;
    }
}