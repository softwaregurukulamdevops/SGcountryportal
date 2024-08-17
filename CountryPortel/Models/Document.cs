using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Document
    {
        [Key]
        public int DocumentId { get; set; }
        [StringLength(100)]
        public string DocumentName { get; set; }
        public bool? IsActive { get; set; }
    }
}
