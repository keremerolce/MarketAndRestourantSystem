using Abc.Northwind.Buisiness.Abstract;
using Abc.Northwind.Entity.Concrete;
using Abc.Northwind.Mvc.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;

namespace Abc.Northwind.Mvc.WebUI.Components
{
    public class CategoryList : ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoryList(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Category> Categories { get; private set; }

        public ViewViewComponentResult Invoke()
        {
            var model =new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])
            };
            return View(model);  
        }
    }
}
