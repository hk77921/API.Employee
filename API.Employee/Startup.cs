using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Employee.Context;
using API.Employee.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace API.Employee
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
            services.AddDbContext<APIContext>(opt => opt.UseInMemoryDatabase("EmployeeDB"));
           

            services.AddSwaggerGen(c =>
            {
               // c.IncludeXmlComments(string.Format(@"{0}\API.Employee.xml", System.AppDomain.CurrentDomain.BaseDirectory));
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version ="V1",
                    Title ="Employee API",
                }
                    );
            });

            services.AddControllers();
            services.AddScoped<IPermamentEmployee, PermamentEmployeeRepository>();
            services.AddScoped<ITemporaryEmployee, TemporaryEmployeeRepository>(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI( c=>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API.Employee");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
