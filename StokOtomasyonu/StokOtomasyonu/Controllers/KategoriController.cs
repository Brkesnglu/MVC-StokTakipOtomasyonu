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
    public class KategoriController : Controller
    {
        // GET: Kategori
        VeritabanıEntitiesContainer db = new VeritabanıEntitiesContainer();
        public ActionResult Index(int sayfa=1)
        {
            var kategoriList = db.TBLKATEGORILERSet.ToList().ToPagedList(sayfa, 4);
            //List<TBLKATEGORILER> kategoriList = db.TBLKATEGORILERSet.ToList();
            return View(kategoriList);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKategori(TBLKATEGORILER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniKategori");
            }
            db.TBLKATEGORILERSet.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var kategori = db.TBLKATEGORILERSet.Find(id);
            db.TBLKATEGORILERSet.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.TBLKATEGORILERSet.Find(id);
            return View("KategoriGetir", ktgr);
        }
        public ActionResult Guncelle(TBLKATEGORILER p1)
        {
            var ktg = db.TBLKATEGORILERSet.Find(p1.KATEGORIID);
            ktg.KATEGORIAD = p1.KATEGORIAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}