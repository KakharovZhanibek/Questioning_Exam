namespace Questioning_EXAM.Models.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Questioning_EXAM.Models;

    public partial class MyDB : DbContext
    {
        public MyDB()
            : base("name=MyDB")
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<FIO> FIO { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
       
        public MyDB():base()
        {
            DataBase.SetInitializer(new DropCreateDataBaseIfModelChanges<MyDB>());
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Questions>()
        //        .Has(e => e.Answers)
        //        .WithOptional(e => e.Questions)
        //        .HasForeignKey(e => e.QuestionOfAnswer);
        //}
    }
}
