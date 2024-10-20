using HotelService.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.Infrastructure
{
    public static class Register
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<PostgreSqlContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection")));
        }
    }
}
