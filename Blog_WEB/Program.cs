using Blog_DATA.Context;
using Blog_DATA.Extensions;
using Blog_SERVÝCE.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Blog_WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.LoadDataLayerExtension(builder.Configuration);//DependencyInjection için yazdýk.
            builder.Services.LoadServiceLayerExtension();//configuration kullanmadýðým için yazmadým.

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //Burada program çalýþtýðýnda Controller olarak HomeController ve action olarak da Indexin çalýþacaðýný söylüyor. id si ise alýnadabilir alýnmayadabilir.
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                   name:"Admin",
                   areaName:"Admin",
                  pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapDefaultControllerRoute();//VErdiðim alaný Admin ilr çaðýracaðým fakat çaðýröazsam default olarak gelsin diye bunu da ekledim.
            });

            app.Run();
        }
    }
}