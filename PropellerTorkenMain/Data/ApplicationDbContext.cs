using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PropellerTorkenMain.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //var roleStore = new RoleStore<IdentityRole>(builder.Model.);

            //if (!_context.Roles.Any(r => r.Name == "admin"))
            //{
            //    await roleStore.CreateAsync(new IdentityRole { Name = "admin", NormalizedName = "admin" });
            //}
        }

        //public async void SeedAdminUser()
        //{
            //var user = new ApplicationUser
            //{
            //    UserName = "Email@email.com",
            //    NormalizedUserName = "email@email.com",
            //    Email = "Email@email.com",
            //    NormalizedEmail = "email@email.com",
            //    EmailConfirmed = true,
            //    LockoutEnabled = false,
            //    SecurityStamp = Guid.NewGuid().ToString()
            //};

            

            //if (!_context.Users.Any(u => u.UserName == user.UserName))
            //{
            //    var password = new PasswordHasher<ApplicationUser>();
            //    var hashed = password.HashPassword(user, "password");
            //    user.PasswordHash = hashed;
            //    var userStore = new UserStore<ApplicationUser>(_context);
            //    await userStore.CreateAsync(user);
            //    await userStore.AddToRoleAsync(user, "admin");
            //}

            //await _context.SaveChangesAsync();
        }
    }
}
