using Abc.Northwind.Entity.Concrete;
using System.Collections.Generic;

namespace Abc.Northwind.Buisiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
