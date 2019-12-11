namespace EntityDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StuddyBuddy")]
    public partial class StuddyBuddy
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Link { get; set; }

        [Required]
        [StringLength(30)]
        public string Faculty { get; set; }

        [Required]
        [StringLength(30)]
        public string Studies { get; set; }

        public int Status { get; set; }

        public int Points { get; set; }
    }
}
