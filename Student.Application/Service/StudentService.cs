using Student.Application.DTOs;
using Student.Application.StudentInterface;
using Student.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Application.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository context;
        public StudentService(IStudentRepository _context)
        {
            context = _context;
        }

        public async Task<List<StudentRequestDto>> GetAllStudent()
        {
            return await context.GetAllStudentDto();
        }

        public async Task<string> AddStudentNew(StudentDetails details)
        {
            return await context.AddStudent(details);
        }
    }
}
