using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Ratings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int RatingId { get; set; }
        public double Rating_value { get; set; }

        public ICollection<AppUser> AppUsers { get; set; }
        public ICollection<Games> Game { get; set; }
    }
}