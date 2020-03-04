namespace Questioning_EXAM.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDB : DbContext
    {
        public MyDB()
            : base("name=MyDB")
        {
        }

        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<FIO> FIO { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questions>()
                .HasMany(e => e.Answers)
                .WithOptional(e => e.Questions)
                .HasForeignKey(e => e.QuestionOfAnswer);
        }
    }
}
