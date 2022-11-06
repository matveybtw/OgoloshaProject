using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Context
{
    public class OgoloshaContext:DbContext
    {
        public OgoloshaContext(DbContextOptions<OgoloshaContext> dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>().HasKey(x => x.UserId);
            modelBuilder.Entity<User>().HasOne(x => x.UserInfo).WithOne(x => x.User).HasForeignKey<User>(x=>x.Id);
            modelBuilder.Entity<Advert>().HasMany(x => x.Contacts);
            modelBuilder.Entity<Category>().HasMany(x => x.Subcategories).WithOne(x => x.Category);
            base.OnModelCreating(modelBuilder);
        }
    }
}