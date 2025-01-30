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
using System.Xml.Linq;

namespace TechStok
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();

            dgv_1.AutoGenerateColumns = false;

            dgv_1.DataSource = CategoryManager.CategoryList();


        }

        private void btn_KategoriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_KategoriAdi.Text) || string.IsNullOrEmpty(txt_KategoriAciklama.Text))
            {
                MessageBox.Show("Uyarı!!" + " Lütfen alanları boş bırakmayınız", "Lütfen alanları boş bırakmayınız",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string KategoriAdi = txt_KategoriAdi.Text;
                string KategoriAciklama = txt_KategoriAciklama.Text;

                bool sonuc = CategoryManager.CategoryCreate(KategoriAdi, KategoriAciklama);
                if (sonuc == true)
                {
                    MessageBox.Show("Kategori Eklendi ... ");

                    CategoryReflesh();
                }
                else
                {
                    MessageBox.Show("Kategori Eklenmedi, \n Lütfen Bilgileri Kontrol Ediniz ",
                        "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }


            }


        }

        private void btn_KategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_KategoriAdi.Text) || string.IsNullOrEmpty(txt_KategoriAciklama.Text))
            {
                MessageBox.Show("Uyarı!!" + " Lütfen alanları boş bırakmayınız", "Lütfen alanları boş bırakmayınız",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                int KategoriID = Convert.ToInt32(txt_ID.Text);
                string KategoriAdi = txt_KategoriAdi.Text;
                string KategoriAciklama = txt_KategoriAciklama.Text;
                var sonuc = CategoryManager.CategoryControl(KategoriID);
                if (sonuc == true)
                {


                    CategoryManager.CategoryUpdate(KategoriID,KategoriAdi,KategoriAciklama);
                    CategoryReflesh();
                    MessageBox.Show("Kategori Başarılı Şekilde Güncellenmiştir");
                }
                else
                {
                    MessageBox.Show("Bu ID'ye Sahip Bir Kategori Yok");
                }

            }

        }

        private void dgv_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0) // Geçerli bir satır olup olmadığını kontrol et
            {
                DataGridViewRow row = dgv_1.Rows[rowIndex];

                // Satırdan verileri al ve TextBox'lara aktar
                txt_ID.Text = row.Cells[0].Value.ToString();
                txt_KategoriAdi.Text = row.Cells[1].Value.ToString();
                txt_KategoriAciklama.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btn_KategoriSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_KategoriAdi.Text) || string.IsNullOrEmpty(txt_KategoriAciklama.Text))
            {
                MessageBox.Show("Uyarı!!" + " Lütfen alanları boş bırakmayınız", "Lütfen alanları boş bırakmayınız",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                int KategoriID = Convert.ToInt32(txt_ID.Text);
                var sonuc = CategoryManager.CategoryDelete(KategoriID);
                if (sonuc == true)
                {
                    MessageBox.Show("Kategori Başarılı Şekilde Silinmiştir");
                    CategoryReflesh();
                }
                else
                {
                    MessageBox.Show("Bu ID'ye Sahip Bir Kategori Yok");
                }
            }

        }

        private void CategoryReflesh()
        {
            dgv_1.DataSource = CategoryManager.CategoryList();
        }



    }
}
