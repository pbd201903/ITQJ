﻿namespace ITQJ.WebPWA.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DocumentType")]
    public class DocumentType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public virtual LegalDocument LegalDocument { get; set; }
    }
}