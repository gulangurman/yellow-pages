using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShortListWebApp.Model;

namespace ShortListWebApp.Data
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
    }
}
  
