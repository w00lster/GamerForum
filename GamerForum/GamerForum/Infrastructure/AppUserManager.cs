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
    public class AppUserManager : UserManager<Users> {

        public AppUserManager(IUserStore<Users> store) : base(store) {
        }

        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> options, IOwinContext context) {
            GamerForumContext db = context.Get<GamerForumContext>();
            AppUserManager manager = new AppUserManager(new UserStore<Users>(db));

            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 8,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = false,
            };

            manager.UserValidator = new UserValidator<Users>(manager)
            {
                RequireUniqueEmail = true,
                AllowOnlyAlphanumericUserNames = false
            };

            return manager;
        }

    }
}