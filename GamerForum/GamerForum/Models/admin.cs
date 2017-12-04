using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Admin{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // dette fortæller databasen at denne værdi skal være auto genereret
        public int Admin_id { get; set; }
        public string Admin_name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}