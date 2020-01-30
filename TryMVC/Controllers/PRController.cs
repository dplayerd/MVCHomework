using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryMVC.Models;

namespace TryMVC.Controllers
{
    public class PRController : Controller
    {
        // GET: PR
        public ActionResult Index()
        {
            List<PRModel> list = new List<PRModel>()
            {
                new PRModel(){ ID = 1, Name = "Name1" },
                new PRModel(){ ID = 2, Name = "Name2" }
            };

            return View(list);
        }
    }
}