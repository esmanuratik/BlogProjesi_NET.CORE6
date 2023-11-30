using Blog_DATA.Context;
using Blog_DATA.Extensions;
using Blog_ENT�TY.Entities;
using Blog_SERV�CE.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Blog_WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.LoadDataLayerExtension(builder.Configuration);//DependencyInjection i�in yazd�k.
            builder.Services.LoadServiceLayerExtension();//configuration kullanmad���m i�in yazmad�m.
            builder.Services.AddSession();

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //Identity yap�lanmas� i�in test a�amas�nan ge�erken password k�sm�nda ilk etapta �ifrelerin 123456 �eklinde olabilmesi i�in b�yle bir yap�land�rma yazd�k fakat Proje canl�ya ta��nd���nda bunun silinmesi gerekiyor
            builder.Services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
            })
                .AddRoleManager<RoleManager<AppRole>>()//Role tabanl� bir yap�land�rma kuraca��m bunun olmas� �nemli
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.ConfigureApplicationCookie(config =>
            {
                //Herhangi bir ki�i url bilse dahi �rne�in admin paneli i�indeki bir yere girmek isterse bu takdirde direk login i�lemi ger�ekle�ecek.
                config.LoginPath = new PathString("/Admin/Auth/Login");//Admin alan�nda Authorization controller da Login action �
                config.LogoutPath = new PathString("/Admin/Auth/Logout");
                config.Cookie = new CookieBuilder
                {
                    Name = "YBlogCore",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest,//Http ve Https ikisinide desteklemesi bak�m�ndan SameRequest kullan�ld�(test a�ams�nda old i�in) fakat canl�ya ta��nd���nda SameRequest yerine Always kullan�lmal� Https desteklemesi i�in (daha g�venli oldu�u i�in) .
                };
                config.SlidingExpiration = true;
                config.ExpireTimeSpan= TimeSpan.FromDays(7);//Cookie de ne kadar s�re ile kalaca��n� g�str.
                config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDonied");//Yetkisiz bir giri� yap�ld���n�da bu sayfaya eri�iminiz yoktur �eklide bir sayfa ile kar��la��lmas�n� s�yler.


            });

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


            app.UseSession();//Cookie i�in bunu ekledik.

            app.UseRouting();
         
            //Authentication ve Authorization s�ralamas� �nemli bu �ekilde olmal�.Yoksa hata almam�za sebep olacakt�r.

            app.UseAuthentication();        
            app.UseAuthorization();
           

            //Burada program �al��t���nda Controller olarak HomeController ve action olarak da Indexin �al��aca��n� s�yl�yor. id si ise al�nadabilir al�nmayadabilir.
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                   name: "Admin",
                   areaName: "Admin",
                  pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapDefaultControllerRoute();//Verdi�im alan� Admin ile �a��raca��m fakat �a��rmazsam default olarak gelsin diye bunu da ekledim.
            });

            app.Run();
        }
    }
}