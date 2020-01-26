using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Pattern;
using Service;
using Service.Pattern;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServicesAndRepositories(this IServiceCollection services)
        {
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<ISchoolService, SchoolService>();

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentService, StudentService>();

            return services;
        }
    }
}
