using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class LogManager
    {
        public static bool Logla(int KullaniciID, DateTime IslemTarihi, string Islem)
        {
            tbl_Loglar loglar = new tbl_Loglar();
            loglar.KullaniciID = KullaniciID;
            loglar.IslemTarihi = IslemTarihi;
            loglar.Islem = Islem;

            var sonuc = LogEkle(loglar);
            if (sonuc == true)
            {
                return true;//log eklendiyse true döner
            }
            else
            {
                return false;//log eklenmezse False döner
            }


        }
       
        public static bool LogEkle(tbl_Loglar log)
        {
            using (TechStokDBEntities vt = new TechStokDBEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        LogTXT(log);
                        vt.tbl_Loglar.Add(log);
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

       
        public static void LogTXT(tbl_Loglar loglar)
        {
            string _logFilePath = @"D:\Case\Codes\TechStok\TechStok\bin\Debug\Loglar.txt";

            DosyaKontrol(); // Dosya yoksa oluştur
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {loglar.KullaniciID}  - {loglar.Islem}";

            using (StreamWriter writer = new StreamWriter(_logFilePath, true)) // Dosyanın sonuna ekle
            {
                writer.WriteLine(logMessage);
            }
        }


        private static void DosyaKontrol()
        {
            string _logFilePath = @"D:\Case\Codes\TechStok\TechStok\bin\Debug\Loglar.txt";

            if (!File.Exists(_logFilePath))
            {
                // Gerekli dizin yapısını oluştur
                Directory.CreateDirectory(Path.GetDirectoryName(_logFilePath) ?? string.Empty);

                // Dosyayı oluştur
                using (StreamWriter writer = new StreamWriter(_logFilePath))
                {
                   
                    writer.WriteLine("İŞLEM TARİHİ " + "|" + "KULLANICI ID " + "|" + "İŞLEM " );
                }
            }
        }



    }


}

