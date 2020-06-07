using Article.Data.Model;
using Article.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Repos
{
    public class CommentRepository : GenericRepository<Comments>, ICommentRepository
    {
        private readonly ArticleProjectContext _DbContext;
        public CommentRepository(ArticleProjectContext context) : base(context)
        {
            this._DbContext = context;
        }
        public Comments GetComment(int CommentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comments> GetComments()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comments> GetComments(int ArticleId)
        {
            throw new NotImplementedException();
        }
    }
}
