using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Item
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Active { get; set; }
    }
}
