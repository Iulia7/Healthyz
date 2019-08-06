using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Forum
    {
        public int ForumID { get; set; }
        public int UserID { get; set; }
        public string Comment { get; set; }
        public bool Helpful { get; set; }
    }
}