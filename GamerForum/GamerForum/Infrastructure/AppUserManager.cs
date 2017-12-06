using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GamerForum.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;

namespace GamerForum.Infrastructure
{
    public class AppUserManager : UserManager<AppUser> {

        public AppUserManager(IUserStore<AppUser> store) : base(store) {
        }

        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> options, IOwinContext context) {
            GamerForumContext db = context.Get<GamerForumContext>();
            AppUserManager manager = new AppUserManager(new UserStore<AppUser>(db));

            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 8,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = false,
            };

            manager.UserValidator = new UserValidator<AppUser>(manager)
            {
                RequireUniqueEmail = true,
                AllowOnlyAlphanumericUserNames = false
            };

            return manager;
        }

    }
}