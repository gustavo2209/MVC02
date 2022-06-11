using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVC02
{
    public partial class ModelTutoriales : DbContext
    {
        public ModelTutoriales()
            : base("name=ModelTutoriales")
        {
        }

        public virtual DbSet<tutoriales> tutoriales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tutoriales>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<tutoriales>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<tutoriales>()
                .Property(e => e.precio)
                .HasPrecision(12, 2);
        }
    }
}
