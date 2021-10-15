using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AngularEshop.Core.Utilites.Extentions.Connection
{
    public static class ConnectionExtention
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {



            var connectionstring = "ConnectionStrings:AngularEshopConnection:Development";

            services.AddDbContext<AngularEshopDbContext>(
                options => options.UseSqlServer(configuration[connectionstring]));


            return services;



        }
    }
}
