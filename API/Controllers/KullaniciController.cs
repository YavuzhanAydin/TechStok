using BLL;
using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class KullaniciController : ApiController
    {


        [HttpGet]
        [Route("api/Get/")]
        public IHttpActionResult Get()
        {

       
            return Ok(UserManager.UserList());

        }

        [HttpGet]
        [Route("api/GetKullaniciById/{id}")]
        public IHttpActionResult GetKullaniciById(int id)
        {

            return Ok(UserManager.UserListID(id));

        }

        [HttpGet]
        [Route("api/GetRoller")]
        public IHttpActionResult GetRoller()
        {
            string json = JsonConvert.SerializeObject(UserManager.UserRoleList());
            return Ok(json);
      

        }


        [HttpPost]
        [Route("api/PostKullanici")]
        public IHttpActionResult PostKullanici([FromBody] tbl_Kullanicilar  kul)
        {
            long TCNO = Convert.ToInt64(kul.TCNO);
            string KullaniciAdi = kul.KullaniciAdi;
            string Sifre = kul.KullaniciSifre;
            string Ad = kul.Ad;
            string Soyad = kul.Soyad;
            string Email = kul.Email;
            DateTime DogumTarihi = kul.DogumTarihi.Value;
            return Ok(UserManager.UserRegister(TCNO,KullaniciAdi,Sifre,Ad,Soyad,Email,DogumTarihi));
        }



    }
}
