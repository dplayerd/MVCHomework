using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryMVC.ViewModels
{
    public class HomeworkViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal Amount { get; set; }
        public string TypeName { get; set; }
    }
}