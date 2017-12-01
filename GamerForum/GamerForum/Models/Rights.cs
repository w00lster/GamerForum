using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerForum.Models
{
    public class Rights
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Rights_id { get; set; }
        public string Rights_name { get; set }

    }
}