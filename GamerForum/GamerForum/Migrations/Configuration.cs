using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using GamerForum.Models;
using System.Collections.Generic;
using System.Web;

namespace GamerForum.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<GamerForumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GamerForum.DAL.GamerForumContext";
        }

        protected override void Seed(GamerForum.Models.GamerForumContext context)
        {
            var users = new List<AppUser>
            {
                new AppUser{UserName = "Lily", FirstName = "Lily", LastName = "A. Lop", Age=18, Email = "Lily@gmail.com", DayCreated = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()},
                new AppUser{UserName = "Caz", FirstName = "Castiel", LastName = "Angel", Age=20, Email = "Cas@gmail.com", DayCreated = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()},
                new AppUser{UserName = "Prinsesse", FirstName = "Ariel Tornerose", LastName = "Darling", Age=22, Email = "Prinsesse@gmail.com", DayCreated = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()},
                new AppUser{UserName = "Ellibelly", FirstName = "Elliot", LastName = "Fluff", Age=19, Email = "Elliot@gmail.com", DayCreated = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()}
            };
            foreach (AppUser user in users){
                context.Users.AddOrUpdate(p => p.Id);
            }
            //users.ForEach(u => context.User.AddOrUpdate(p => p.UserId, u));
            context.SaveChanges();

            var ratings = new List<Ratings>
            {
                new Ratings{Rating_value = 1.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 2.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 3.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 4.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 5.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 6.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 7.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 8.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 9.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 10.00, Game = new List<Games>(), AppUsers = new List<AppUser>()}
            };
            ratings.ForEach(r => context.Ratings.AddOrUpdate(p => p.Rating_value, r));
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
            genres.ForEach(g => context.Genres.AddOrUpdate(p => p.Genre_name, g));
            context.SaveChanges();

            var games = new List<Games>
            {
                new Games {Game_name= "Marvel Legendary", Game_time ="45-90 min", Description ="Lorem Ipsum", Number_of_Players ="1-5", Year_releashed = 2000, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Talisman", Game_time ="60-90 min", Description ="Dolor sit amet", Number_of_Players ="2-5", Year_releashed = 2017, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Det dårlige Selskab", Game_time ="30-60 min", Description ="Hab hab", Number_of_Players ="3-6", Year_releashed = 2003, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Fuld af løgn", Game_time ="45-60 min", Description ="løgn og latin", Number_of_Players ="2-6", Year_releashed = 2007, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Uno", Game_time ="10-20 min", Description = "+4 kort", Number_of_Players ="2+", Year_releashed = 1900, Genre = new List<Genres>(), Rating = new List<Ratings>()}
            };
            games.ForEach(ga => context.Games.AddOrUpdate(p => p.Game_name, ga));
            context.SaveChanges();

            var rights = new List<Rights>
            {
                new Rights {Rights_name = "Create", Status = new List<Status>()},
                new Rights {Rights_name = "Read", Status = new List<Status>()},
                new Rights {Rights_name = "Update", Status = new List<Status>()},
                new Rights {Rights_name = "Delete", Status = new List<Status>()}
            };
            rights.ForEach(ri => context.Rights.AddOrUpdate(p => p.Rights_name, ri));
            context.SaveChanges();

            var status = new List<Status>
            {
                new Status {Status_name = "Moderator", Right = new List<Rights>(), AppUsers = new List<AppUser>()},
                new Status {Status_name = "Super User", Right = new List<Rights>(), AppUsers = new List<AppUser>()},
                new Status {Status_name = "User", Right = new List<Rights>(), AppUsers = new List<AppUser>()},
                new Status {Status_name = "Guest", Right = new List<Rights>(), AppUsers = new List<AppUser>()}
            };
            status.ForEach(s => context.Status.AddOrUpdate(p => p.Status_name, s));
            context.SaveChanges();

            var wanted_games = new List<Wanted_games>
            {
                new Wanted_games{Wanted_Game_Name= "Touché", AppUsers = new List<AppUser>()},
                new Wanted_games{Wanted_Game_Name= "Tokaido", AppUsers = new List<AppUser>()},
                new Wanted_games{Wanted_Game_Name= "Monopoly", AppUsers = new List<AppUser>()},
                new Wanted_games{Wanted_Game_Name= "Munchkin", AppUsers = new List<AppUser>()}
            };
            wanted_games.ForEach(w => context.Wanted_game.AddOrUpdate(p => p.Wanted_Game_Name, w));
            context.SaveChanges();

            var images = new List<Images>{
                new Images{Image_path = "/Content/Image/descent.png", GameId = 1}

            };
            images.ForEach(i => context.Images.AddOrUpdate(p => p.ImageId, i));
            context.SaveChanges();


        }

        void AddOrUpdateGenre(GamerForumContext context, string genre, string game_name)
        {
            var gen = context.Genres.SingleOrDefault(g => g.Genre_name == genre);
            var gam = context.Games.SingleOrDefault(ga => ga.Game_name == game_name);

            if (gam == null)
                gen.Game.Add(context.Games.SingleOrDefault(g => g.Game_name == game_name));
        }
    }
}

