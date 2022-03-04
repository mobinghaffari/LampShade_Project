using _0_Framework.Application;
using DiscountManagement.Configuration;
using InventoryManagement.Infrastructure.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopManagement.Configuration;
using System;
using System.Text.Encodings.Web;
using BlogManagement.Infrastructure.Configuration;
using System.Text.Unicode;
using CommentManagement.Infrastructure.Configuration;

namespace ServiceHost
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("LampshadeDb");
            ShopManagementBoostrapper.Configure(services, connectionString);
            DiscountManagementBootstrapper.Configure(services, connectionString);
            InventoryManagementBootstrapper.Configure(services, connectionString);
            BlogManagementBootstrapper.Configure(services,connectionString);
            CommentManagementBootstrapper.Configure(services,connectionString);

            services.AddTransient<IFileUploader, FileUploader>();
            services.AddRazorPages();
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Arabic));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
