﻿using Abc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Abc.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Verileri database'den çekmek için kullandığımız nesne  null default olarak atanır.
        //Kullanıcı veriler için bir şey girmez ise tüm veriler getirilir
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
