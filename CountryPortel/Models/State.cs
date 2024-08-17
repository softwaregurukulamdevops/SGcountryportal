using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class State
    {
        [Key]
        public int StateId { get; set; }
        [StringLength(100)]
        public string StateName { get; set; }
        public bool? IsActive { get; set; }
    }
}
