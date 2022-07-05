using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repocomment = new Repository<Comment>();
        public List<Comment> CommentList()
        {
            return repocomment.List();
        }
        //BlogID' ye göre yorumları getirme
        public List<Comment> CommentByBlog(int id)
        {
            return repocomment.List(x => x.BlogID == id);
        }
        //Yorumlar veritabanından kaldırılmayacak sadece durumu değişecek
        //Yorumların durumuna göre getirme işlemi
        public List<Comment> CommentByStatusTrue()
        {
            return repocomment.List(x => x.CommentStatus == true);
        }
        public List<Comment> CommentByStatusFalse()
        {
            return repocomment.List(x => x.CommentStatus == false);
        }
        //Yorum eklenirken şartların sağlanması, sağlanmıyorsa eklenmemesi
        public void CommentAdd(Comment c)
        {
            //if (c.CommentText.Length <= 4 || c.CommentText.Length >= 301 || c.UserName == "" || c.Mail == "" || c.UserName.Length <= 4)
            //{
            //    return -1;
            //}
            repocomment.Insert(c);
        }
        //Yayınlanmış yorumun kaldırılması
        public void CommentStatusChangeToFalse(int id)
        {
            Comment comment = repocomment.Find(x => x.CommentID == id);
            comment.CommentStatus = false;
            repocomment.Update(comment);
        }
        //Kaldırılmış yorumun yayınlanması
        public void CommentStatusChangeToTrue(int id)
        {
            Comment comment = repocomment.Find(x => x.CommentID == id);
            comment.CommentStatus = true;
            repocomment.Update(comment);
        }
    }
}
