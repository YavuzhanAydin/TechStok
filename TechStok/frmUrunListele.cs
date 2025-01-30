using BLL;
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
    public partial class frmUrunListele : Form
    {
        public frmUrunListele()
        {
            InitializeComponent();
        }

        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            cmb_Kategori.DisplayMember = "KategoriAdi";
            cmb_Kategori.ValueMember = "KategoriId";
            cmb_Kategori.DataSource = CategoryManager.CategoryList();

            dgv_1.AutoGenerateColumns = false;
            dgv_1.DataSource = ProductManager.ProductList();

        }

        private void btn_Tumu_Click(object sender, EventArgs e)
        {
            dgv_1.DataSource = ProductManager.ProductList();

        }

        private void cmb_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            int category = Convert.ToInt32(cmb_Kategori.SelectedValue); 
            
            dgv_1.DataSource = ProductManager.ProductByCategoryIDList(category);

        
        }
    }
}
