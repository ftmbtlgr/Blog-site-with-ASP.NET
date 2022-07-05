using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    [AllowAnonymous]
    public class MailSubscribeController : Controller
    {
        [HttpGet]
        public PartialViewResult MailAdd()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MailAdd(SubscribeMail p)
        {
            SubscribeMailManager sm = new SubscribeMailManager();
            sm.BLAdd(p);
            return PartialView();
        }
    }
}