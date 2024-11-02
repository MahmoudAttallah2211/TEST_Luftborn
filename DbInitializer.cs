using FastFood.Models;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Repository
{
    public class DbInitializer : IDbInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly UserManager<IdentityUser> _userManager;

        private readonly ApplicationDbContext _context;

        public DbInitializer(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        /// <summary>
        /// at this page we need just make assession  with our database and business logic
        /// </summary>

        public void Initialize()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count()> 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception)
            {
                throw;
            }

            if (_context.Roles.Any(x=>x.Name == "Admine")) return;

            _roleManager.CreateAsync(new IdentityRole("Manager"))
                .GetAwaiter()
                .GetResult();
            _roleManager.CreateAsync(new IdentityRole("Admine"))
                .GetAwaiter()
                .GetResult();
            _roleManager.CreateAsync(new IdentityRole("Customer"))
                .GetAwaiter()
                .GetResult();

            var user = new ApplicationUser()
            {
                UserName = "admine@gmail.com",
                Email = "admine@gmail.com",
                Name="Admine",
                City = "xyz",
                Address = "xyz",
                PostalCode="9999"
            };
            //_userManager.CreateAsync(user, "Admine@123")
            //    .GetAwaiter()
            //    .GetResult();
            //_userManager.AddToRoleAsync(user, "Admine");
        }
    }
}
