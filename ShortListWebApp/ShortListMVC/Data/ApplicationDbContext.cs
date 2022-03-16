#nullable disable
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShortListMVC.Data
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
            string TEST_USER_ID = "02174cf0–9412–4cfe - afbf - 59f706d72cf6";
            var user = new IdentityUser
            {
                Id = TEST_USER_ID,
                Email = "testuser@example.com",
                UserName = "Test User",
                NormalizedUserName = "TESTUSER@EXAMPLE.COM"
            };
            user.PasswordHash = new PasswordHasher<IdentityUser>()
                .HashPassword(user, "testuser.?");
            builder.Entity<IdentityUser>().HasData(user);
            /*
             
            string ADMIN_ID = "02174cf0–9412–4cfe - afbf - 59f706d72cf6";
            string ROLE_ID = "341743f0 - asd2–42de - afbf - 59kmkkmk72cf6";
            
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });
            
            var appUser = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "admin@pinkhatapps.com",
                EmailConfirmed = true,
                //FirstName = "Frank",
                //LastName = "Ofoedu",
                UserName = "frankofoedu@gmail.com",
             NormalizedUserName = "FRANKOFOEDU@GMAIL.COM"
            };
           
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "mypassword_?");
           
            builder.Entity<IdentityUser>().HasData(appUser);
           
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
            */
        }
    }
}