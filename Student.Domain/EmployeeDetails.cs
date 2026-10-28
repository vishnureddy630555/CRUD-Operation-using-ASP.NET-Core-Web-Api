using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Student.Domain
{
    public class EmployeeDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage="Only Letters Are Allowed")]
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set;}

    }
}
