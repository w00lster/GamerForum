using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Users : IdentityUser {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        public override string Email { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public DateTime Day_created { get; set; }
        public ICollection<Status> Status { get; set; }
        public ICollection<Wanted_games> Wanted_games { get; set; }
        public ICollection<Ratings> Ratings { get; set; }
        
   
    }
}