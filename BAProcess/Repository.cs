using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BAProvider;

namespace BAProcess
{
    /// <summary>
    /// Her Nesneye özel işlemlerin yapılabileceği generic Repository Pattern
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> where T : class
    {
        IObjectContextAdapter _context;
        IObjectSet<T> _objectSet;

        public Repository()
        {
            _context = BAContextProvider.DB;
            _objectSet = _context.ObjectContext.CreateObjectSet<T>();
        }

        public T First(Expression<Func<T, bool>> where)
        {

            return _objectSet.First(where);
        }

        public void Delete(T entity)
        {
            _objectSet.DeleteObject(entity);
            _context.ObjectContext.SaveChanges();
        }

        public bool Add(T entity)
        {
            _objectSet.AddObject(entity);
            _context.ObjectContext.SaveChanges();
            return true;
        }

        public List<T> GetAll()
        {
            List<T> liste = _objectSet.ToList();
            return liste;
        }

        public bool UpdateSaveChanges()
        {
            _context.ObjectContext.SaveChanges();
            return true;
        }
        
        public List<T> SortByWhere<F>(Expression<Func<T, F>> where)
        {
            return _objectSet.OrderBy(where).ToList();
        }
        
        public List<T> ListByWhere(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }

    }
}
