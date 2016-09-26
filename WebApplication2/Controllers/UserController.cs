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
            list.Add(new User("Misha","Volinets","Ukraine","14"));
            list.Add(new User("Dmitro", "Rakochiy", "Belarus", "1"));
            list.Add(new Models.User("Andry","Derdzyak","Poland","12"));
            return View(list);
        }
    }
}