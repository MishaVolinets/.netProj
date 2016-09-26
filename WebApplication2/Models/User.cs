using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string School { set; get; }
        public DateTime DateOfRegister { get; set; }

        public User(string _FirstName, string _LastName, string _Location, string _School)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            Location = _Location;
            School = _School;
            DateOfRegister = DateTime.Now;
        }

        public User()
        {

        }
        

    }
}