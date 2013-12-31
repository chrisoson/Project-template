using Netmentor.DiContainer;
using ProjectName.BackEnd.Services.Products;


namespace ProjectName.BackEnd.Services
{
    public class ServicesDependencyInjection
    {
        public static readonly DiModule DiModule = BuildDependencyInjection();
        private static DiModule BuildDependencyInjection()
        {
            var module = new DiModule(typeof(ServicesDependencyInjection).Assembly);
            return module
                .AddScoped<GetProductService>();
        }
    }
}
