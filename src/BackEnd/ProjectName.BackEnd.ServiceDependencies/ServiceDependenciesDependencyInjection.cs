using Netmentor.DiContainer;
using ProjectName.BackEnd.Data;
using ProjectName.BackEnd.ServiceDependencies.Products;
using ProjectName.BackEnd.Services;
using ProjectName.BackEnd.Services.Products;

namespace ProjectName.BackEnd.ServiceDependencies
{
    public class ServiceDependenciesDependencyInjection
    {
        public static readonly DiModule DiModule = BuildDependencyInjection();
        private static DiModule BuildDependencyInjection()
        {
            var module = new DiModule(typeof(ServiceDependenciesDependencyInjection).Assembly);
            return module
                .ApplyModule(ServicesDependencyInjection.DiModule)
                .ApplyModule(DataDependencyInjection.DiModule)
                .AddScoped<IGetProductServiceDependencies, GetProductServiceDependencies>();
        }
    }
}
