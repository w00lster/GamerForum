using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Games
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int GameId { get; set; }
        public string Game_name { get; set; }
        public string Game_url { get; set; }
        public string Description { get; set; }
        public string Game_time { get; set; }
        public string Number_of_Players { get; set; }
        public int Year_releashed { get; set; }
        public ICollection<Genres> Genre { get; set; }
        public ICollection<Ratings> Rating { get; set; }
        public ICollection<Images> Images { get; set; }
    }
}