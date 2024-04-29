using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WMS.Application.Services;

namespace WMS.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //services.AddScoped<IWareHouseWriteService, WareHouseWriteService>();
            services.AddMediatR(options =>
                options.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection)));
            return services;
        }
    }
}
