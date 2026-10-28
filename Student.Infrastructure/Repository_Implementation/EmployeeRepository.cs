using Microsoft.EntityFrameworkCore;
using Student.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Student.Domain;
using Student.Application;

namespace Student.Infrastructure.Repository_Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext context;
        public EmployeeRepository(EmployeeDbContext _context)
        {
            context = _context;
        }

        public async Task<List<EmployeeDetails>> GetAll()
        {
            var result = await context.Employees.ToListAsync();

            return result;
        }

        public async Task<EmployeeDetails?> GetById(int id)
        {
            var result = await context.Employees.FindAsync(id);

            return result;
        }

        public async Task<EmployeeDetails?> UpdateEmployeeDetails(int id,EmployeeDetails details)
        {
           

            var find = await context.Employees.FirstOrDefaultAsync(x =>x.Id == id);
            if(find == null)
            {
                return null;
            }

            find.Name = details.Name;
            find.Salary = details.Salary;

            await context.SaveChangesAsync();

            return new EmployeeDetails
            {
                Name=find.Name,
                Salary=find.Salary
            };
        }

        public  async Task<string> AddNewEmployee(EmployeeDetails details)
        {
            var result =  context.Employees.AddAsync(details);
            if(details == null)
            {
                return "null";
            }

             await context.SaveChangesAsync();

            return "Employee Added Successfully";
            
        }
    }
}
