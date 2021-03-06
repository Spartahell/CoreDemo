using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public  interface IBlogService
    {
        void BlogyAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        Blog GetById(int id);
        List<Blog> GetList();

        List<Blog> GetBlogByID(int id);
        List<Blog> GetBlogListWithCategory();
    }
}
