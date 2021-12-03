using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options):base(options)
        {
            
        }
        public DbSet<Post> post { get; set; }
    }
}
