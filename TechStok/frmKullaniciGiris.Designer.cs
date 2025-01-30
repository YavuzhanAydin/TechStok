namespace TechStok
{
    partial class frmKullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGiris));
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(167, 82);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(161, 22);
            this.txt_KullaniciAdi.TabIndex = 1;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(167, 110);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(161, 22);
            this.txt_Sifre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre :";
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Location = new System.Drawing.Point(98, 179);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(141, 30);
            this.btn_Giris.TabIndex = 14;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 509);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(483, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 408);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Giris);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_KullaniciAdi);
            this.panel2.Controls.Add(this.txt_Sifre);
            this.panel2.Location = new System.Drawing.Point(24, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 254);
            this.panel2.TabIndex = 15;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(132, 212);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 18);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-71, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 509);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmKullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici Giriş";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KullaniciGiris_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

