using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Atm.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly DataContext context = new DataContext();

        public void Save(T instance)
        {
            context.Set<T>().Add(instance);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return context.Set<T>().FirstOrDefault(where);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
        {
            return context.Set<T>().Where(where);
        }
    }
}
