using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStok
{
    public partial class frmKullaniciRolAta : Form
    {
        public frmKullaniciRolAta()
        {
            InitializeComponent();
        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SicilNo.Text) )
            {
                MessageBox.Show("Uyarı!!" + " Lütfen alanları boş bırakmayınız", "Lütfen alanları boş bırakmayınız",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
            var user = UserManager.UserFindByRegNo(Convert.ToInt32(txt_SicilNo.Text));
            txt_AdSoyad.Text = user.Ad + " "+ user.Soyad;
            }
        }

        private void frmKullaniciRolAta_Load(object sender, EventArgs e)
        {
            cmb_Yetki.DisplayMember = "YetkiAdi";
            cmb_Yetki.ValueMember = "YetkiId";
            cmb_Yetki.DataSource= UserManager.UserRoleList();

        }

        private void btn_RolAta_Click(object sender, EventArgs e)
        {
            var user = UserManager.UserFindByRegNo(Convert.ToInt32(txt_SicilNo.Text));
            user.YetkiSeviyesi = Convert.ToInt32(cmb_Yetki.SelectedValue);


            var sonuc = UserManager.UserUpdate(user);
            if (sonuc == true)
            {
                MessageBox.Show("Kullanıcının Rolü Değiştirildi");

            }
            else
            {
                MessageBox.Show("!!!  Kullanıcının Rolü Değiştirilemedi");
            }

        }
    }
}
