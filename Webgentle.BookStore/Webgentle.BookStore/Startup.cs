using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Webgentle.BookStore.Data;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("Default");

            services.AddMvc();
            services.AddControllersWithViews();
            services.AddDbContext<BookStoreContext>(options => options.UseSqlServer(connectionString));
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddScoped <IBookRepository , BookRepository >();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                //endpoints.MapDefaultControllerRoute();

                //endpoints.MapControllerRoute(
                //name: "Default",
                //        pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
