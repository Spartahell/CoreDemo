using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {

        CommentManager com = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = com.GetList(id);
            return PartialView(values);
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
    }
}
