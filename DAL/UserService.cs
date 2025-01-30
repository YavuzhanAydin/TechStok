using DAL.KimlikSorgula;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Net;
using System.ServiceModel.Channels;
using System.Runtime.Remoting.Contexts;

namespace DAL
{
    public class UserService
    {

        public static tbl_Kullanicilar CurrentUser { get; set; }

        public static bool UserCreate(tbl_Kullanicilar kullanicilar)
        {
            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                      
                        long TCNO = Convert.ToInt64(kullanicilar.TCNO);
                        string Ad = kullanicilar.Ad.ToUpper();
                        string Soyad = kullanicilar.Soyad.ToUpper();
                        int DogumYili = Convert.ToInt32(kullanicilar.DogumTarihi.Value.Year);

                        KPSPublicSoapClient servis = new KPSPublicSoapClient();
                        bool sonuc = servis.TCKimlikNoDogrula(TCNO, Ad, Soyad, DogumYili);
                        if (sonuc == true)
                        {

                            vt.tbl_Kullanicilar.Add(kullanicilar);
                            vt.SaveChanges();


                            transaction.Commit();

                           

                            return true;
                        }
                        else
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        
                        return false;
                    }
                }
            }
        }

        public static tbl_Kullanicilar UserLoginControl(string KullaniciAdi,string KullaniciSifre)
        {
            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                tbl_Kullanicilar sonuc = vt.tbl_Kullanicilar.Where(x => x.KullaniciAdi == KullaniciAdi && x.KullaniciSifre == KullaniciSifre).SingleOrDefault();
                if (sonuc != null)
                {
                    sonuc.SonGirisTarihi = DateTime.Now;
                    vt.SaveChanges();


                    return sonuc;
                }
                else { return null; }
            }
        }
        
        public static List<vKullanicilar> UserList()
        {
            TechStokDBEntities vt = new TechStokDBEntities();
            var user =  vt.vKullanicilars.ToList();
            return user;

        }
        public static tbl_Kullanicilar UserListID(int id)
        {
            TechStokDBEntities vt = new TechStokDBEntities();
            var user = vt.tbl_Kullanicilar.Where(x => x.KullaniciId == id).SingleOrDefault();
            return user;

        }

        public static bool UserUpdate(tbl_Kullanicilar kullanici)
        {
            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        var user = vt.tbl_Kullanicilar.Where(x => x.KullaniciId == kullanici.KullaniciId).SingleOrDefault();
                        user.Ad = kullanici.Ad;
                        user.Soyad = kullanici.Soyad;
                        user.Email = kullanici.Email; 
                        user.SicilNo = kullanici.SicilNo;
                        user.YetkiSeviyesi = kullanici.YetkiSeviyesi;

                        vt.SaveChanges();
                        transaction.Commit();



                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public static bool UserDelete(int KullaniciID)
        {
            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        var sonuc = vt.tbl_Kullanicilar.Where(x=>x.KullaniciId == KullaniciID).SingleOrDefault();


                        vt.tbl_Kullanicilar.Remove(sonuc);
                        vt.SaveChanges();
                        transaction.Commit();

                        return true;
                    }
                    catch (Exception)
                    {

                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public static int UserRegCreate()//SicilNo Üretme
        {
            int sicilSayi;

            TechStokDBEntities vt = new TechStokDBEntities();
            List<tbl_Kullanicilar> kullaniciListesi = vt.tbl_Kullanicilar.OrderByDescending(x=>x.SicilNo).ToList();
            if (kullaniciListesi.Count >0 && kullaniciListesi != null)
            {
                 sicilSayi = Convert.ToInt32(kullaniciListesi[0].SicilNo + 1);

            }
            else
            {
                sicilSayi= 10000;

            }

            return sicilSayi;

        }

        public static tbl_Kullanicilar UserFindByReg(int SicilNo)//Sicil Noya göre bul
        {
            TechStokDBEntities vt = new TechStokDBEntities();   
            tbl_Kullanicilar sonuc = vt.tbl_Kullanicilar.Where(x=>x.SicilNo ==SicilNo ).SingleOrDefault();

            return sonuc;
            
        }
        public static tbl_Kullanicilar UserFindByUsername(string KullaniciAdi)
        {
            TechStokDBEntities vt = new TechStokDBEntities();
            return vt.tbl_Kullanicilar.FirstOrDefault(u => u.KullaniciAdi ==KullaniciAdi);


        }

        public static List<tbl_Yetki> UserRoleList()
        {   
            TechStokDBEntities vt =new TechStokDBEntities();
            
            var userRole = vt.tbl_Yetki.ToList();
            return userRole;


        }
       




    }
}
