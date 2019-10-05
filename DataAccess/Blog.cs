using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public DateTime? BlogDate { get; set; }
        public string BlogDescription { get; set; }
        public ICollection<Comments> Comments { get; set; }


    }
}
