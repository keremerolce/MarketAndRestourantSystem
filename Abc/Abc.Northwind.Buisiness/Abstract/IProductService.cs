using Abc.Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Buisiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int CategoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
