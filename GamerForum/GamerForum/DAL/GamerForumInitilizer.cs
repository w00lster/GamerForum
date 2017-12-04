using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using GamerForum.Models;

namespace GamerForum.DAL
{
    internal sealed class GamerForumInitilizer : DropCreateDatabaseIfModelChanges<GamerForumContext> {
        public GamerForumInitilizer () {

        }

        protected override void Seed (GamerForumContext context) {
            var admins = new List<Admin> {
                new Admin{Admin_name = "Morten", Email = "Uldum42@gmail.com", Password = "1234567a"},
                new Admin{Admin_name ="Skjold", Email = "eaasrl2017@gmail.com", Password = "1234567b"},
                new Admin{Admin_name ="Mette", Email = "#", Password = "1234567c"},
                new Admin{Admin_name ="kristine", Email = "#", Password ="1234567d"}
            };
            admins.ForEach(a => context.Admins.AddOrUpdate(p => p.Admin_name, a));
            context.SaveChanges();

            var users = new List<Users>
            {
                new Users{User_name = "Lily", First_name = "Lily", Last_name = "A. Lop", Age=18, Email = "Lily@gmail.com", Day_created = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()},
                new Users{User_name = "Caz", First_name = "Castiel", Last_name = "Angel", Age=20, Email = "Cas@gmail.com", Day_created = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()},
                new Users{User_name = "Prinsesse", First_name = "Ariel Tornerose", Last_name = "Darling", Age=22, Email = "Prinsesse@gmail.com", Day_created = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()},
                new Users{User_name = "Ellibelly", First_name = "Elliot", Last_name = "Fluff", Age=19, Email = "Elliot@gmail.com", Day_created = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()}
            };
            users.ForEach(u => context.User.AddOrUpdate(p => p.User_id, u));
            context.SaveChanges();

            var ratings = new List<Ratings>
            {
                new Ratings{Rating_value = 1.00, Game = new List<Games>(), User = new List<Users>()},
                new Ratings{Rating_value = 2.00, Game = new List<Games>(), User = new List<Users>()},
                new Ratings{Rating_value = 3.00, Game = new List<Games>(), User = new List<Users>()},
                new Ratings{Rating_value = 4.00, Game = new List<Games>(), User = new List<Users>()},
                new Ratings{Rating_value = 5.00, Game = new List<Games>(), User = new List<Users>()},
                new Ratings{Rating_value = 6.00, Game = new List<Games>(), User = new List<Users>()},
                new Ratings{Rating_value = 7.00, Game = new List<Games>(), User = new List<Users>()},
                new Ratings{Rating_value = 8.00, Game = new List<Games>(), User = new List<Users>()},
                new Ratings{Rating_value = 9.00, Game = new List<Games>(), User = new List<Users>()},
                new Ratings{Rating_value = 10.00, Game = new List<Games>(), User = new List<Users>()}
            };
            ratings.ForEach(r => context.Rating.AddOrUpdate(p => p.Rating_value, r));
            context.SaveChanges();

            var genres = new List<Genres>
            {
                new Genres{Genre_name = "Card", Game = new List<Games>()},
                new Genres{Genre_name = "Adventure", Game = new List<Games>()},
                new Genres{Genre_name = "Party", Game = new List<Games>()},
                new Genres{Genre_name = "Deck building", Game = new List<Games>()},
                new Genres{Genre_name = "Dungeon Crawler", Game = new List<Games>()},
                new Genres{Genre_name = "Family", Game = new List<Games>()},
                new Genres{Genre_name = "Kids", Game = new List<Games>()}
            };
            genres.ForEach(g => context.Genre.AddOrUpdate(p => p.Genre_name, g));
            context.SaveChanges();

            var games = new List<Games>
            {
                new Games {Game_name= "Marvel Legendary", Game_time ="45-90 min", Description ="Lorem Ipsum", Number_of_Players ="1-5", Year_releashed = 2000, Admin_id = 1, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Talisman", Game_time ="60-90 min", Description ="Dolor sit amet", Number_of_Players ="2-5", Year_releashed = 2017, Admin_id = 2, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Det dårlige Selskab", Game_time ="30-60 min", Description ="Hab hab", Number_of_Players ="3-6", Year_releashed = 2003, Admin_id = 3, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Fuld af løgn", Game_time ="45-60 min", Description ="løgn og latin", Number_of_Players ="2-6", Year_releashed = 2007, Admin_id = 4, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Uno", Game_time ="10-20 min", Description = "+4 kort", Number_of_Players ="2+", Year_releashed = 1900, Admin_id = 1, Genre = new List<Genres>(), Rating = new List<Ratings>()}
            };
            games.ForEach(ga => context.Game.AddOrUpdate(p => p.Game_name, ga));
            context.SaveChanges();

            var rights = new List<Rights>
            {
                new Rights {Rights_name = "Create", Status = new List<Status>()},
                new Rights {Rights_name = "Read", Status = new List<Status>()},
                new Rights {Rights_name = "Update", Status = new List<Status>()},
                new Rights {Rights_name = "Delete", Status = new List<Status>()}
            };
            rights.ForEach(ri => context.Right.AddOrUpdate(p => p.Rights_name, ri));
            context.SaveChanges();

            var status = new List<Status>
            {
                new Status {Status_name = "Moderator", Right = new List<Rights>(), User = new List<Users>()},
                new Status {Status_name = "Super User", Right = new List<Rights>(), User = new List<Users>()},
                new Status {Status_name = "User", Right = new List<Rights>(), User = new List<Users>()},
                new Status {Status_name = "Guest", Right = new List<Rights>(), User = new List<Users>()}
            };
            status.ForEach(s => context.Status.AddOrUpdate(p => p.Status_name, s));
            context.SaveChanges();

            var wanted_games = new List<Wanted_games>
            {
                new Wanted_games{wanted_game_name= "Touché", Users = new List<Users>()},
                new Wanted_games{wanted_game_name= "Tokaido", Users = new List<Users>()},
                new Wanted_games{wanted_game_name= "Monopoly", Users = new List<Users>()},
                new Wanted_games{wanted_game_name= "Munchkin", Users = new List<Users>()}
            };
            wanted_games.ForEach(w => context.Wanted_game.AddOrUpdate(p => p.wanted_game_name, w));
            context.SaveChanges();

            AddOrUpdateGenre(context, "Deck building", "Marvel Legendary");
            context.SaveChanges();

        }

        void AddOrUpdateGenre(GamerForumContext context, string genre, string game_name)
        {
            var gen = context.Genre.SingleOrDefault(g => g.Genre_name == genre);
            var gam = context.Game.SingleOrDefault(ga => ga.Game_name == game_name);

            if (gam == null)
                gen.Game.Add(context.Game.SingleOrDefault(g =>g.Game_name == game_name ));
        }

    }
}