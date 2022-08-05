using AppointmentScheduler.Helper;
using AppointmentScheduler.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AppointmentScheduler.DbInitilizer
{
    public class DbInitializer : IDbInitializer
    {

        private readonly ApplicationDBContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDBContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initialize()
        {
            try
            {
                if(_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception)
            {

            }

            if (_db.Roles.Any(x => x.Name == Roles.Admin)) return;

           
            _roleManager.CreateAsync(new IdentityRole(Roles.Admin)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(Roles.Doctor)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(Roles.Patient)).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser()
            {
                Name = "Admin John",
                Email = "admin1@gmail.com",
                EmailConfirmed = true,
                UserName = "admin1@gmail.com"
            },"admin1").GetAwaiter().GetResult();

            ApplicationUser user = _db.Users.FirstOrDefault(u => u.Email == "admin1@gmail.com");
            _userManager.AddToRoleAsync(user, Roles.Admin).GetAwaiter().GetResult();
        }
    }
}
