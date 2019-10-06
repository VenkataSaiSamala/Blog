using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public DateTime? BlogDate { get; set; }
        public string BlogDescription { get; set; }

        
        public virtual List<Comments> Comments { get; set; }


    }
}
