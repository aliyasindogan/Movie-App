using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MovieApp.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //mvc ve defaul route ekleniyor
            app.UseMvcWithDefaultRoute();

            if (env.IsDevelopment())
            {
                //custom error 
                app.UseDeveloperExceptionPage();
            }
            //wwwroot kalsorünün static sayfaların ccs resim ve js sayfalarına proje içinden ulaşılması için ekliyoruz 
            app.UseStaticFiles();
            //404 hatası için ekleniyor
            app.UseStatusCodePages();
        }
    }
}
