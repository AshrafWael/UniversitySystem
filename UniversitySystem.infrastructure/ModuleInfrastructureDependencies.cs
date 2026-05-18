using Microsoft.Extensions.DependencyInjection;
using UniversitySystem.infrastructure.Abstracts;
using UniversitySystem.infrastructure.Repository;

namespace UniversitySystem.infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
