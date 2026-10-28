using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Student.Domain
{
    public class StudentDetails
    {
       
        
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        public string StudentState { get; set; } = string.Empty;
        public long StudentNumber { get; set; }
        public long StudentRollNumber { get; set; }

        public int DepartmentId { get; set; }
        public DepartmentDetails? Department { get; set; }
    }
}
