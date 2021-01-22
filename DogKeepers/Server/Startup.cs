using System.Reflection;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Transactions;
using System.ComponentModel.Design;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using DogKeepers.Server.Services;
using DogKeepers.Server.Interfaces.Services;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Repositories;
using DogKeepers.Server.Options;

namespace DogKeepers.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddScoped<IDogService, DogService>();
            services.AddScoped<IDogRepository, DogRepository>();
            services.AddScoped<ISizeService, SizeService>();
            services.AddScoped<ISizeRepository, SizeRepository>();
            services.AddSingleton<IBaseRepository, BaseRepository>();
            services.AddScoped<IRaceService, RaceService>();
            services.AddScoped<IRaceRepository, RaceRepository>();

            services.Configure<ConnectionStringsOptions>(
                options =>
                Configuration.GetSection("ConnectionStrings").Bind(options)
            );

            services.Configure<PaginationOption>(
                options =>
                Configuration.GetSection("Pagination").Bind(options)
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}