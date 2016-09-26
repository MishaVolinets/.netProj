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
        // GET: User
        public ActionResult Information()
        {
            List<User> list = new List<User>();
            list.Add(new User("Misha",12));
            list.Add(new User("Dmitry", 14));

            return View(list);
        }
    }
}