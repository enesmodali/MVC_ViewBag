using Ornek1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ornek1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Kategori> kategoriler = new List<Kategori>
            {
                new Kategori{ ID=1,KategoriAdi="Yiyecekler",Aciklama="Yemek yemek güzeldir."},
                new Kategori{ ID=2,KategoriAdi="İçecekler",Aciklama="Soğuk içiniz."},
                new Kategori{ ID=3,KategoriAdi="Sebzeler",Aciklama="Faydalıdır."},
                new Kategori{ ID=4,KategoriAdi="Meyveler",Aciklama="Mandalina kış meyvesidir."},
                new Kategori{ ID=5,KategoriAdi="Kuruyemişler",Aciklama="Fındık fıstık oooo :)"}
            };
            ViewBag.KategoriListesi = kategoriler;

            return View();
        }

        
    }
}