namespace AssiPart2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Part2 : DbContext
    {
        public Part2()
            : base("name=Part2")
        {
        }

        public virtual DbSet<child> children { get; set; }
        public virtual DbSet<company> companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<company>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
