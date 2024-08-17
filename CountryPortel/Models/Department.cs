using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Department
    {
        public int DepartmentId { get; set; }
        [StringLength(100)]
        public string DepartmentName { get; set; }
        public bool? IsActive { get; set; }
    }
}
