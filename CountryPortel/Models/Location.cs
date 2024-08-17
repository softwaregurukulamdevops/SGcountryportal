using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Location
    {
        [Key]
        public int LocationId { get; set; }
        [StringLength(100)]
        public string LocationName { get; set; }
        public bool? IsActive { get; set; }
    }
}
