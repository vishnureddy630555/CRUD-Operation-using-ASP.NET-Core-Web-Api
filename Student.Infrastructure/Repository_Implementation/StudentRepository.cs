using Student.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Student.Application.StudentInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.ObjectPool;
using Student.Domain;

namespace Student.Infrastructure.Repository_Implementation
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext context;
        public StudentRepository(StudentDbContext _context)
        {
            context = _context;
        }

        public async Task<List<StudentRequestDto>> GetAllStudentDto()
        {
            var student = await context.Students.Select(s => new StudentRequestDto
            {
                StudentName = s.StudentName,
                StudentEmail = s.StudentEmail,
                StudentNumber = s.StudentNumber,
                StudentRollNumber=s.StudentRollNumber

            }).ToListAsync();
            return student;
        }

        // Add Students

        public async Task<string> AddStudent(StudentDetails details)
        {
            var result = await context.Students.AddAsync(details);
            if(result == null)
            {
                return "Not Found";
            }
            await context.SaveChangesAsync();
            return "Added Student Details.";
        }
    }
}
