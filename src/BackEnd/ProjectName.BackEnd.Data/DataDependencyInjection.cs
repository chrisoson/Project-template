using Microsoft.Extensions.DependencyInjection;
using Netmentor.DiContainer;
using ProjectName.BackEnd.Data.Database;
using System;

namespace ProjectName.BackEnd.Data
{
    public class DataDependencyInjection
    {
        public static readonly DiModule DiModule = BuildDependencyInjection();
        private static DiModule BuildDependencyInjection()
        {
            var module = new DiModule(typeof(DataDependencyInjection).Assembly);
            return module
                .AddDependency<DatabaseCredentials>()
                .AddScoped(BuildDatabaseContext);
        }

        private static DatabaseContext BuildDatabaseContext(IServiceProvider services)
        {
            DatabaseCredentials credentials =  services.GetRequiredService<DatabaseCredentials>();
            return new DatabaseContext(credentials.GetDbConnectionString());
        }
    }
}
