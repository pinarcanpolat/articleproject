using Article.Data.Model;
using Article.Repos.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Repos
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ArticleProjectContext _DbContext;
        private readonly DbSet<T> _DbSet;
        

        public GenericRepository(ArticleProjectContext context)
        {
            this._DbContext = context;
            this._DbSet = this._DbContext.Set<T>();
        }

        public void Add(T entity)
        {

            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
