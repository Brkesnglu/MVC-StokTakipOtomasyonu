using StokOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace StokOtomasyonu.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        VeritabanıEntitiesContainer db = new VeritabanıEntitiesContainer();
        public ActionResult Index(int sayfa=1)
        {
            var musteriList = db.TBLMUSTERILERSet.ToList().ToPagedList(sayfa, 4);
            //List<TBLMUSTERILER> musteriList = db.TBLMUSTERILERSet.ToList();
            return View(musteriList);
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(TBLMUSTERILER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMusteri");
            }
            db.TBLMUSTERILERSet.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var musteri = db.TBLMUSTERILERSet.Find(id);
            db.TBLMUSTERILERSet.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(int id)
        {
            var mus = db.TBLMUSTERILERSet.Find(id);
            return View("MusteriGetir", mus);
        }
        public ActionResult Guncelle(TBLMUSTERILER p1)
        {
            var musteri = db.TBLMUSTERILERSet.Find(p1.MUSTERIID);
            musteri.MUSTERIAD = p1.MUSTERIAD;
            musteri.MUSTERISOYAD = p1.MUSTERISOYAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}