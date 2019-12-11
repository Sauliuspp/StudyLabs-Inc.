namespace EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForumThread")]
    public partial class ForumThread
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Creator { get; set; }

        [Required]
        [StringLength(50)]
        public string Topic { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Studies { get; set; }
    }
}
