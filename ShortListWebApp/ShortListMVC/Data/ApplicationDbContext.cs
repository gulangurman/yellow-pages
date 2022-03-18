#nullable disable
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShortListMVC.Models;

namespace ShortListMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            string TEST_USER_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
            var user = new ApplicationUser
            {
                Id = TEST_USER_ID,
                Email = "testuser@example.com",
                UserName = "testuser@example.com",
                NormalizedUserName = "TESTUSER@EXAMPLE.COM",
                NormalizedEmail = "TESTUSER@EXAMPLE.COM",
                About = "Test user account.",
                Nickname = "test_user_01",
                PhoneNumber = "5551234567"
            };
            user.PasswordHash = new PasswordHasher<ApplicationUser>()
                .HashPassword(user, "testuser.?");
            builder.Entity<ApplicationUser>().HasData(user);
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