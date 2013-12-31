using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Netmentor.DiContainer;
using ProjectName.BackEnd.Data;
using ProjectName.BackEnd.ServiceDependencies;
using System;

namespace ProjectName.BackEnd.API
{
    public class ApiDependencyInjection
    {
        public static readonly DiModule DiModule = BuildDependencyInjection();
        private static DiModule BuildDependencyInjection()
        {
            var module = new DiModule(typeof(ApiDependencyInjection).Assembly);
            return module
                .AddSingleton(AddDatabaseInformation)
                .ApplyModule(ServiceDependenciesDependencyInjection.DiModule);
        }

        private static DatabaseCredentials AddDatabaseInformation(IServiceProvider services)
        {
            IConfiguration config = services.GetRequiredService<IConfiguration>();
            return  config.GetSection("Database").Get<DatabaseCredentials>();
        }

    }
}
