#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            modelBuilder.Entity<Category>().HasData(
          new Category { Id = 1, Name = "Kayıp", Slug = "lost", Icon = "dinner" }
        , new Category { Id = 2, Name = "Evcil Hayvanlar", Slug = "pets", Icon = "home" }
        , new Category { Id = 3, Name = "Eleman Aranıyor", Slug = "hiring", Icon = "tshirt" }
        , new Category { Id = 4, Name = "İkinci El", Slug = "secondhand", Icon = "travel" }
        , new Category { Id = 5, Name = "Serbest Çalışanlar", Slug = "hiring", Icon = "jobs" }
        , new Category { Id = 6, Name = "Etkinlikler", Slug = "hiring", Icon = "bullhorn" }
        , new Category { Id = 7, Name = "Ev yapımı", Slug = "handmade", Icon = "bolt" }
        );
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}