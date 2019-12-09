namespace Test.EF.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Test.EF.DAL;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
