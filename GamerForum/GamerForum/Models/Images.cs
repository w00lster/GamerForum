using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Images
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Image_id { get; set; }
        public int Game_id { get; set; }
        public string Image_path { get; set; }
    }
}