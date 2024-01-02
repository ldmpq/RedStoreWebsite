using RedStoreWebsite.Models.BUS;
using ShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedStoreWebsite.Areas.Admin.Controllers
{
    public class ProducersAdminController : Controller
    {
        [Authorize(Roles = "Admin")]
        //--Hiện danh sách Admin--//
        // GET: Admin/ProducersAdmin
        public ActionResult Index()
        {
            var ds = ProducersBUS.DanhsachAdmin();
            return View(ds);
        }

        // GET: Admin/ProducersAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //--Tạo mới--//
        // GET: Admin/ProducersAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProducersAdmin/Create
        [HttpPost]
        public ActionResult Create( tbPRODUCER tbproducer)
        {
            try
            {
                // TODO: Add insert logic here
                ProducersBUS.ThemProducer(tbproducer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //--Sửa đổi--//
        // GET: Admin/ProducersAdmin/Edit/5
        public ActionResult Edit(String id)
        {

            return View(ProducersBUS.ChitietAdmin(id));
        }

        // POST: Admin/ProducersAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(String id, tbPRODUCER tbproducer)
        {
            try
            {
                // TODO: Add update logic here
                ProducersBUS.SuaProducer(id, tbproducer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //--Xóa--//
        // GET: Admin/ProducersAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/ProducersAdmin/Delete/5
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
