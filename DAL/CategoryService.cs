using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryService
    {
        public static bool CategoryCreate(tbl_Kategori category)
        {
            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        vt.tbl_Kategori.Add(category);
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

        public static bool CategoryUpdate(tbl_Kategori category)
        {
            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        var updateCategory = vt.tbl_Kategori.Where(x => x.KategoriId == category.KategoriId).SingleOrDefault();
                        updateCategory.KategoriAdi = category.KategoriAdi;
                        updateCategory.KategoriAciklama = category.KategoriAciklama;

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

        public static bool CategoryDelete(int categoryID)
        {
            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        var sonuc = vt.tbl_Kategori.Where(x => x.KategoriId == categoryID).SingleOrDefault();
                        vt.tbl_Kategori.Remove(sonuc);
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
     
        public static List<tbl_Kategori> CategoryList()
        {
            TechStokDBEntities vt = new TechStokDBEntities();
            var category = vt.tbl_Kategori.ToList();
            return category;

        }

        public static tbl_Kategori CategoryFindByID(int id)
        {
            TechStokDBEntities vt = new TechStokDBEntities();
            return vt.tbl_Kategori.FirstOrDefault(u => u.KategoriId == id);


        }

        public static bool CategoryControl(int CategoryID)
        {
            TechStokDBEntities vt = new TechStokDBEntities();
            var sonuc = vt.tbl_Kategori.Where(x=>x.KategoriId == CategoryID).ToList();
            if (sonuc.Count > 0)
            {
                return true;

            }
            else 
            {
                return false;
            }


        }


    }
}
