using System;
using System.Collections.Generic;
using System.Text;
using Student.Application.DTOs;
using Student.Domain;

namespace Student.Application
{
    public interface IEmployeeService
    {
        public Task<List<EmployeeDetails>> GetAll();

        public Task<EmployeeDetails?> GetById(int id);
        public Task<EmployeeDetails?> UpdateDetails(int id, EmployeeDetails details);
        Task<string> AddNewEmployeeData(EmployeeDetails details);

        
    }
}
