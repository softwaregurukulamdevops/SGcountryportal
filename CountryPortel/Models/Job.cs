using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Job
    {
        [Key]
        public int JobId { get; set; }
        [StringLength(100)]
        public string JobName { get; set; }
        public int? JobNumber { get; set; }
        public bool? IsActive { get; set; }
    }
}
