using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShoppingService
    {
        public static bool ShoppingCreate(tbl_Siparis siparis)
        {

            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        vt.tbl_Siparis.Add(siparis);
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

        public static int ShoppingLastGetID()
        {
            TechStokDBEntities vt = new TechStokDBEntities();
            var sonuc = vt.tbl_Siparis.OrderByDescending(s=>s.SiparisId).FirstOrDefault();
            int id = sonuc.SiparisId;
            return id;
        }

        public static List<tbl_Siparis> ShoppingByKullaniciID(int id)
        {
            TechStokDBEntities vt = new TechStokDBEntities();
            var sonuc = vt.tbl_Siparis.Where(p => p.KullaniciID == id).ToList();
            return sonuc;

        }

        public static tbl_Siparis ShoppingGetID(int id)
        {
            TechStokDBEntities vt = new TechStokDBEntities();
            var sonuc = vt.tbl_Siparis.FirstOrDefault(p=>p.SiparisId == id);
            return sonuc;


        }


    }
}
