using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASOS.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql;

namespace ASOS
{
    public class Startup
    {

        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContextPool<AppDbContext>(options => options.UseMySql(_config.GetConnectionString("BdConnection")));

            services.AddIdentity<ApplicationUser, RoleApplication>(
                options => {

                    options.Password.RequireDigit = false;
                    options.Password.RequiredUniqueChars = 0;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;

                    options.User.RequireUniqueEmail = true;

                }).AddEntityFrameworkStores<AppDbContext>();

            services.AddScoped<IEquipament, MySqlEquipament>();
            services.AddScoped<IBuyOrder, MySqlBuyOrder>();
            services.AddScoped<IDisplacement, MySqlDisplacement>();
            services.AddScoped<IServiceOrder, MySqlServiceOrder>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseAuthentication();


            app.UseMvcWithDefaultRoute();

        }
    }
}
