using Abc.Core.DataAccess;
using Abc.Northwind.Entity.Concrete;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }

}
