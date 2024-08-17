using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryPortel.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        [StringLength(100)]
        public string EmpFirstName { get; set; }
        [StringLength(100)]
        public string EmpLastName { get; set; }
        [StringLength(150)]
        public string EmpFullName { get; set; }
        [StringLength(50)]
        public string EmpEmail { get; set; }
        public bool? IsActive { get; set; }
    }
}
