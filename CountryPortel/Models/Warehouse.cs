using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Warehouse
    {
        [Key]
        public int WarehouseId { get; set; }
        [StringLength(100)]
        public string WarehouseName { get; set; }
        public bool? IsActive { get; set; }
    }
}
