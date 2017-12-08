using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections;

namespace GamerForum.Models
{
    public class GamerForumContext: IdentityDbContext<AppUser>{

        public GamerForumContext() : base("GamerForumContext"){
        }
        static GamerForumContext() {
            Database.SetInitializer<GamerForumContext>(new IdentityDbInit());
        }

        public static GamerForumContext Create() {
            return new GamerForumContext();
        }

        public IEnumerable AppUsers { get; internal set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Rights> Rights { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Wanted_games> Wanted_game { get; set; }
        public DbSet<Images> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //var user = modelBuilder.Entity<IdentityUser>().HasKey(u => u.Id).ToTable("User");

            //user.Property(iu => iu.Id).HasColumnName("UserId");
            //user.Property(iu => iu.UserName).HasColumnName("First_name");
            //user.Property(iu => iu.Id).HasColumnName("Last_name");
            //user.Property(iu => iu.UserName).HasColumnName("User_name");
            //user.Property(iu => iu.Id).HasColumnName("Password");
            //user.Property(iu => iu.Email).HasColumnName("Email");
            //user.Property(iu => iu.Id).HasColumnName("Image").IsOptional();
            //user.Property(iu => iu.Id).HasColumnName("Age");
            //user.Property(iu => iu.Id).HasColumnName("Day_created");


            modelBuilder.Entity<Status>().
               HasMany(c => c.Right).
               WithMany(p => p.Status).
               Map(m =>
               {
                   m.MapLeftKey("Status_id");
                   m.MapRightKey("Rights_id");
                   m.ToTable("status_rights");
               });

            modelBuilder.Entity<AppUser>().
                HasMany(c => c.Status).
                WithMany(p => p.AppUsers).
                Map(m =>
                {
                    m.MapLeftKey("Users_id");
                    m.MapRightKey("Status_id");
                    m.ToTable("user_status");
                });

            modelBuilder.Entity<AppUser>().
                HasMany(c => c.Wanted_games).
                WithMany(p => p.AppUsers).
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

            modelBuilder.Entity<AppUser>().
                HasMany(c => c.Ratings).
                WithMany(p => p.AppUsers).
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
    public class IdentityDbInit : NullDatabaseInitializer<GamerForumContext> { }
}
