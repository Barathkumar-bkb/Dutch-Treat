using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.IO;
using System.Linq;
using System.Threading.Tasks;
=======
using System.Linq;
using System.Threading.Tasks;
using DutchTreat.Services;
>>>>>>> Add project files.
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
<<<<<<< HEAD
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace Dutch_Treat
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //app.Run(async context =>
            //   {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //// }
            //);


            app.UseFileServer(new FileServerOptions()
        {
            FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"))
        });
        }
    }
=======
using Microsoft.Extensions.Hosting;

namespace DutchTreat
{
  public class Startup
  {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddTransient<IMailService, NullMailService>();

      services.AddControllersWithViews()
        .AddRazorRuntimeCompilation();
      services.AddRazorPages();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        // Add Error Page
        app.UseExceptionHandler("/error");
      }

      app.UseStaticFiles();

      app.UseRouting();

      app.UseEndpoints(cfg =>
      {
        cfg.MapControllerRoute("Fallback",
          "{controller}/{action}/{id?}",
          new { controller = "App", action = "Index" });

        cfg.MapRazorPages();
      });
    }
  }
>>>>>>> Add project files.
}
