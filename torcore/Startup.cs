using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using torcore.Data.Interfaces;
using torcore.Data.Mocks;
using torcore.Data;
using Microsoft.EntityFrameworkCore;

namespace torcore
{
    public class Startup
    {

        private IConfigurationRoot _confString;
        public Startup(IHostingEnvironment hostingEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostingEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        } 

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(options=>options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<iElements, MockElement>();
            services.AddTransient<iCategories, MockCategory>();
            services.AddTransient<iSubCategories, MockSubCategory>();
            services.AddTransient<iMetaDatas, MockMetaData>();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
