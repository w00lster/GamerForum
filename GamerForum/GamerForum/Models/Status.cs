using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Status
    {
        public int Status_id { get; set; }
        public string Status_name { get; set; }

        public ICollection<Rights> Right { get; set; }
        public ICollection<Users> User { get; set; }
    }
}