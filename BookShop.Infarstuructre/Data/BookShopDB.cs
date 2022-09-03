using BookShop.Domain.Models;
using BookShop.Infarstuructre.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infarstuructre.Data
{
    public class BookShopDB:IdentityDbContext<ApplicationUser>
    {
        public BookShopDB(DbContextOptions<BookShopDB> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>().ToTable("users","Identity");
            builder.Entity<IdentityRole>().ToTable("Roles","Identity");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Identity");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim", "Identity");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin", "Identity");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim", "Identity");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserToken", "Identity");
            builder.Entity<Category>().Property(c => c.Id).HasDefaultValueSql("(newid())");
            builder.Entity<LogCategory>().Property(c => c.Id).HasDefaultValueSql("(newid())");
            builder.Entity<SubCategory>().Property(c => c.Id).HasDefaultValueSql("(newid())");
            builder.Entity<LogSubCategory>().Property(c => c.Id).HasDefaultValueSql("(newid())");
            builder.Entity<Book>().Property(c => c.Id).HasDefaultValueSql("(newid())");
            builder.Entity<LogBook>().Property(c => c.Id).HasDefaultValueSql("(newid())");
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<LogBook> LogBooks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LogCategory> LogCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<LogSubCategory> LogSubCategories { get; set; }
        //public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
    // Add-Migration inialMigration
    //update-database

}
