using Abc.Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.Mvc.WebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int PageSize { get; internal set; }
        public int PageCount { get; internal set; }
    }
}
