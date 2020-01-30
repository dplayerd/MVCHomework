using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryMVC.Models;

namespace TryMVC.Controllers
{
    public class CAController : Controller
    {
        // GET: CA
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult AR()
        {
            List<CAModel> list = new List<CAModel>()
            {
                new CAModel() { ID = 1, Name = "Name1" },
                new CAModel() { ID = 2, Name = "Name2" }
            };

            return View(list);
        }
    }
}