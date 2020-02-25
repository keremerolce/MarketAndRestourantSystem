using Abc.Northwind.Buisiness.Abstract;
using Abc.Northwind.Entity.Concrete;
using Abc.Northwind.Mvc.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Collections.Generic;

namespace Abc.Northwind.Mvc.WebUI.ViewsComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Category> Categories { get; private set; }

        public ViewViewComponentResult Invoke()
        {
            var model =new CategoryListViewModel
            {
                Categories=_categoryService.GetAll()
            };
            return View(model);  
        }
    }
}
