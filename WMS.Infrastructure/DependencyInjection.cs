
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WMS.Application.Common.Interface;
using WMS.Infrastructure.Common.Persistance;
using WMS.Infrastructure.Warehouse.Persistance;

namespace WMS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //services.AddScoped<IWareHouseWriteService, WareHouseWriteService>();
            services.AddDbContext<WmsDbContext>(options =>
                options.UseSqlServer(
                    "Server=.;Database=WMS;Trusted_Connection=True;TrustServerCertificate=True"));
            services.AddScoped<IWareHouseRepository, WareHouseRepository>();
            services.AddScoped<IUnitofWork>(serviceProvider=>serviceProvider.GetRequiredService<WmsDbContext>());
            return services;
        }
    }
}
