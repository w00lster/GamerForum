using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Games
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Game_id { get; set; }
        public int User_id { get; set; }
        public string Game_name { get; set; }
        public string Game_url { get; set; }
        public string Description { get; set; }
        public string Game_time { get; set; }
        public string Number_of_Players { get; set; }
        public int Year_releashed { get; set; }
    }
}