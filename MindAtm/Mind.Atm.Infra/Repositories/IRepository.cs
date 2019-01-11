using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Mind.Atm.Infra.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Save(T instance);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> where);
    }
}
