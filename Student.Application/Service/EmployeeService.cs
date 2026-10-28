using System;
using System.Collections.Generic;
using System.Text;
using Student.Domain;
using Student.Application;
using Student.Application.DTOs;


namespace Student.Application.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository context;
        public EmployeeService(IEmployeeRepository _context)
        {
            context = _context;
        }
        public async Task<List<EmployeeDetails>> GetAll()
        {
            return await context.GetAll();
        }
        public async Task<EmployeeDetails?> GetById(int id)
        {
            return await context.GetById(id);
        }

        public async Task<EmployeeDetails?> UpdateDetails(int id,EmployeeDetails details)
        {
            return await context.UpdateEmployeeDetails(id, details);
        }

        public async Task<string> AddNewEmployeeData(EmployeeDetails details)
        {
            return await context.AddNewEmployee(details);
        }
      
    }
}
