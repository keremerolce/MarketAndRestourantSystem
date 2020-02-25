using Abc.Core.DataAccess;
using Abc.Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
