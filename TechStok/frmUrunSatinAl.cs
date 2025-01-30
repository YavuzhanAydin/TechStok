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
    public partial class frmUrunSatinAl : Form
    {
        public frmUrunSatinAl()
        {
            InitializeComponent();
        }

        private void dgv_Urunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUrunSatinAl_Load(object sender, EventArgs e)
        {
            dgv_Urunler.AutoGenerateColumns = false;
            dgv_Sepet.AutoGenerateColumns = false;
            var sonuc = ProductManager.ProductList();

            dgv_Urunler.DataSource = sonuc;

            cmb_Kategori.DisplayMember = "KategoriAdi";
            cmb_Kategori.ValueMember = "KategoriId";
            cmb_Kategori.DataSource = CategoryManager.CategoryList();

            DataGridViewColumn adetColumn = dgv_Sepet.Columns["Adet"];
            adetColumn.CellTemplate = new DataGridViewTextBoxCell();

        }

        private void cmb_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            int category = Convert.ToInt32(cmb_Kategori.SelectedValue);

            dgv_Urunler.DataSource = ProductManager.ProductByCategoryIDList(category);
        }

        List<tbl_Parca> sepet = new List<tbl_Parca>();

        private void dgv_Urunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0) // Geçerli satır seçildi mi?
            {
                DataGridViewRow row = dgv_Urunler.Rows[e.RowIndex];
                int ParcaID = Convert.ToInt32(row.Cells[0].Value);
                string ParcaAdi = row.Cells[1].Value.ToString();
                string Marka = row.Cells[2].Value.ToString();
                string Model = row.Cells[3].Value.ToString();
                int stokAdeti = Convert.ToInt32(row.Cells[4].Value);
                decimal fiyat = Convert.ToDecimal(row.Cells[5].Value);

                // Sepet kontrolü (sepette var mı?)
                var mevcutParca = sepet.FirstOrDefault(p => p.ParcaId == ParcaID);

                if (mevcutParca != null)
                {
                    // Ürün zaten sepette varsa, sadece adet artır
                    if (mevcutParca.Adet < mevcutParca.StokAdeti)
                    {
                        mevcutParca.Adet++;
                    }
                    else
                    {
                        MessageBox.Show("Stokta yeterli miktar yok.");
                    }
                }
                else
                {
                    if (stokAdeti == 0)
                    {

                        MessageBox.Show("Stokta yeterli miktar yok.");

                    }
                    else
                    {


                        tbl_Parca parca = new tbl_Parca
                        {
                            ParcaId = ParcaID,
                            ParcaAdi = ParcaAdi,
                            BirimFiyati = fiyat,
                            Model = Model,
                            Marka = Marka,
                            StokAdeti = stokAdeti,
                            Adet = 1 // Yeni eklenen ürün için adet 1 olacak
                        };

                        sepet.Add(parca);
                       

                    }

                }

                // Sepet DataGridView'ini bağla (DataSource'yi yeniden atama yerine BindingList kullan)
                dgv_Sepet.DataSource = null; // Mevcut bağlamayı kaldır
                dgv_Sepet.DataSource = sepet; // Güncellenmiş sepeti bağlaa


                // Sepet toplamını güncelle
                SepetToplaminiGuncelle();
            }





        }



        private void dgv_Sepet_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                if (i < dgv_Sepet.Rows.Count) // Geçerli indeks kontrolü
                {
                    var adetCell = dgv_Sepet.Rows[i].Cells["Adet"];
                    if (adetCell.Value == null) // Sadece boş olan hücrelere müdahale et
                    {
                        adetCell.Value = 1; // Varsayılan değer olarak 1 ata
                    }
                }
            }
        }

        private void dgv_Sepet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //// Eğer "Adet" sütunu düzenlendiyse
            //if (e.RowIndex >= 0 && e.ColumnIndex == dgv_Sepet.Columns["Adet"].Index)
            //{
            //    var urun = (tbl_Parca)dgv_Sepet.Rows[e.RowIndex].DataBoundItem;
            //    int yeniAdet = Convert.ToInt32(dgv_Sepet.Rows[e.RowIndex].Cells["Adet"].Value);

            //    // Yeni adet değeri stoktan fazla olmasın
            //    if (yeniAdet > urun.StokAdeti)
            //    {
            //        MessageBox.Show("Stokta yeterli miktar yok.");
            //        dgv_Sepet.Rows[e.RowIndex].Cells["Adet"].Value = urun.StokAdeti; // Stok adedini tekrar ayarla
            //    }
            //    else
            //    {
            //        DataGridViewRow row = dgv_Sepet.Rows[e.RowIndex];
            //        row.Cells[6].Value = yeniAdet; // Sepet ürününün adedini güncelle
            //    }

            //    // Sepetin toplam tutarını güncelleyebilirsiniz.

            //}

            //if (e.RowIndex >= 0 && e.ColumnIndex == dgv_Sepet.Columns["Adet"].Index)
            //{
            //    // Seçilen ürün
            //    var seciliUrun = (tbl_Parca)dgv_Sepet.Rows[e.RowIndex].DataBoundItem;

            //    // Adet değeri değiştiğinde fiyatı yeniden hesapla
            //    decimal toplamFiyat = (decimal)(seciliUrun.Adet * seciliUrun.BirimFiyati); // Toplam fiyatı decimal olarak hesapla

            //    // Sepetteki Fiyat kolonunu güncelle
            //    dgv_Sepet.Rows[e.RowIndex].Cells["Fiyat"].Value = toplamFiyat;

            //    // Sepet toplamını güncelle
            //    SepetToplaminiGuncelle();
            //}

            // Eğer Adet sütununda bir değişiklik yapıldıysa
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_Sepet.Columns["Adet"].Index)
            {
                // Seçilen ürünü al
                var seciliUrun = (tbl_Parca)dgv_Sepet.Rows[e.RowIndex].DataBoundItem;

                // Adet değiştiğinde fiyatı yeniden hesapla
                decimal toplamFiyat = (decimal)(seciliUrun.Adet * seciliUrun.BirimFiyati);

                // Sepetteki Fiyat kolonunu güncelle
                dgv_Sepet.Rows[e.RowIndex].Cells["Fiyat"].Value = toplamFiyat;

                // Sepet toplamını güncelle
                SepetToplaminiGuncelle();
            }


        }

        private void dgv_Sepet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli satır seçildi mi?
            {
                DataGridViewRow row = dgv_Sepet.Rows[e.RowIndex];
                tbl_Parca seciliUrun = (tbl_Parca)row.DataBoundItem;

                // Adet sayısını bir azalt
                if (seciliUrun.Adet > 1)
                {
                    seciliUrun.Adet--; // Adeti bir azalt
                }
                else
                {
                    // Adet 1 ise, ürünü sepetteki listeden kaldır
                    sepet.Remove(seciliUrun);
                }

                // Sepeti güncelle
                dgv_Sepet.DataSource = null; // Mevcut bağlamayı kaldır
                dgv_Sepet.DataSource = sepet; // Güncellenmiş sepeti bağlaa
                SepetToplaminiGuncelle();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SepetiGuncelle()
        {
            // Sepet içeriğini DataGridView'e bağlayın
            dgv_Sepet.DataSource = null; // Eski bağlamayı kaldır
            dgv_Sepet.DataSource = new BindingList<tbl_Parca>(sepet); // Güncellenmiş sepeti bağla

            // Sepet toplamını güncelle
            SepetToplaminiGuncelle();
        }
        decimal sepetTutar = 0;
        private void SepetToplaminiGuncelle()
        {
            decimal toplam = 0;

            // Sepetteki her ürünün toplam fiyatını hesapla
            foreach (var urun in sepet)
            {
                toplam += (decimal)(urun.Adet * urun.BirimFiyati); // Adet ve BirimFiyati çarpılır
            }

            sepetTutar = toplam;

            // Genel toplamı Label'a yazdır
            lbl_Toplam.Text = toplam.ToString("C2"); // C2 formatı ile para birimi şeklinde göster
        }

        private void btn_SatınAl_Click(object sender, EventArgs e)
        {
            // 1. Sepetteki ürünleri listeye dönüştür
            List<tbl_Parca> parcalar = SepetiParcaListesineDonustur();

            // 2. Sepette ürün yoksa hata mesajı göster
            if (parcalar.Count == 0)
            {
                MessageBox.Show("Sepet boş. Sipariş oluşturmak için önce ürün ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            tbl_Siparis siparis = new tbl_Siparis();
            siparis.ToplamTutar = sepetTutar;

            var sonuc = ShoppingManager.ShoppingCreate(siparis);
        
            if (sonuc == true)
            {
                var parcaEkleme = ShopDetailsManager.DetailsCreate(parcalar);
                if (parcaEkleme == true)
                {


                MessageBox.Show("Siparişiniz Alınmıştır :)");
                    frmFaturaReport frmFaturaReport = new frmFaturaReport();
                    frmFaturaReport.ShowDialog(this);

                   
                }
                else
                {
                MessageBox.Show("Siparişiniz Alınırken Parcalarda sorun çıktı");

                }


            }
            else
            {
                MessageBox.Show("Sipariş Alınırken Bir Sorun Oluştu");
            }
        }



        




        private List<tbl_Parca> SepetiParcaListesineDonustur()
        {
            List<tbl_Parca> parcaListesi = new List<tbl_Parca>();

            foreach (DataGridViewRow row in dgv_Sepet.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    tbl_Parca yeniParca = new tbl_Parca
                    {
                        ParcaId = Convert.ToInt32(row.Cells[0].Value),
                        ParcaAdi = row.Cells[1].Value.ToString(),
                        StokAdeti = Convert.ToInt32(row.Cells[4].Value),
                        BirimFiyati = Convert.ToDecimal(row.Cells[5].Value),
                        Adet = Convert.ToInt32(row.Cells[6].Value)
                    };

                    parcaListesi.Add(yeniParca);
                }
            }

            return parcaListesi;
        }




    }
}
