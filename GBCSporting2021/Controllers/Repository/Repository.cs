using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;
using Microsoft.EntityFrameworkCore;

namespace GBCSporting2021.Controllers.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected Context ctx { get; set; }
        private DbSet<T> dbset { get; set; }

        public Repository(Context context)
        {
            ctx = context;
            dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> List()
        {
            return dbset.ToList();
        }

        public virtual T Get(int id) => dbset.Find(id);
        public virtual void Insert(T entity) => dbset.Add(entity);
        public virtual void Update(T entity) => dbset.Update(entity);
        public virtual void Delete(T entity) => dbset.Remove(entity);
        public virtual void Save() => ctx.SaveChanges();

    }
}
