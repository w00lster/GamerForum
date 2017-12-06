using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace GamerForum.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class AppUser : IdentityUser   {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public int? Age { get; set; }
        public DateTime DayCreated { get; set; }
        public ICollection<Status> Status { get; set; }
        public ICollection<Wanted_games> Wanted_games { get; set; }
        public ICollection<Ratings> Ratings { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext()
            : base("GamerForumContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}