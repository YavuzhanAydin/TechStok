using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.Configuration.Install;
using System.ComponentModel;
namespace LogService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        private ServiceProcessInstaller serviceProcessInstaller;
        private ServiceInstaller serviceInstaller;

        public ProjectInstaller()
        {
            // ServiceProcessInstaller ayarları
            serviceProcessInstaller = new ServiceProcessInstaller
            {
                Account = ServiceAccount.LocalSystem // Servisin çalışacağı hesap
            };

            // ServiceInstaller ayarları
            serviceInstaller = new ServiceInstaller
            {
                ServiceName = "LogService", // Servis adı
                DisplayName = "Log Service", // Görünen isim
                Description = "Bu servis loglama işlemi yapar.", // Açıklama
                StartType = ServiceStartMode.Automatic // Otomatik başlatma
            };

            // Installere ekleme
            Installers.Add(serviceProcessInstaller);
            Installers.Add(serviceInstaller);
        }
    }

}
