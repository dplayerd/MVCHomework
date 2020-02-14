using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryMVC.ViewModels;
using TryMVC.ORM;

namespace TryMVC.Services
{
    public class HomeworkService
    {
        public List<HomeworkViewModel> GetList()
        {
            var context = new HomeworkDBEntities();

            int i = 0;
            var list =
                (from item in context.AccountBook
                 select new HomeworkViewModel()
                 {
                     Amount = item.Amounttt,
                     Name = item.Remarkkk,
                     Type = item.Categoryyy,
                     TypeName = (item.Categoryyy == 0) ? "收入" : "支出",
                     CreateDate = DateTime.Now
                 }).ToList();


            return list;
        }
    }
}