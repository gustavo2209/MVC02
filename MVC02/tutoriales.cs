namespace MVC02
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tutoriales
    {
        [Key]
        public int idtutorial { get; set; }

        [Required]
        [StringLength(100)]
        public string titulo { get; set; }

        [Required]
        [StringLength(20)]
        public string tipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal precio { get; set; }
    }
}
