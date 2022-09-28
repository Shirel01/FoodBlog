using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodBlog.Models;

namespace FoodBlog.Data
{
    public class FoodBlogContext : DbContext
    {
        public FoodBlogContext (DbContextOptions<FoodBlogContext> options)
            : base(options)
        {
        }

        public DbSet<FoodBlog.Models.Recipe> Recipe { get; set; } = default!;
    }
}
