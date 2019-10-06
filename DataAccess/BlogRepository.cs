using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BlogRepository
    {
        public List<Blog> GetAllBlogPosts()
        {
            BlogContext bc = new BlogContext();
            return bc.Blog.ToList();
        }
    }
}
