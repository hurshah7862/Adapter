using DataAccess.IRepository;
using DataAccess.LinQtoSQLRepository;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class ServiceRegistration
    {
        public static void DataAccessServicesRegistration(this IServiceCollection services)
        {
            services.AddScoped<IDatabasesRepository, DatabaseRepository>();
            services.AddScoped<IDatabaseTypeRepository, DatabaseTypeRepository>();
            services.AddScoped<ILoggingRepository, LoggingRepository>();
            services.AddScoped<ILookupRepository, LookupRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
