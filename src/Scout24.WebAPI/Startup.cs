using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Scout24.Core.Models;
using Scout24.Core.Queries;
using Scout24.Core.Queries.Handler;
using Scout24.Core.Queries.Query;

namespace Scout24.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureDbContext(DbContextOptionsBuilder options)
        {
            options
                .UseSqlServer(
                    Configuration.GetConnectionString("SQLConnection"),
                    builder => builder.MigrationsAssembly("Scout24.WebAPI")
                )
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        // source.AddScoped<IQueryHandler<TQuery, TResult>, TQueryHandler>();
        // This method gets called by the runtime. Use this method to add services to the container.AllCarsQuery:IQuery<IEnumerable<Car>>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddScoped<IQueryHandler<AllCarsQuery, IEnumerable<Car>>, AllCarsQueryHandler>();
               // .AddQuery<AllCarsQuery, IEnumerable<Car>, AllCarsQueryHandler>();
               


            // ===== Add our DbContext ========
            services.AddDbContext<Scout24Context>(ConfigureDbContext);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
