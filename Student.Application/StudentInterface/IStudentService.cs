using Student.Application.DTOs;
using Student.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Application.StudentInterface
{
    public interface IStudentService
    {
        public Task<List<StudentRequestDto>> GetAllStudent();
        Task<string> AddStudentNew(StudentDetails details);
    }
}
