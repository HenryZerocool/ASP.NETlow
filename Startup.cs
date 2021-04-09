using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETlow
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false) ;
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            if (configuration.GetValue<bool>("EnableDeveloperExceptions"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
				//customer error handler page
				app.UseExceptionHandler("/error.html");
            }

            app.UseMvc(routes => {
                routes.MapRoute("Default",
                    "{controller=Home}/{action=Index}/{id?}"
                );
            });

            // user static files
            app.UseFileServer();

			// app.UseRouting();

			// app.UseEndpoints(endpoints =>
			// {
			//     endpoints.MapGet("/hello/{name:alpha}", async context =>
			//     {
			//         var name = context.Request.RouteValues["name"];
			//         Console.WriteLine("console change " + name);
			//         await context.Response.WriteAsync($"Hello from {name}!");
			//     });
			//     endpoints.MapGet("/", async context =>
			//     {
			//         await context.Response.WriteAsync($"Hello World!");
			//     });
			//     endpoints.MapGet("/invalid", async context =>
			//     {
			//         // await context.Response.WriteAsync($"Hello World!");
			//         throw new Exception("ERROR!!!");
			//     });
			// });
		}
    }
}
