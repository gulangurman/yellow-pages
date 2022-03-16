#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShortListMVC.Models;

namespace ShortListMVC.Data
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            string TEST_USER_ID = "02174cf0–9412–4cfe - afbf - 59f706d72cf6";

            modelBuilder.Entity<Category>().HasData(
          new Category { Id = 1, Name = "Kayıp", Slug = "lost", Icon = "dinner" }
        , new Category { Id = 2, Name = "Evcil Hayvanlar", Slug = "pets", Icon = "home" }
        , new Category { Id = 3, Name = "Eleman Aranıyor", Slug = "hiring", Icon = "tshirt" }
        , new Category { Id = 4, Name = "İkinci El", Slug = "secondhand", Icon = "travel" }
        , new Category { Id = 5, Name = "Serbest Çalışanlar", Slug = "hiring", Icon = "jobs" }
        , new Category { Id = 6, Name = "Etkinlikler", Slug = "hiring", Icon = "bullhorn" }
        , new Category { Id = 7, Name = "Ev yapımı", Slug = "handmade", Icon = "bolt" }
        );
            

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Kayıp kedi",
                    Tags = "kedi",
                    Content = "Kedimiz Bıdık kaybolmuştur.",
                    ImageUrl = "https://www.markuptag.com/images/image-six.jpg",
                    AccountId = TEST_USER_ID
                },
                new Post
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Eleman aranıyor",
                    Tags = "eleman",
                    Content = "Acil eleman aranıyor.",
                    ImageUrl = "https://www.markuptag.com/images/image-two.jpg",
                    AccountId = TEST_USER_ID
                },
                 new Post
                 {
                     Id = 3,
                     CategoryId = 4,
                     Title = "Satılık telefon",
                     Tags = "telefon",
                     Content = "İkinci el cep telefonu.",
                     ImageUrl = "https://www.markuptag.com/images/image-three.jpg",
                     AccountId = TEST_USER_ID
                 },
                  new Post
                  {
                      Id = 4,
                      CategoryId = 6,
                      Title = "Sahil konserleri",
                      Tags = "konser",
                      Content = "Sahilde konser etkinliğinde buluşuyoruz.",
                      ImageUrl = "https://www.markuptag.com/images/image-four.jpg",
                      AccountId = TEST_USER_ID
                  }
                );
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}