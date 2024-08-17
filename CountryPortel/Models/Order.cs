using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int? OrderNumber { get; set; }
        public bool? IsActive { get; set; }
    }
}
