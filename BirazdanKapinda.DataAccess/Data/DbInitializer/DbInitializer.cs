using BirazdanKapinda.Models;
using BirazdanKapinda.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirazdanKapinda.DataAccess.Data.DbInitializer
{
        public class DbInitializer : IDbInitializer
        {

            private readonly UserManager<IdentityUser> _userManager;
            private readonly RoleManager<IdentityRole> _roleManager;
            private readonly ApplicationDbContext _db;

            public DbInitializer(
                UserManager<IdentityUser> userManager,
                RoleManager<IdentityRole> roleManager,
                ApplicationDbContext db)
            {
                _roleManager = roleManager;
                _userManager = userManager;
                _db = db;
            }


            public void Initialize()
            {
                try
                {
                    if (_db.Database.GetPendingMigrations().Count() > 0)
                    {
                        _db.Database.Migrate();
                    }
                }
                catch (Exception ex) { }



                // Görev(işlev) oluşturulduğu kısım --BBeratgenc
                if (!_roleManager.RoleExistsAsync(SD.Role_Customer).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_Customer)).GetAwaiter().GetResult();
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_Employee)).GetAwaiter().GetResult();
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_Company)).GetAwaiter().GetResult();


                    
                    _userManager.CreateAsync(new ApplicationUser
                    {
                        UserName = "admin@birazdankapinda.com",
                        Email = "admin@birazdankapinda.com",
                        Name = "Berat Genc",
                        PhoneNumber = "1112223333",
                        StreetAdress = "Merkez",
                        State = "Göktürk",
                        PostalCode = "1923",
                        City = "Istanbul"
                    }, "Admin123*").GetAwaiter().GetResult();


                    ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "admin@birazdankapinda.com");
                    _userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();

                }

                return;
            }
        }
    }

