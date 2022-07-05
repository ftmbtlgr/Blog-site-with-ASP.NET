using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        Repository<Blog1> repoblog = new Repository<Blog1>();
        public List<Blog1> GetAll()
        {
            return repoblog.List();
        }
        public List<Blog1> GetBlogByID(int id)
        {
            return repoblog.List(x => x.BlogID == id);
        }
        public List<Blog1> GetBlogByAuthor(int id)
        {
            return repoblog.List(x => x.AuthorID == id);
        }
        public List<Blog1> GetBlogByCategory(int id)
        {
            return repoblog.List(x => x.CategoryID == id);
        }
        public void BlogAddBL(Blog1 p)
        {
            //if (p.BlogTitle == "" || p.BlogImage == "" || p.BlogTitle.Length <= 5 || p.BlogContent.Length <= 200)
            //{
            //    return -1;
            //}
            repoblog.Insert(p);
        }
        public void DeleteBlogBL(int p)
        {
            Blog1 blog = repoblog.Find(x => x.BlogID == p);
            repoblog.Delete(blog);
        }
        public Blog1 FindBlog(int id)
        {
            return repoblog.Find(x => x.BlogID == id);
        }
        public void UpdateBlog(Blog1 p)
        {
            Blog1 blog = repoblog.Find(x => x.BlogID == p.BlogID);
            blog.BlogTitle = p.BlogTitle;
            blog.CategoryID = p.CategoryID;
            blog.BlogImage = p.BlogImage;
            blog.BlogDate = p.BlogDate;
            blog.AuthorID = p.AuthorID;
            blog.BlogContent = p.BlogContent;
            repoblog.Update(blog);
        }
    }
}
