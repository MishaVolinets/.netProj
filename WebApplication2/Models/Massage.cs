using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Massage
    {
        public string Title { get;set;}
        public string Description { get;set; }
        public DateTime dateOfCreate = DateTime.Now;

    }
}