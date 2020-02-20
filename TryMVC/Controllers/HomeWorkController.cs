using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryMVC.Services;
using TryMVC.ViewModels;

namespace TryMVC.Controllers
{
    public class HomeWorkController : Controller
    {
        // GET: HomeWork
        public ActionResult Index()
        {
            return View();
        }


        [ChildActionOnly]
        public ActionResult ListPage()
        {
            var list = new HomeworkService().GetList();
            list = list.OrderBy(item => item.CreateDate).ToList();

            return View(list);
        }


        [HttpPost]
        public ActionResult Create(HomeworkViewModel model)
        {
            new HomeworkService().Create(model);

            return RedirectToAction("Index");
        }



        public ActionResult Delete(string id)
        {
            var gid = new Guid(id);

            new HomeworkService().Delete(gid);

            return RedirectToAction("Index");
        }
    }
}