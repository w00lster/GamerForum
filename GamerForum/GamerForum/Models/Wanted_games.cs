using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Wanted_games
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Wanted_Game_Id { get; set; }
        public string Wanted_Game_Name { get; set; }
        public string Wanted_Game_Url { get; set; }
        public ICollection<AppUser> AppUsers { get; set; }
    }
}