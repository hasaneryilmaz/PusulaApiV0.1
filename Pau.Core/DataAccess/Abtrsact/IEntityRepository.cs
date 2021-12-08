using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Pau.Core.DataAccess.Abtrsact
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T GetById(Expression<Func<T, bool>> filter);

        T Create(T entity);

        T Update(T entity);

        void Delete(int id);
    }
}
