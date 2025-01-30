using DAL;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ShoppingManager
    {

        public static bool ShoppingCreate(tbl_Siparis siparis)
        {
            siparis.KullaniciID = UserService.CurrentUser.KullaniciId;
            siparis.SiparisDurumu = "Sipariş Alındı";
            siparis.SiparisTarihi  = DateTime.Now;

            tbl_Loglar logger = new tbl_Loglar(); //Kullanıcı Kayıdını Logluyoruz  
            logger.KullaniciID = UserService.CurrentUser.KullaniciId;
            logger.IslemTarihi = DateTime.Now;
            logger.Islem = "Sipariş Verildi";
            var log = LogManager.LogEkle(logger);
            bool sonuc = ShoppingService.ShoppingCreate(siparis);
            if (sonuc == true)
            {
                return true;
            }
            return false;
        }

        public static List<tbl_Siparis> ShoppingByKullaniciID(int id)
        {
            var sonuc = ShoppingService.ShoppingByKullaniciID(id);
            return sonuc;

        }

        public static tbl_Siparis ShoppingGetID(int id)
        {
            var sonuc = ShoppingService.ShoppingGetID(id);
            return sonuc;

        }


    }
}
