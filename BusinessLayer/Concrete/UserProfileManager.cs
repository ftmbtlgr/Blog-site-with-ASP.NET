using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repouser = new Repository<Author>();
        Repository<Blog1> repouserblog = new Repository<Blog1>();
        //Yazarın mail'ine göre yazar bilgilerini getir

        public List<Author> GetAuthorByMail(string p)
        {
            return repouser.List(x => x.Mail == p);
        }
        //Yazarın id'sine göre blogları getir
        public List<Blog1> GetBlogByID(int id)
        {
            return repouserblog.List(x => x.AuthorID == id);
        }
        public void EditUserAuthor(Author p)
        {
            Author author = repouser.Find(x => x.AuthorID == p.AuthorID);
            //Gelen parametre ile yeni değer atamalarını(güncelleştirmeyi) gerçekleştiriyor
            author.AuthorUserName = p.AuthorUserName;
            author.AuthorName = p.AuthorName;
            author.AuthorSurName = p.AuthorSurName;
            author.Mail = p.Mail;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorAboutShort = p.AuthorAboutShort;
            author.AuthorImage = p.AuthorImage;
            author.Password = p.Password;
            repouser.Update(author);
        }
    }
}
