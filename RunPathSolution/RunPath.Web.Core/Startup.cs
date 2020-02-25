using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Workflow.BusinessLayer;
using Workflow.Config;
using Workflow.Repositories;
using Workflow.WebAPI;

namespace RunPath.Web.Core
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            //   Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<ConfigReader.AppSettings>(Configuration.GetSection("AppSettings"));
            
            //load all dependencies 
            APiDiModule.Load(services);
            RepositoriesDiModule.Load(services);
            BusinessDiModule.Load(services);

            services.AddControllers().AddNewtonsoftJson(option =>
            {
                option.SerializerSettings.ContractResolver = new DefaultContractResolver();
                option.SerializerSettings.Formatting = Formatting.Indented;
            });

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
