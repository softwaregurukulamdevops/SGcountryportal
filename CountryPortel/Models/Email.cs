using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Email
    {
        [Key]
        public int EmailId { get; set; }
        [Column("Email")]
        [StringLength(100)]
        public string Email1 { get; set; }
        public bool? IsActive { get; set; }
    }
}
