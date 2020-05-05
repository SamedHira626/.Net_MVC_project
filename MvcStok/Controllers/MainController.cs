using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models;
using MvcStok.Models.Entity;
namespace MvcStok.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(tblRegistration obj)

        {
            if (ModelState.IsValid)
            {
                MvcDbStokEntities db = new MvcDbStokEntities();
                db.tblRegistration.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}