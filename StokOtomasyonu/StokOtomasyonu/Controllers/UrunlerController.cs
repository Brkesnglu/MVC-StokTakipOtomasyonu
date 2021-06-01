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
    public class UrunlerController : Controller
    {
        // GET: Urunler
        VeritabanıEntitiesContainer db = new VeritabanıEntitiesContainer();
        public ActionResult Index(int sayfa=1)
        {

            var degerler = db.TBLURUNLERSet.ToList().ToPagedList(sayfa, 8);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            List<SelectListItem> degerler = (from i in db.TBLKATEGORILERSet.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(TBLURUNLER p1)
        {
            //var ktg = db.TBLKATEGORILERSet.Where(m => m.KATEGORIID == p1.URUNKATEGORI).FirstOrDefault();
            
            db.TBLURUNLERSet.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var urun = db.TBLURUNLERSet.Find(id);
            db.TBLURUNLERSet.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = db.TBLURUNLERSet.Find(id);
            return View("UrunGetir", urun);
        }
        public ActionResult Guncelle(TBLURUNLER p)
        {
            var urun = db.TBLURUNLERSet.Find(p.URUNID);
            urun.URUNAD = p.URUNAD;
            urun.MARKA = p.MARKA;
            urun.STOK = p.STOK;
            urun.FIYAT = p.FIYAT;
            urun.URUNKATEGORI = p.URUNKATEGORI;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}