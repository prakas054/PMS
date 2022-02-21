using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PMS.DAL.Repository.Implementation;
using PMS.DAL.Repository.Intreface;
using PMS.DAL.UnitOfWork.Implementation;
using PMS.DAL.UnitOfWork.Interface;
using PMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PMS.BusinessLayer.Business.Interface;
using PMS.BusinessLayer.Business.Implementation;

namespace PMS.WebApi
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

            services.AddControllers();

            services.AddDbContext<PMSContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("APIConnection"),
                        b => b.MigrationsAssembly(typeof(PMSContext).Assembly.FullName)));

            services.AddTransient<IAppointmentBusiness, AppointmentBusiness>();

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IAllergyRepository, AllergyRepository>();
            services.AddTransient<IRegistrationRepository, RegistrationRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddCors();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PMS.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PMS.WebApi v1"));
            }

            app.UseCors(builder => builder.AllowAnyOrigin()
                                          .AllowAnyMethod()
                                          .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
