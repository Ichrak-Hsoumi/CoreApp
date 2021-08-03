using CoreAppliction.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAppliction.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<SubCategory> subcategories { get; set; }
        public DbSet<MenuByUser> menus { get; set; }
    }
}
