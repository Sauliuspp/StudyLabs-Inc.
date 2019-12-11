using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using XamarinApp.Models;

namespace EntityModel
{
    public partial class DataModel : DbContext
    {
        public virtual DbSet<ForumThread> ForumThreads { get; set; }
        public virtual DbSet<AStuddyBuddy> StuddyBuddies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"data source=studylabs-inc.database.windows.net;
                    initial catalog=StudyLabs_DB;user id=studylabs;
                    password=Objektinis2019;MultipleActiveResultSets=True;App=EntityFramework");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ForumThread>()
                .Property(e => e.Creator)
                .IsUnicode(false);

            modelBuilder.Entity<ForumThread>()
                .Property(e => e.Topic)
                .IsUnicode(false);

            modelBuilder.Entity<ForumThread>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ForumThread>()
                .Property(e => e.Studies)
                .IsUnicode(false);

            modelBuilder.Entity<AStuddyBuddy>()
                .Property(e => e.Nickname)
                .IsUnicode(false);

            modelBuilder.Entity<AStuddyBuddy>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<AStuddyBuddy>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<AStuddyBuddy>()
                .Property(e => e.Faculty)
                .IsUnicode(false);

            modelBuilder.Entity<AStuddyBuddy>()
                .Property(e => e.Studies)
                .IsUnicode(false);
        }
    }
}
