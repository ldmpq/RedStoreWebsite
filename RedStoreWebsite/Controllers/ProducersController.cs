﻿using PagedList;
using RedStoreWebsite.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedStoreWebsite.Controllers
{
    public class ProducersController : Controller
    {
        // GET: Producers
        public ActionResult Index(String id, int page = 1, int pagesize = 8)
        {
            var ds = ProducersBUS.Chitiet(id).ToPagedList(page, pagesize);
            return View(ds);
        }
    }
}