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

            var users = new List<Users>
            {
                new Users{User_name = "Lily", First_name = "Lily", Last_name = "A. Lop", Age=18, Email = "Lily@gmail.com", Day_created = DateTime.Now },
                new Users{User_name = "Caz", First_name = "Castiel", Last_name = "Angel", Age=20, Email = "Cas@gmail.com", Day_created = DateTime.Now },
                new Users{User_name = "Prinsesse", First_name = "Ariel Tornerose", Last_name = "Darling", Age=22, Email = "Prinsesse@gmail.com", Day_created = DateTime.Now },
                new Users{User_name = "Ellibelly", First_name = "Elliot", Last_name = "Fluff", Age=19, Email = "Elliot@gmail.com", Day_created = DateTime.Now }
            };
            var ratings = new List<Ratings>
            {
                new Ratings{Rating_value = 1.00},
                new Ratings{Rating_value = 2.00},
                new Ratings{Rating_value = 3.00},
                new Ratings{Rating_value = 4.00},
                new Ratings{Rating_value = 5.00},
                new Ratings{Rating_value = 6.00},
                new Ratings{Rating_value = 7.00},
                new Ratings{Rating_value = 8.00},
                new Ratings{Rating_value = 9.00},
                new Ratings{Rating_value = 10.00}
            };

            var genres = new List<Genres>
            {
                new Genres{Genre_name = "Card"},
                new Genres{Genre_name = "Adventure"},
                new Genres{Genre_name = "Party"},
                new Genres{Genre_name = "Deck building"},
                new Genres{Genre_name = "Dungeon Crawler"},
                new Genres{Genre_name = "Family"},
                new Genres{Genre_name = "Kids"}
            };

            var games = new List<Games>
            {
                new Games {Game_name= "Marvel Legendary", Game_time ="45-90 min", Description ="Lorem Ipsum", Number_of_Players ="1-5", Year_releashed = 2000},
                new Games {Game_name= "Talisman", Game_time ="60-90 min", Description ="Dolor sit amet", Number_of_Players ="2-5", Year_releashed = 2017},
                new Games {Game_name= "Det dårlige Selskab", Game_time ="30-60 min", Description ="Hab hab", Number_of_Players ="3-6", Year_releashed = 2003},
                new Games {Game_name= "Fuld af løgn", Game_time ="45-60 min", Description ="løgn og latin", Number_of_Players ="2-6", Year_releashed = 2007},
                new Games {Game_name= "Uno", Game_time ="10-20 min", Description = "+4 kort", Number_of_Players ="2+", Year_releashed = 1900}
            };

            var rights = new List<Rights>
            {
                new Rights {Rights_name = "Create"},
                new Rights {Rights_name = "Read"},
                new Rights {Rights_name = "Update"},
                new Rights {Rights_name = "Delete"}
            };

            var status = new List<Status>
            {
                new Status {Status_name = "Moderator"},
                new Status {Status_name = "Super User"},
                new Status {Status_name = "User"},
                new Status {Status_name = "Guest"}
            };

            var wanted_games = new List<Wanted_games>
            {
                new Wanted_games{wanted_game_name= "Touché"},
                new Wanted_games{wanted_game_name= "Tokaido"},
                new Wanted_games{wanted_game_name= "Monopoly"},
                new Wanted_games{wanted_game_name= "Munchkin"},
            };
        }

    }
}