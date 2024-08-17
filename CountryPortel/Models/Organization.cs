using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Organization
    {
        [Key]
        public int OrganizationId { get; set; }
        [StringLength(100)]
        public string OrganizationName { get; set; }
        public bool? IsActive { get; set; }
    }
}
