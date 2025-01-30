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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            cmb_Kategori.DisplayMember = "KategoriAdi";
            cmb_Kategori.ValueMember = "KategoriId";
            cmb_Kategori.DataSource = CategoryManager.CategoryList();

        }

        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ParcaAdi.Text) || string.IsNullOrEmpty(txt_Marka.Text) || string.IsNullOrEmpty(txt_Model.Text) ||
                string.IsNullOrEmpty(txt_BirimFiyati.Text) || string.IsNullOrEmpty(txt_StokAdeti.Text) || string.IsNullOrEmpty(txt_TeknikDetaylar.Text)
               )
            {
                MessageBox.Show("Uyarı!!" + " Lütfen alanları boş bırakmayınız", "Lütfen alanları boş bırakmayınız",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string ParcaAdi = txt_ParcaAdi.Text;
                string Marka = txt_Marka.Text;
                string Model = txt_Model.Text;
                int StokAdeti = Convert.ToInt32(txt_StokAdeti.Text);
                decimal BirimFiyati = Convert.ToDecimal(txt_BirimFiyati.Text);
                string TeknikDetaylar = txt_TeknikDetaylar.Text;
                int KategoriID = Convert.ToInt32(cmb_Kategori.SelectedValue);

                var sonuc = ProductManager.ProductCreate(ParcaAdi, Marka, Model, StokAdeti, BirimFiyati, TeknikDetaylar, KategoriID);
                if (sonuc == true)
                {
                    MessageBox.Show("Ürün Başarıyla Eklendi ");

                }
                else
                {
                    MessageBox.Show("Ürün Eklenirken Bir Hata Gerçekleşti");
                }


            }






        }

    }
}
