using System;
using Helpers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace LogService
{
    public partial class LogService : ServiceBase
    {
        public LogService()
        {
            InitializeComponent();
            this.ServiceName = "LogService";
        }

        protected override void OnStart(string[] args)
        {

            LogTXTService();

            Console.WriteLine("Log servisi başladı.....");
        }

        protected override void OnStop()
        {
            Console.WriteLine("Log servisi Durduruldu.....");
        }


        void LogTXTService()
        {
            string _logFilePath = @"D:\Case\Codes\TechStok\TechStok\bin\Debug\LoglarService.txt";

            DosyaKontrol(); // Dosya yoksa oluştur
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Service  - Windows Servis Çalışıyor";

            using (StreamWriter writer = new StreamWriter(_logFilePath, true)) // Dosyanın sonuna ekle
            {
                writer.WriteLine(logMessage);
            }
        }
        void DosyaKontrol()
        {
            string _logFilePath = @"D:\Case\Codes\TechStok\TechStok\bin\Debug\LoglarService.txt";

            if (!File.Exists(_logFilePath))
            {
                // Gerekli dizin yapısını oluştur
                Directory.CreateDirectory(Path.GetDirectoryName(_logFilePath) ?? string.Empty);

                // Dosyayı oluştur
                using (StreamWriter writer = new StreamWriter(_logFilePath))
                {

                    writer.WriteLine("İŞLEM TARİHİ " + "|" + "KULLANICI ID " + "|" + "İŞLEM ");
                }
            }
        }




    }
}
