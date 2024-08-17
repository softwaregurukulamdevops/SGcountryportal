using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Price
    {
        [Key]
        public int PriceId { get; set; }
        [StringLength(100)]
        public string PriceName { get; set; }
        public bool? IsActive { get; set; }
    }
}
