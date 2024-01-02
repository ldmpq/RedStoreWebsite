using RedStoreWebsite.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedStoreWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dbF = HomeBUS.DanhsachFeatured();
            var dbL = HomeBUS.DanhsachLastest();

            ViewBag.FeaturedProduct = dbF;
            ViewBag.LastestProduct = dbL;

            return View(); 
        }
        public ActionResult Details(String id)
        {
            var db = HomeBUS.Chitiet(id);
            return View(db);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}