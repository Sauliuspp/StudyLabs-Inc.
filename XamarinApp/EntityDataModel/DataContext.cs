namespace EntityDataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<ForumThread> ForumThreads { get; set; }
        public virtual DbSet<StuddyBuddy> StuddyBuddies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
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

            modelBuilder.Entity<StuddyBuddy>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<StuddyBuddy>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<StuddyBuddy>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<StuddyBuddy>()
                .Property(e => e.Faculty)
                .IsUnicode(false);

            modelBuilder.Entity<StuddyBuddy>()
                .Property(e => e.Studies)
        }
    }
}
