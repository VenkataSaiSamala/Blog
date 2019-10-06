using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {

        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}
