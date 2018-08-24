
using Microsoft.AspNet.Identity.EntityFramework;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCMS.Models
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser, ApplicationRole, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
     
}