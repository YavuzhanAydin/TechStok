using DAL;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductManager
    {
        public static bool ProductCreate(string ParcaAdi, string Marka, string Model, int StokAdeti, decimal BirimFiyati , string TeknikDetaylar , int KategoriID)
        {
           tbl_Parca parcalar = new tbl_Parca();
            parcalar.ParcaAdi = ParcaAdi;
            parcalar.Marka = Marka;
            parcalar.Model = Model;
            parcalar.StokAdeti = StokAdeti;
            parcalar.BirimFiyati = BirimFiyati;
            parcalar.TeknikDetaylar = TeknikDetaylar;
            parcalar.KategoriID = KategoriID;
            parcalar.EklenmeTarihi=DateTime.Now;
            parcalar.GuncellemeTarihi = DateTime.Now;
           
            tbl_Loglar logger = new tbl_Loglar(); //Kullanıcı Kayıdını Logluyoruz  
            logger.KullaniciID = UserService.CurrentUser.KullaniciId;
            logger.IslemTarihi = DateTime.Now;
            logger.Islem = "Ürün Ekleme";
            var log = LogManager.LogEkle(logger);
            bool sonuc = ProductService.ProductCreate(parcalar);
            if (sonuc == true)
            {
                return true;
            }
            return false;
        }

        public static bool ProductUpdate(int ParcaID,string ParcaAdi, string Marka, string Model, int StokAdeti, decimal BirimFiyati, string TeknikDetaylar, int KategoriID)
        {
            tbl_Parca parca = new tbl_Parca();
            parca.ParcaId = ParcaID;
            parca.ParcaAdi = ParcaAdi;
            parca.Marka = Marka;
            parca.Model = Model;
            parca.BirimFiyati= BirimFiyati;
            parca.StokAdeti = StokAdeti;
            parca.TeknikDetaylar= TeknikDetaylar;
            parca.KategoriID= KategoriID;

            tbl_Loglar logger = new tbl_Loglar(); //Kullanıcı Kayıdını Logluyoruz  
            logger.KullaniciID = UserService.CurrentUser.KullaniciId;
            logger.IslemTarihi = DateTime.Now;
            logger.Islem = "Parça Güncelleme" + " " + parca.ParcaId;
            var log = LogManager.LogEkle(logger);

            var sonuc = ProductService.ProductUpdate(parca);
            if (sonuc == true)
            {
                return true;//Parça güncellendi

            }
            else
            {
                return false;//Parça Güncellenmedi
            }
        }


        public static List<vUrunler> ProductList()
        {
            return ProductService.ProductList();
        }
        public static vUrunler ProductByIDList(int id)
        {
            var sonuc = ProductService.ProductByIDList(id);
            return sonuc;

        }

        public static List<vUrunler> ProductByCategoryIDList(int id)
        {
            var sonuc = ProductService.ProductByCategoryIDList(id);
            return sonuc;

        }

        public static bool ProductControlID(int id)
        {
            var sonuc = ProductService.ProductControlID(id);
            if (sonuc == true)
            {
                return true;
            }
            else
            {
                return false ;
            }

        }

        public static List<tbl_Parca> ProductGetOutOfStock()
        {
            var sonuc= ProductService.ProductGetOutOfStock();
            return sonuc;
        }

        public static List<vw_TopSellingProducts> ProductGetPopular()
        {
            var sonuc = ProductService.ProductGetPopular();
            return sonuc;
        }


    }
}
