using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Unibet.Challange.Application.Common.Interfaces;
using Unibet.Challange.Infrastructure.Infrastructure;

namespace Unibet.Challange.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<ICalculateBowl, BowlProvider>();
            return services;
        }
    }
}