using System;
using System.Collections.Generic;

namespace Article.Data.Model
{
    public partial class Articles
    {
        public Articles()
        {
            Comments = new HashSet<Comments>();
        }

        public int ArticleId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public byte? Statu { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? RestorationDate { get; set; }
        public int? WriterId { get; set; }
        public string WriterName { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
    }
}
