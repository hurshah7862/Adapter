using BusinessLogic.Managers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class ServiceRegistration
    {
        public static void BusinessLogicServicesRegistration(this IServiceCollection services)
        {
            services.AddScoped<IDatabasesManager, DatabaseManager>();
            services.AddScoped<IDatabaseTypeManager, DatabaseTypeManager>();
            services.AddScoped<ILoggingManager, LoggingManager>();
            services.AddScoped<ILookupManager, LookupManager>();
            services.AddScoped<ITransactionManager, TransactionManager>();
            services.AddScoped<IUserManager, UserManager>();
        }
    }
}
