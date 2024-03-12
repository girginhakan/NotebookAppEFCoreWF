using Microsoft.EntityFrameworkCore;
using NotebookAppEFCoreWF.Context.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookAppEFCoreWF.Context
{
    public class NotebookContext:DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=HakanPC;Initial Catalog=NotebookAppDb;Integrated Security=true;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                        .HasMany(u => u.Notes)
                        .WithOne(n => n.User)
                        .HasForeignKey(n => n.UserId);
            modelBuilder.Entity<Category>()
                        .HasMany(c => c.Notes)
                        .WithOne(n => n.Category)
                        .HasForeignKey(n => n.CategoryId);

            modelBuilder.Entity<User>()
                        .Property(u => u.Name)
                        .HasMaxLength(20);
            modelBuilder.Entity<User>()
                        .Property(u => u.Surname)
                        .HasMaxLength(20);

            modelBuilder.Entity<User>()
                        .Property(u => u.SecretAnswer)
                        .HasMaxLength(20);

            modelBuilder.Entity<User>()
                        .Property(u => u.UserName)
                        .HasMaxLength(20);

            modelBuilder.Entity<Category>()
                        .Property(c => c.CategoryName)
                        .HasMaxLength(20);

            modelBuilder.Entity<Note>()
                        .Property(n => n.Title)
                        .HasMaxLength(50);
            

        }
    }
}
