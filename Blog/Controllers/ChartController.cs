using Blog.Models;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        //Görselleştirme
        public ActionResult VisualizeResult()
        {
            return Json(categorylist(), JsonRequestBehavior.AllowGet);
        }
        public List<Class1> categorylist()
        {
            List<Class1> c = new List<Class1>();
            c.Add(new Class1()
            {
                CategoryName = "Yazılım",
                BlogCount = 28
            });
            c.Add(new Class1()
            {
                CategoryName = "Veri Bilimi",
                BlogCount = 12
            });
            c.Add(new Class1()
            {
                CategoryName = "Yaşam",
                BlogCount = 18
            });
            return c;
        }
        public ActionResult VisualizeResult2()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }
        public List<Class2> BlogList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new Context())
            {
                cs2 = c.Blog1s.Select(x => new Class2
                {
                    BlogName = x.BlogTitle,
                    Rating = x.BlogRating
                }).ToList();
            }
            return cs2;
        }
        public ActionResult Chart1()
        {
            return View();
        }
        public ActionResult Chart2()
        {
            return View();
        }
        public ActionResult Chart3()
        {
            return View();
        }
    }
}