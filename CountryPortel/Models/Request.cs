using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Request
    {
        [Key]
        public int RequestId { get; set; }
        [StringLength(100)]
        public string RequestName { get; set; }
        public bool? IsActive { get; set; }
    }
}
