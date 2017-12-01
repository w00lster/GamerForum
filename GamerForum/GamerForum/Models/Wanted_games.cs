using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Wanted_games
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int wanted_game_id { get; set; }
        public string wanted_game_name { get; set; }
        public string wanted_game_url { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}