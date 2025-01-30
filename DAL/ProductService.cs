using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductService
    {
        public static bool ProductCreate(tbl_Parca parcalar)
        {

            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        vt.tbl_Parca.Add(parcalar);
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

        public static bool ProductUpdate(tbl_Parca parca)
        {
            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        var product = vt.tbl_Parca.Where(x => x.ParcaId == parca.ParcaId).SingleOrDefault();
                        product.ParcaAdi = parca.ParcaAdi;
                        product.Marka = parca.Marka;
                        product.Model = parca.Model;
                        product.StokAdeti = parca.StokAdeti;
                        product.BirimFiyati = parca.BirimFiyati;
                        product.TeknikDetaylar = parca.TeknikDetaylar;
                        product.GuncellemeTarihi = DateTime.Now;
                        product.KategoriID = parca.KategoriID;

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

        public static List<vUrunler> ProductList()
        {
            TechStokDBEntities vt = new TechStokDBEntities();

            var product = vt.vUrunlers.ToList();
            return product;

        }
       
        public static tbl_Parca ProductGetID(int id)
        {
            TechStokDBEntities vt = new TechStokDBEntities();

            var sonuc = vt.tbl_Parca.FirstOrDefault(x => x.ParcaId == id);

            return sonuc;

        }

        public static vUrunler ProductByIDList(int id)
        {
            TechStokDBEntities vt = new TechStokDBEntities();

            var sonuc = vt.vUrunlers.FirstOrDefault(x => x.ParcaId == id);

            return sonuc;
        }
        public static List<vUrunler> ProductByCategoryIDList(int id)
        {
            TechStokDBEntities vt = new TechStokDBEntities();

            var sonuc = vt.vUrunlers.Where(x=>x.KategoriID == id).ToList();

            return sonuc;


        }
        public static bool ProductControlID(int id)
        {
            TechStokDBEntities vt = new TechStokDBEntities();

            var sonuc = vt.vUrunlers.Where(x => x.ParcaId == id).ToList();//ParçaID yi kontrol eder , eğer öyle bir ID varsa true döner
            if (sonuc.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static List<tbl_Parca> ProductGetOutOfStock()
        {
            TechStokDBEntities vt = new TechStokDBEntities ();
            var sonuc = vt.tbl_Parca.Where(p=>p.StokAdeti==0).ToList();
            return sonuc;
        }


        public static List<vw_TopSellingProducts> ProductGetPopular()
        {
            TechStokDBEntities vt = new TechStokDBEntities ();
            var sonuc = vt.vw_TopSellingProducts.ToList();
            return sonuc;

        }

    }
}
