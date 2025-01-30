using BLL;
using DAL;
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
    public partial class frmProfilBilgileri : Form
    {
        public frmProfilBilgileri()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmProfilBilgileri_Load(object sender, EventArgs e)
        {
            var user = UserManager.UserListID(UserService.CurrentUser.KullaniciId);
            lbl_SicilNo.Text = user.SicilNo.ToString();
            lbl_KullaniciAdi.Text = user.KullaniciAdi.ToString();
            lbl_Ad.Text = user.Ad.ToString();
            lbl_Soyad.Text = user.Soyad.ToString();
            lbl_Email.Text = user.Email.ToString();
            lbl_DogumTarihi.Text = user.DogumTarihi.ToString();

        }
    }
}
