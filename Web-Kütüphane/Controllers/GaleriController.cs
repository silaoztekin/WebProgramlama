﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Kütüphane.Models.Entity;
namespace Web_Kütüphane.Controllers
{
    public class GaleriController : Controller
    {
        // GET: Galeri
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Galeri()
        {
            return View();        
        }

    }
}