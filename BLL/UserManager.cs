using DAL;
using Helpers;
using DAL.KimlikSorgula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserManager
    {

        public static bool  UserRegister(long TCNO ,string KullaniciAdi,string KullaniciSifre,string Adi,string Soyad,string Email,DateTime DogumTarihi)
        {
            tbl_Kullanicilar user = new tbl_Kullanicilar();
            user.TCNO = TCNO;
            user.KullaniciAdi = KullaniciAdi;
            user.KullaniciSifre = KullaniciSifre;
            user.Ad = Adi;
            user.Soyad = Soyad;
            user.Email = Email;
            user.YetkiSeviyesi = 2;
            user.KayitTarihi = DateTime.Now;
            user.SonGirisTarihi = DateTime.Now;
            user.DogumTarihi = DogumTarihi;
            user.SicilNo = UserService.UserRegCreate();
           
            tbl_Loglar logger = new tbl_Loglar(); //Kullanıcı Kayıdını Logluyoruz  
            logger.KullaniciID = UserService.CurrentUser.KullaniciId;
            logger.IslemTarihi = DateTime.Now;
            logger.Islem = "Kullanıcı Kayıt";
            var log = LogManager.LogEkle(logger);

            bool sonuc = DAL.UserService.UserCreate(user);
            if (sonuc == true)
            {
                return true;
            }
            return false;
        }
        public static tbl_Kullanicilar UserLogin(string KullaniciAdi,string KullaniciSifre)
        {
            tbl_Kullanicilar sonuc = UserService.UserLoginControl(KullaniciAdi, KullaniciSifre);

            if (sonuc != null)
            {
                return sonuc ; //Kullanıcı Sisteme Giriş Yapıyor
            }
            else
            {
                return null;//Kullanıcı Sisteme Giremiyor
            }
        }

        public static bool UserUpdate(tbl_Kullanicilar user)
        {
            var sonuc = UserService.UserUpdate(user);
            if (sonuc == true)
            {
                tbl_Loglar logger = new tbl_Loglar(); //Kullanıcı Kayıdını Logluyoruz  
                logger.KullaniciID = UserService.CurrentUser.KullaniciId;
                logger.IslemTarihi = DateTime.Now;
                logger.Islem = "Kullanıcı Güncelleme" + " " + user.KullaniciId;
                bool log = LogManager.LogEkle(logger);
                return true;//kullanıcı güncellendi

            }
            else
            {
                return false;//Kullanıcı Güncellenmedi
            }
        }

        public static bool UserDelete(int KullaniciID)
        {
            var sonuc = UserService.UserDelete(KullaniciID);
            if (sonuc == true)
            {
                return true;

            }
            else
            {
                return false ;
            }
        }
        public static tbl_Kullanicilar UserFindByRegNo(int SicilNo)// SicilNoya göre bul
        {
            var sonuc = UserService.UserFindByReg(SicilNo);
            return sonuc;

        }

        public static List<tbl_Yetki> UserRoleList()
        {
            return UserService.UserRoleList(); 
        }

        public static List<vKullanicilar> UserList()
        {
            var sonuc = UserService.UserList();

            return sonuc;
        }

        public static tbl_Kullanicilar UserListID(int id)
        {
            var sonuc = UserService.UserListID(id);

            return sonuc;
        }



        public static tbl_Kullanicilar UserFindByUsername(string KullaniciAdi)
        {
            var sonuc = UserService.UserFindByUsername(KullaniciAdi);
            return sonuc;

        }
           


       


    }
}
