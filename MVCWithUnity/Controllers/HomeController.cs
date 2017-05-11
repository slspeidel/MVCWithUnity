using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MVCWithUnity.Domain;

namespace MVCWithUnity.Controllers
{
    public class HomeController : Controller
    {
        private IMappingDataSource _db;

        [InjectionConstructor]
        public HomeController(IMappingDataSource db)
        {
            _db = db;
        }

        //public HomeController()
        //{ }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Items()
        {
            var model = _db.Items;
            ViewData["RowsPerPage"] = 5;
            return View(model);
        }

        public ActionResult OtherItems()
        {
            var model = _db.OtherItems;
            ViewData["RowsPerPage"] = 5;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
