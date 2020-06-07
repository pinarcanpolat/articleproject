using Article.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Repos.Contracts
{
    public interface ICommentRepository
    {
        IEnumerable<Comments> GetComments();
        IEnumerable<Comments> GetComments(int ArticleId);

        Comments GetComment(int CommentId);


    }
}
