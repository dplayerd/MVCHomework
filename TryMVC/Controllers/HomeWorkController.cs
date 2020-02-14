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
            //List<HomeworkViewModel> list = new List<HomeworkViewModel>();
            //Random random = new Random(DateTime.Now.Millisecond);


            //for (var i = 0; i < 100; i++)
            //{
            //    var y = DateTime.Now.Year;
            //    var month = DateTime.Now.Month;
            //    var d = random.Next(1, 30);
            //    var h = random.Next(0, 23);
            //    var m = random.Next(0, 59);
            //    var amount = random.Next(1, 100) * 100;

            //    var type = random.Next(0, 2);

            //    list.Add(new HomeworkViewModel()
            //    {
            //        ID = i,
            //        Name = "Name" + i,
            //        Type = type,
            //        TypeName = (type == 0) ? "收入" : "支出",
            //        CreateDate = new DateTime(y, month, d, h, m, 0),
            //        Amount = amount
            //    });
            //}


            var list = new HomeworkService().GetList();
            list = list.OrderBy(item => item.CreateDate).ToList();

            return View(list);
        }
    }
}