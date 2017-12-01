using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Genres
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Genre_id { get; set; }
        public string Gebre_name { get; set; }
       
    }
}