using Microsoft.Extensions.DependencyInjection;
using UniversitySystem.Service.Abstracts;
using UniversitySystem.Service.Implimentation;

namespace UniversitySystem.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IStudentService,StudentService>();
            return services;
        }
    }
}
