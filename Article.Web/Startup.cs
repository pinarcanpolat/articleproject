using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article.Data.Model;
using Article.Repos;
using Article.Repos.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Article.Web
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
            services.AddDbContext<ArticleProjectContext>(x => x.UseSqlServer("Server=LAPTOP-MSFD5SIP\\PINARCANPOLAT;Database = ArticleProject;User Id =sa;Password=1234;Trusted_Connection=True"));
            // services.AddScoped<ArticleProjectContext>();
            //services.AddTransient<IUnityOfWork, UnityOfWork>();
            services.AddTransient<IUnityOfWork, UnityOfWork>();
            services.AddControllers();
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
