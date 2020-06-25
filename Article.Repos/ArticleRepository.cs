using Article.Data.Model;
using Article.Repos.Contracts;
using System;
using System.Collections.Generic;

namespace Article.Repos
{
    public class ArticleRepository : GenericRepository<Articles>, IArticleRepository
    {
        private readonly ArticleProjectContext _DbContext;
        public ArticleRepository(ArticleProjectContext context) : base(context)
        {
            this._DbContext = context;
        }
    }
}
