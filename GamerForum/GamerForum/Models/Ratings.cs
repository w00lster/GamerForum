using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Ratings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Rating_id { get; set; }
        public double Rating_value { get; set; }

        public ICollection<Users> User { get; set; }
        public ICollection<Games> Game { get; set; }
    }
}