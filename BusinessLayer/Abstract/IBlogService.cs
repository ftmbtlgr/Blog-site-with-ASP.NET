using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        List<Blog1> GetList();
        void BlogAdd(Blog1 blog);
        Blog1 GetByID(int id);
        void BlogDelete(Blog1 blog);
        void BlogUpdate(Blog1 blog);
    }
}
