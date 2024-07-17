using Businness.Abstract;
using Businness.Concrete;
using DB.Abstract;
using DB.Concrete;
using DB.Context;
using Entity.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness
{
    public static  class Registration
    {
        public static void AddBusinnesLayer(this IServiceCollection services)
        {


            services.AddScoped<IPostService, PostManager>();
            services.AddScoped<IUserService, UserManager>();

        }
    }
}
