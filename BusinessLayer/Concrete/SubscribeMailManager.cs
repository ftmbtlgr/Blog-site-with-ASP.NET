using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubscribeMailManager
    {
        Repository<SubscribeMail> RepoSubscribeMail = new Repository<SubscribeMail>();
        public void BLAdd(SubscribeMail p)  //Ekleme işlemini int olarak tanımladığı için burada da int olarak tanımlanıyor.
        {
            //if (p.Mail.Length <= 10 || p.Mail.Length >= 50)
            //{
            //    return -1;
            //}
            RepoSubscribeMail.Insert(p);
        }
    }
}
