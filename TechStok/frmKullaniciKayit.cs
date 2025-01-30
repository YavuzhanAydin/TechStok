using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace TechStok
{
    public partial class frmKullaniciKayit : Form
    {
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_KullaniciAdi.Text) ||
                string.IsNullOrEmpty(txt_Sifre.Text)||
                string.IsNullOrEmpty(txt_TcKimlikNo.Text)||
                string.IsNullOrEmpty(txt_Adi.Text)||
                string.IsNullOrEmpty(txt_Soyad.Text)|| string.IsNullOrEmpty(txt_Email.Text) )
            {
                MessageBox.Show("Uyarı!!"+" Lütfen alanları boş bırakmayınız", "Lütfen alanları boş bırakmayınız",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                long TCNO = Convert.ToInt64(txt_TcKimlikNo.Text);
                string KullaniciAdi = txt_KullaniciAdi.Text;
                string KullaniciSifre = txt_Sifre.Text;
                string Adi = txt_Adi.Text;
                string Soyad = txt_Soyad.Text;
                string Email = txt_Email.Text;
                DateTime DogumTarihi = dtp_DogumTarihi.Value.Date;

                bool sonuc = UserManager.UserRegister(TCNO, KullaniciAdi, KullaniciSifre, Adi, Soyad, Email, DogumTarihi);
                if (sonuc == true)
                {
                    MessageBox.Show("Kullanıcı Eklendi");

                    frmKullaniciGiris kullaniciGiris = new frmKullaniciGiris();
                    kullaniciGiris.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Eklenmedi, \n Lütfen Girdiğiniz Bilgilerin Doğru Olduğunu Kontrol Edin  ",
                        "",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKullaniciGiris kullaniciGiris = new frmKullaniciGiris();
            kullaniciGiris.Show();
            this.Hide();
        }

        private void KullaniciKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
