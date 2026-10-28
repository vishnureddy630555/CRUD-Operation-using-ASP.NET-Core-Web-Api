using Student.Application.DTOs;
using Student.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Application.StudentInterface
{
    public interface IStudentRepository
    {
        public Task<List<StudentRequestDto>> GetAllStudentDto();
        Task<string> AddStudent(StudentDetails details);
    }
}
