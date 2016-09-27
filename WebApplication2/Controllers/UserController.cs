using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        public static List<Massage> mas = new List<Massage>();
        public static List<User> list = new List<User>();
        // GET: User
        public ActionResult Information()
        {
            list.Add(new User("Misha","Volinets","Ukraine","Secondary"));
            return View(list);
        }

        [HttpPost]
        public ActionResult sentPost(Massage model)
        {
            mas.Add(model);
            return View("Information",list);
        }
        public ActionResult printPost()
        {
            return View(mas);
        }

    }
}