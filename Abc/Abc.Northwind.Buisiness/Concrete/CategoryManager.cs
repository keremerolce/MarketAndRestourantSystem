﻿using Abc.Northwind.Buisiness.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Buisiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
