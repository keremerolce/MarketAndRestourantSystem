using Abc.Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.Mvc.WebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get;  set; }
        public int CurrentCategory { get; internal set; }
    }
}
