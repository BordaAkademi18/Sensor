using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SensorMicroservice.Context;
using SensorMicroservice.Repositories;
using SensorMicroservice.RepositoryInterfaces;

namespace SensorMicroservice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
           .AddJwtBearer(options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,

                   ValidIssuer = "alesta.bordatech.com",
                   ValidAudience = "alesta.bordatech.com",
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["SecurityKey"]))
               };
           });


            services.AddTransient<IAirQualityRepository, AirQualityRepository>();
            services.AddTransient<IRestRoomRepository, RestRoomRepository>();
            services.AddTransient<ICoffeeRepository, CoffeeRepository>();
            services.AddTransient(typeof(Services.NotificationService.NotificationService));

            services.AddDbContext<SensorDbContext>(
                options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                }
            );

            //services.AddMvc();
            {
                services.AddMvc(options =>
                {
                    options.Filters.Add(new RequireHttpsAttribute());
                });
            }

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();

            var options = new RewriteOptions()
         .AddRedirectToHttps(StatusCodes.Status301MovedPermanently, 44384);

            app.UseRewriter(options);

            app.UseMvcWithDefaultRoute();

            //app.UseMvc();
        }
    }
}
