using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.AspNetCore;
using Student.Application.Service;
using Student.Application.StudentInterface;


namespace Student.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection service)
        {

            service.AddScoped<IEmployeeService, EmployeeService>();
            service.AddScoped<IStudentService, StudentService>();

            return service;
        }
    }
}
