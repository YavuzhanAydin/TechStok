using BLL;
using DAL;
using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStok
{
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKullaniciKayit kullaniciKayit = new frmKullaniciKayit();
            kullaniciKayit.Show();
            this.Hide();
        }

        private void KullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_KullaniciAdi.Text) || string.IsNullOrEmpty(txt_Sifre.Text))
            {
                MessageBox.Show("Uyarı!!" + " Lütfen alanları boş bırakmayınız", "Lütfen alanları boş bırakmayınız",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            string KullaniciAdi = txt_KullaniciAdi.Text;
            string KullaniciSifre = txt_Sifre.Text;


            tbl_Kullanicilar user = UserManager.UserLogin(KullaniciAdi, KullaniciSifre);
            if (user != null)
            {
                var sonuc = LogManager.Logla(user.KullaniciId, DateTime.Now, "Kullanıcı Girisi");
                if (sonuc == false)
                {
                    MessageBox.Show("Loglamada Bir Sıkıntı Oluştu");
                }
                else
                {
                    tbl_Kullanicilar kullanici = UserManager.UserFindByUsername(KullaniciAdi);
                    UserService.CurrentUser = kullanici;


                    frmAnaSayfa frmAnaSayfa = new frmAnaSayfa(user);
                    frmAnaSayfa.Show();
                    this.Hide();

                    MessageBox.Show("Sisteme Hoş Geldiniz" + user.Ad + " " + user.Soyad);

                }


               
            }
            else
            {
                MessageBox.Show("Giris Başarısız. Kullanıcı Adı ve Şifreyi Kontrol Ediniz");
            }


        }
    }
}
