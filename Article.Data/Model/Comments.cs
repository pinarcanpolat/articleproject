using System;
using System.Collections.Generic;

namespace Article.Data.Model
{
    public partial class Comments
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? RestorationDate { get; set; }
        public int? MemberId { get; set; }
        public int? ArticleId { get; set; }

        public virtual Articles Article { get; set; }
    }
}
