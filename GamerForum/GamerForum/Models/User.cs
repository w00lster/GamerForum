using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class User{
        public int Age { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}