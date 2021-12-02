using Pau.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pau.DataAccess.Abstract
{
    interface IBlogRepository
    {

        List<Blog> GetAllBlog();

        Blog GetBlogById(int id);

        Blog CreatBlog(Blog blog);

        Blog UpdateBlog(Blog blog);

        void DeleteBlog(int id);
    }

}
}
