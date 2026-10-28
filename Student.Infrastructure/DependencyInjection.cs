using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Student.Application;
using Student.Application.StudentInterface;
using Student.Infrastructure.Data;
using Student.Infrastructure.Repository_Implementation;


namespace Student.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<StudentDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")
                ));

            services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("EmployeeConnection")));

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}