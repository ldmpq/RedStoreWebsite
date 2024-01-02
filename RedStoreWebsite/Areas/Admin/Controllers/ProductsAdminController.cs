using RedStoreWebsite.Models.BUS;
using ShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedStoreWebsite.Areas.Admin.Controllers
{
    public class ProductsAdminController : Controller
    {
        [Authorize(Roles = "Admin")]
        // GET: Admin/ProductsAdmin
        public ActionResult Index()
        {
            return View(ShopBUS.DanhsachAdmin());
        }

        // GET: Admin/ProductsAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/ProductsAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProductsAdmin/Create
        [HttpPost]
        public ActionResult Create( tbPRODUCT tbproduct)
        {
            try
            {
                // TODO: Add insert logic here
                ShopBUS.ThemProduct(tbproduct);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/ProductsAdmin/Edit/5
        public ActionResult Edit(String id)
        {
            return View(ShopBUS.Chitiet(id));
        }

        // POST: Admin/ProductsAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(String id, tbPRODUCT tbproduct)
        {
            try
            {
                // TODO: Add update logic here
                ShopBUS.SuaProduct(id, tbproduct);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/ProductsAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/ProductsAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
