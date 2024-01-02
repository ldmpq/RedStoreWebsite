using Microsoft.AspNet.Identity;
using RedStoreWebsite.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedStoreWebsite.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            ViewBag.ThanhTien = CartBUS.Thanhtien(User.Identity.GetUserId());
            return View(CartBUS.Danhsach(User.Identity.GetUserId()));
        }

        [HttpPost]
        public ActionResult Them (string masp, int soluong, int dongia, string tensp)
        {
            try
            {
                CartBUS.Them(masp, User.Identity.GetUserId(), soluong, dongia, tensp);
                return RedirectToAction("index");
            }
            catch
            {
                return RedirectToAction(".../Shop/index");
            }
        }
    }
}