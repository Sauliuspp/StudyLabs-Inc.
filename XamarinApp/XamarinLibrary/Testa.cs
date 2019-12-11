namespace XamarinLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Testa
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Pavadinimas { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Nepavadinimas { get; set; }
    }
}
