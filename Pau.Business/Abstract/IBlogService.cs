using Pau.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pau.Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAllBlogs();
        Blog GetBlogById(int id);

        Blog CreateBlog(Blog blog);

        Blog UpdateBlog(Blog blog);

        void DeleteBlog(int id);
    }
}
