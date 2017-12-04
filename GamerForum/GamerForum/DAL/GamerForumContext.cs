using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace GamerForum.Models
{
    public class GamerForumContext: DbContext{

        public GamerForumContext() : base("GamerForumContext"){
        }

        public DbSet<Users> User { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Games> Game { get; set; }
        public DbSet<Genres> Genre { get; set; }
        public DbSet<Rights> Right { get; set; }
        public DbSet<Ratings> Rating { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Wanted_games> Wanted_game { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().
               HasMany(c => c.Right).
               WithMany(p => p.Status).
               Map(m =>
               {
                   m.MapLeftKey("Status_id");
                   m.MapRightKey("Rights_id");
                   m.ToTable("status_rights");
               });

            modelBuilder.Entity<Users>().
                HasMany(c => c.Status).
                WithMany(p => p.User).
                Map(m =>
                {
                    m.MapLeftKey("Users_id");
                    m.MapRightKey("Status_id");
                    m.ToTable("user_status");
                });

            modelBuilder.Entity<Users>().
                HasMany(c => c.Wanted_games).
                WithMany(p => p.Users).
                Map(m =>
                {
                    m.MapLeftKey("Users_id");
                    m.MapRightKey("wanted_game_id");
                    m.ToTable("user_wg");
                });

            modelBuilder.Entity<Games>().
                HasMany(c => c.Genre).
                WithMany(p => p.Game).
                Map(m =>
                {
                    m.MapLeftKey("Game_id");
                    m.MapRightKey("Genre_id");
                    m.ToTable("game_genre");
                });

            modelBuilder.Entity<Users>().
                HasMany(c => c.Ratings).
                WithMany(p => p.User).
                Map(m =>
                {
                    m.MapLeftKey("User_id");
                    m.MapRightKey("Rating_id");
                    m.ToTable("ratings_by_users");
                });

            modelBuilder.Entity<Games>().
                HasMany(c => c.Rating).
                WithMany(p => p.Game).
                Map(m =>
                {
                    m.MapLeftKey("Game_id");
                    m.MapRightKey("Rating_id");
                    m.ToTable("game_rating");
                });

        }
    }
}