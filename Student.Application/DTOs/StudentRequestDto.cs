using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Student.Application.DTOs
{
    public class StudentRequestDto
    {

        public string StudentName { get; set; } = string.Empty;
        public String StudentEmail { get; set; } = string.Empty;
        public long StudentNumber { get; set; }
        public long StudentRollNumber { get; set; }

    }
}
