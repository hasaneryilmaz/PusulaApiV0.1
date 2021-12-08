using Pau.Business.Abstract;
using Pau.DataAccess.Abstract;
using Pau.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pau.Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogRepository blogRepository;

        public BlogManager(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        public Blog CreateBlog(Blog blog)
        {
            return blogRepository.Create(blog);
        }

        public void DeleteBlog(int id)
        {
            blogRepository.Delete(id);
        }

        public List<Blog> GetAllBlogs()
        {
            return blogRepository.GetAll();
        }

        public Blog GetBlogById(int id)
        {
            return blogRepository.GetById(b => b.Id == id);
        }

        public Blog UpdateBlog(Blog blog)
        {
            return blogRepository.Update(blog);
        }
    }
}
