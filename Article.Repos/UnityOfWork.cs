using Article.Data.Model;
using Article.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Article.Repos
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly ArticleProjectContext _DbContext;

        public ArticleRepository ArticleRepository { get; private set; }
        public CommentRepository CommentRepository { get; private set; }

        public UnityOfWork(ArticleProjectContext context)
        {
            this._DbContext = context;
            this.ArticleRepository = new ArticleRepository(this._DbContext);
            this.CommentRepository = new CommentRepository(this._DbContext);
        }
        public async Task Commit()
        {
            await this._DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            this._DbContext.Dispose();
        }
    }
}
