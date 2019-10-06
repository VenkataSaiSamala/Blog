using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }
        public DateTime CommentTime { get; set; }
        public string CommentDescription { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
