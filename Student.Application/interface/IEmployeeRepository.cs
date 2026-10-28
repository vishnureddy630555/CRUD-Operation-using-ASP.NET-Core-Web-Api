using System;
using System.Collections.Generic;
using System.Text;
using Student.Application.DTOs;
using Student.Domain;

namespace Student.Application
{
   public interface IEmployeeRepository
    {
        public Task<List<EmployeeDetails>> GetAll();
        Task<EmployeeDetails?> GetById(int id);
        Task<EmployeeDetails?> UpdateEmployeeDetails(int id,EmployeeDetails details);
        Task<string> AddNewEmployee(EmployeeDetails details);

       
    }
}
