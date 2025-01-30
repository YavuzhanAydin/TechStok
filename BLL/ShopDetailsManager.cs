using DAL;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ShopDetailsManager
    {
        public static bool DetailsCreate(List<tbl_Parca> parcalar)
        {

            tbl_Loglar logger = new tbl_Loglar(); //Kullanıcı Kayıdını Logluyoruz  
            logger.KullaniciID = UserService.CurrentUser.KullaniciId;
            logger.IslemTarihi = DateTime.Now;
            logger.Islem = "Sipariş Verildi";
            var log = LogManager.LogEkle(logger);

            bool sonuc = ShopDetailsService.DetailsCreate(parcalar);
            if (sonuc == true)
            {
                return true;
            }
            return false;
        }

        public static List<vSiparis> DetailsGetID(int id)
        {
            var sonuc = ShopDetailsService.DetailsGetID(id);
            return sonuc;


        }

    }
}
