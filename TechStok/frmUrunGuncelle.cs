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
    public partial class frmUrunGuncelle : Form
    {
        public frmUrunGuncelle()
        {
            InitializeComponent();

            cmb_Kategori.DisplayMember = "KategoriAdi";
            cmb_Kategori.ValueMember = "KategoriId";
            cmb_Kategori.DataSource = CategoryManager.CategoryList();

        }

        private void frmUrunGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btn_IDGetir_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_ID.Text);

            var sonuc = ProductManager.ProductControlID(ID);
            if (sonuc == true)
            {

                var Product = ProductManager.ProductByIDList(ID);

                ReadOnly();

                txt_ParcaAdi.Text = Product.ParcaAdi;
                txt_Marka.Text = Product.Marka;
                txt_Model.Text = Product.Model;
                txt_BirimFiyati.Text = Product.BirimFiyati.ToString();
                txt_StokAdeti.Text = Product.StokAdeti.ToString();
                txt_TeknikDetaylar.Text = Product.TeknikDetaylar;
                cmb_Kategori.SelectedValue = Product.KategoriID;

            }
            else
            {
                ReadOnlyFalse();

                MessageBox.Show("Bu ID Sistemde Bulunmamaktadır");

            }


        }


        private void btn_UrunGuncelle_Click(object sender, EventArgs e)
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
                int ParcaID = Convert.ToInt32(txt_ID.Text);
                string ParcaAdi = txt_ParcaAdi.Text;
                string Marka = txt_Marka.Text;
                string Model = txt_Model.Text;
                int StokAdeti = Convert.ToInt32(txt_StokAdeti.Text);
                decimal BirimFiyati = Convert.ToDecimal(txt_BirimFiyati.Text);
                string TeknikDetaylar = txt_TeknikDetaylar.Text;
                int KategoriID = Convert.ToInt32(cmb_Kategori.SelectedValue);

                 var sonuc = ProductManager.ProductUpdate(ParcaID,ParcaAdi,Marka,Model,StokAdeti,BirimFiyati,TeknikDetaylar,KategoriID);
                if (sonuc == true)
                {
                    MessageBox.Show("Ürün Başarıyla Güncellendi ");

                }
                else
                {
                    MessageBox.Show("Ürün Güncellenirken Bir Hata Gerçekleşti");
                }


            }
        }
        public void ReadOnly()
        {
            txt_ParcaAdi.ReadOnly = false;
            txt_Marka.ReadOnly = false;
            txt_Model.ReadOnly = false;
            txt_StokAdeti.ReadOnly = false;
            txt_BirimFiyati.ReadOnly = false;
            txt_TeknikDetaylar.ReadOnly = false;

        }

        public void ReadOnlyFalse()
        {
            txt_ParcaAdi.Text = null;
            txt_Marka.Text = null;
            txt_Model.Text = null;
            txt_StokAdeti.Text = null;
            txt_BirimFiyati.Text = null;
            txt_TeknikDetaylar.Text = null;



            txt_ParcaAdi.ReadOnly = true;
            txt_Marka.ReadOnly = true;
            txt_Model.ReadOnly = true;
            txt_StokAdeti.ReadOnly = true;
            txt_BirimFiyati.ReadOnly = true;
            txt_TeknikDetaylar.ReadOnly = true;


        }
    }
}
