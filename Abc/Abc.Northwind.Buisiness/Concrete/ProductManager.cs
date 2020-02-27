using Abc.Northwind.Buisiness.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Buisiness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int CategoryId)
        {
            return _productDal.GetList(p=>p.CategoryId==CategoryId||CategoryId==0);
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
