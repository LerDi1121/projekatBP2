//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DistanceLearningContainer : DbContext
    {
        public DistanceLearningContainer()
            : base("name=DistanceLearningContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Receive> Receives { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Registered> Registereds { get; set; }
        public virtual DbSet<Teaching_topic> Teaching_topic { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Takes> Takes { get; set; }
        public virtual DbSet<Mark> Mark { get; set; }
    }
}
