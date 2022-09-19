using HospitalProject.Infrastructure.Data;
using HospitalProject.Infrastructure.Repository;
using HospitalProject.Service.Implementation.Services;
using HospitalProject.Service.Interface.Repository;
using HospitalProject.Service.Interface.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalProject.Api
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
         services.AddDbContext<AppDbContext>(option => option.
         UseSqlServer(Configuration.GetConnectionString
         ("DefaultConnection")));
         services.AddScoped<IpatientRepository, PatientRepository>();
         services.AddScoped<IDoctorRepository, DoctorRepository>();
         services.AddScoped<IBillRepository, BillRepository>();
         services.AddScoped<IPatientService, PatientServices>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IBillService, BillService>();
        services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HospitalProject.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HospitalProject.Api v1"));
            }

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
