using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShopDetailsService
    {
        public static bool DetailsCreate(List<tbl_Parca> parcalar)
        {
            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var parca in parcalar)
                        {
                            tbl_SiparisDetay siparisDetay = new tbl_SiparisDetay
                            {
                                SiparisID = Convert.ToInt32(ShoppingService.ShoppingLastGetID()),
                                ParcaID = parca.ParcaId,
                                Adet = parca.Adet,
                                BirimFiyati = parca.BirimFiyati,
                                AraToplam = parca.Adet * parca.BirimFiyati
                            };

                            vt.tbl_SiparisDetay.Add(siparisDetay);

                            var sonuc = vt.tbl_Parca.FirstOrDefault(p => p.ParcaId == parca.ParcaId);
                            if (sonuc != null)
                            {
                                sonuc.StokAdeti -= parca.Adet; // Stok güncellemesi
                            }
                        }

                        vt.SaveChanges(); // Tüm değişiklikler bir kerede kaydedilir
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


        public static List<vSiparis> DetailsGetID(int id) 
        {
            TechStokDBEntities vt   = new TechStokDBEntities();

            var sonuc = vt.Database.SqlQuery<vSiparis>(
                        "SELECT * FROM vSiparis WHERE SiparisId = @p0", id).ToList();

            return sonuc;

        }



    }
}
