using NguyenBlog.Data.Models;
using System.Collections.Generic;

namespace NguyenBlog.Models.AdminViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}
