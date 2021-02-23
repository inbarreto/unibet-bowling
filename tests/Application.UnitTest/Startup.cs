using Microsoft.Extensions.DependencyInjection;
using Unibet.Challange.Application.Common.Interfaces;
using Unibet.Challange.Infrastructure.Infrastructure;

namespace Application.UnitTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICalculateBowl, BowlingProvider>();
        }
    }
}