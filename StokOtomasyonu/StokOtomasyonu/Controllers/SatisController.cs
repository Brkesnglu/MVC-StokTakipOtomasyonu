using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokOtomasyonu.Models;

namespace StokOtomasyonu.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        VeritabanıEntitiesContainer db = new VeritabanıEntitiesContainer();
        public ActionResult Index()
        {
            var satislar = db.TBLSATISLARSet.ToList();
            return View(satislar);
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(TBLSATISLAR p)
        {
            db.TBLSATISLARSet.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
    
}