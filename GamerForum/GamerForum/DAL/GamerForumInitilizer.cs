using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GamerForum.Models;

namespace GamerForum.DAL
{
    public class GamerForumInitilizer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GamerForumContext> {
        protected override void Seed (GamerForumContext context) {
            var admins = new List<Admin> {
                new Admin{Admin_name = "Morten", Email = "Uldum42@gmail.com", Password = "1234567a"},
                new Admin{Admin_name ="Skjold", Email = "eaasrl2017@gmail.com", Password = "1234567b"},
                new Admin{Admin_name ="Mette", Email = "#", Password = "1234567c"},
                new Admin{Admin_name ="kristine", Email = "#", Password ="1234567d"}
            };

        }

    }
}