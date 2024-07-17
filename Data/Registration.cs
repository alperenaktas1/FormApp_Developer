using DB.Abstract;
using DB.Concrete;
using DB.Context;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public static class Registration
    {
        public static void AddDbLayer(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<FormAppDBContext>(opt =>
            //opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //services.AddIdentityCore<User>().AddRoles<AppRole>().AddEntityFrameworkStores<FormAppDBContext>();

            services.AddScoped<IPostDal, EfPostDal>();
            services.AddScoped<IUserDal, EfUserDal>();

            


        }
    }
}
