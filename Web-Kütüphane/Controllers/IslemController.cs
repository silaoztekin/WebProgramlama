using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Kütüphane.Models.Entity;

namespace Web_Kütüphane.Controllers
{
    public class IslemController : Controller
    {
        // GET: Islem
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLHAREKET.Where(x => x.ISLEMDURUM == true).ToList();
            return View(degerler);
        }
    }
}