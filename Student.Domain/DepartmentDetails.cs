using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Student.Domain
{
    public class DepartmentDetails
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public ICollection<StudentDetails> Student { get; set; } = new List<StudentDetails>();
    }
}
