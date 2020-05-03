using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMoney.Data;
using TMoney.Models;

namespace TMoney.Repositories
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext _context;
        protected DbSet<T> dbSet;

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public IList<T> FindAll()
        {
            return dbSet.ToList();
        }

        public void Save(T model)
        {
            dbSet.Add(model);
            _context.SaveChanges();
        }
    }
}
