using Proect.Interfaces.StudentsInterfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Proect.ServiceExtension.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
         

            return services;
        }
    }
}