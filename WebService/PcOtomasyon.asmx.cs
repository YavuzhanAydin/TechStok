using BLL;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for PcOtomasyon
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PcOtomasyon : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [System.Xml.Serialization.XmlInclude(typeof(vKullanicilar))]
        public ArrayList TumKullanicilariListele()
        {
            List<vKullanicilar> kullanicilar = UserManager.UserList();
            ArrayList liste = new ArrayList();
            foreach (var item in kullanicilar)
            {
                liste.Add(item);
            }
            return liste;
        }

       


    }
}
