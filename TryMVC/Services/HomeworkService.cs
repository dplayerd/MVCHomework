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
                     ID = item.Id,
                     Amount = item.Amounttt,
                     Name = item.Remarkkk,
                     Type = item.Categoryyy,
                     TypeName = (item.Categoryyy == 0) ? "收入" : "支出",
                     CreateDate = item.Dateee
                 }).ToList();


            return list;
        }


        public void Create(HomeworkViewModel model)
        {
            var context = new HomeworkDBEntities();

            var item = new ORM.AccountBook();

            item.Id = Guid.NewGuid();
            item.Amounttt = (int)model.Amount;
            item.Categoryyy = model.Type;
            item.Remarkkk = model.Name;
            item.Dateee = model.CreateDate;

            context.AccountBook.Add(item);
            context.SaveChanges();
        }


        public void Update(HomeworkViewModel model)
        {
            var context = new HomeworkDBEntities();

            var item = context.AccountBook.Where(obj => model.ID == obj.Id).FirstOrDefault();

            if (item != null)
            {
                item.Amounttt = (int)model.Amount;
                item.Categoryyy = model.Type;
                item.Remarkkk = model.Name;
                item.Dateee = model.CreateDate;

                context.SaveChanges();
            }
        }


        public void Delete(Guid id)
        {
            var context = new HomeworkDBEntities();

            var item = context.AccountBook.Where(obj => id == obj.Id).FirstOrDefault();

            if (item != null)
            {
                context.AccountBook.Remove(item);
                context.SaveChanges();
            }
        }
    }
}