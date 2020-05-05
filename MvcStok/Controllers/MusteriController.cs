using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;
using PagedList;
using PagedList.Mvc;
namespace MvcStok.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        MvcDbStokEntities db = new MvcDbStokEntities();

        public ActionResult Index(int sayfa = 1)
        {
            var degerler = db.TBLMUSTERILER.ToList().ToPagedList(sayfa, 10);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteri() // GET Ve POST sayfayı yeniliyince de boş eklemesin diye
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
            db.TBLMUSTERILER.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SIL(int id)
        {
            var musteri = db.TBLMUSTERILER.Find(id);
            db.TBLMUSTERILER.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(int id)
        {
            var mst = db.TBLMUSTERILER.Find(id);
            return View("MusteriGetir", mst);
        }
        public ActionResult Guncelle(TBLMUSTERILER p1)
        {
            var mst = db.TBLMUSTERILER.Find(p1.MUSTERIID);
            mst.MUSTERIAD = p1.MUSTERIAD;
            mst.MUSTERISOYAD = p1.MUSTERISOYAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}