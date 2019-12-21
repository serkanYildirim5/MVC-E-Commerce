using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.Entity.Model
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CreateDate { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
    }
}
