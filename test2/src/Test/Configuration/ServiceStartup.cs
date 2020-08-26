using Microsoft.Extensions.DependencyInjection;
using MyCompany.Domain.Services;
using MyCompany.Domain.Services.Interfaces;


namespace MyCompany.Configuration {
    public static class ServiceStartup
    {
        public static IServiceCollection AddServiceModule(this IServiceCollection @this)
        {
            // services will be added here by the generator
            return @this;
        }
    }
}
