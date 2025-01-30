using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStok
{
    public partial class frmSiparislerim : Form
    {
        public frmSiparislerim()
        {
            InitializeComponent();
        }

        private void frmSiparislerim_Load(object sender, EventArgs e)
        {
            var list = ShoppingManager.ShoppingByKullaniciID(UserService.CurrentUser.KullaniciId);
            ls_Siparisler.DataSource = list;
            ls_Siparisler.DisplayMember = "SiparisId";
            ls_Siparisler.ValueMember = "SiparisId";


        }

        private void ls_Siparisler_DoubleClick(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ls_Siparisler.SelectedValue);
            
            var siparis = ShoppingManager.ShoppingGetID(ID);
            lbl_SiparisDurum.Text = siparis.SiparisDurumu.ToString();
            lbl_SiparisTarih.Text = siparis.SiparisTarihi.ToString();
            lbl_ToplamTutar.Text = siparis.ToplamTutar.ToString();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ShopDetailsManager.DetailsGetID(ID);
        }
    }
}
