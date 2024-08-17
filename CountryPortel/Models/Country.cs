using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Country
    {
        [Key]
        public int CountryId { get; set; }
        [StringLength(100)]
        public string CountryName { get; set; }
        public bool? IsActive { get; set; }
    }
}
