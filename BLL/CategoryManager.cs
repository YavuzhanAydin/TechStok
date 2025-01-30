using DAL;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryManager
    {
        public static bool CategoryCreate(string KategoriAdi, string KategoriAciklama)
        {
            tbl_Kategori kategori = new tbl_Kategori();
            kategori.KategoriAdi = KategoriAdi;
            kategori.KategoriAciklama = KategoriAciklama;
            bool sonuc = CategoryService.CategoryCreate(kategori);
            if (sonuc == true)
            {

                tbl_Loglar logger = new tbl_Loglar(); //Kullanıcı Kayıdını Logluyoruz  
                logger.KullaniciID = UserService.CurrentUser.KullaniciId;
                logger.IslemTarihi = DateTime.Now;
                logger.Islem = "Kategori Ekleme";
                var log = LogManager.LogEkle(logger);


                return true;
            }
            return false;

        }

        public static bool CategoryUpdate(int KategoriID,string KategoriAdi,string KategoriAciklama)
        {
            tbl_Kategori category = new tbl_Kategori();
            category.KategoriId = KategoriID;
            category.KategoriAdi= KategoriAdi;
            category.KategoriAciklama= KategoriAciklama;

            var sonuc = CategoryService.CategoryUpdate(category);
            if (sonuc == true)
            {

                tbl_Loglar logger = new tbl_Loglar(); //Kullanıcı Kayıdını Logluyoruz  
                logger.KullaniciID = UserService.CurrentUser.KullaniciId;
                logger.IslemTarihi = DateTime.Now;
                logger.Islem = "Kategori Güncelleme " +  "KategoriID = "+  category.KategoriId ;
                var log = LogManager.LogEkle(logger);

                return true;//Kategory güncellendi

            }
            else
            {
                return false;//Kategory Güncellenmedi
            }
        }

        public static bool CategoryDelete(int categoryID)
        {
            var sonuc = CategoryService.CategoryDelete(categoryID);
            if (sonuc == true)
            {
                tbl_Loglar logger = new tbl_Loglar(); //Kullanıcı Kayıdını Logluyoruz  
                logger.KullaniciID = UserService.CurrentUser.KullaniciId;
                logger.IslemTarihi = DateTime.Now;
                logger.Islem = "Kategori Silme " + "KategoriID = " + categoryID;
                var log = LogManager.LogEkle(logger);

                return true;

            }
            else
            {
                return false;
            }
        }


        public static List<tbl_Kategori> CategoryList()
        {
            return CategoryService.CategoryList();
        }

        public static tbl_Kategori CategoryFindByID(int id)
        {
            var sonuc = CategoryService.CategoryFindByID(id);
            return sonuc;

        }

        public static bool CategoryControl(int CategoryID)
        {
            var sonuc = CategoryService.CategoryControl(CategoryID);
            if (sonuc == true)
            {
                return true;//Böyle bir kategori bulunmaktadır
            }
            else { return false; }//böyle bir kategori yok

        }


    }
}
