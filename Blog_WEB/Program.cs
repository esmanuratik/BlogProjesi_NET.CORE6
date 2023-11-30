using Blog_DATA.Context;
using Blog_DATA.Extensions;
using Blog_ENTÝTY.Entities;
using Blog_SERVÝCE.Extensions;
using Microsoft.AspNetCore.Identity;
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
            builder.Services.AddSession();

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //Identity yapýlanmasý için test aþamasýnan geçerken password kýsmýnda ilk etapta þifrelerin 123456 þeklinde olabilmesi için böyle bir yapýlandýrma yazdýk fakat Proje canlýya taþýndýðýnda bunun silinmesi gerekiyor
            builder.Services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
            })
                .AddRoleManager<RoleManager<AppRole>>()//Role tabanlý bir yapýlandýrma kuracaðým bunun olmasý önemli
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.ConfigureApplicationCookie(config =>
            {
                //Herhangi bir kiþi url bilse dahi örneðin admin paneli içindeki bir yere girmek isterse bu takdirde direk login iþlemi gerçekleþecek.
                config.LoginPath = new PathString("/Admin/Auth/Login");//Admin alanýnda Authorization controller da Login action ý
                config.LogoutPath = new PathString("/Admin/Auth/Logout");
                config.Cookie = new CookieBuilder
                {
                    Name = "YBlogCore",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest,//Http ve Https ikisinide desteklemesi bakýmýndan SameRequest kullanýldý(test aþamsýnda old için) fakat canlýya taþýndýðýnda SameRequest yerine Always kullanýlmalý Https desteklemesi için (daha güvenli olduðu için) .
                };
                config.SlidingExpiration = true;
                config.ExpireTimeSpan= TimeSpan.FromDays(7);//Cookie de ne kadar süre ile kalacaðýný göstr.
                config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDonied");//Yetkisiz bir giriþ yapýldýðýnýda bu sayfaya eriþiminiz yoktur þeklide bir sayfa ile karþýlaþýlmasýný söyler.


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


            app.UseSession();//Cookie için bunu ekledik.

            app.UseRouting();
         
            //Authentication ve Authorization sýralamasý önemli bu þekilde olmalý.Yoksa hata almamýza sebep olacaktýr.

            app.UseAuthentication();        
            app.UseAuthorization();
           

            //Burada program çalýþtýðýnda Controller olarak HomeController ve action olarak da Indexin çalýþacaðýný söylüyor. id si ise alýnadabilir alýnmayadabilir.
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
                endpoints.MapDefaultControllerRoute();//Verdiðim alaný Admin ile çaðýracaðým fakat çaðýrmazsam default olarak gelsin diye bunu da ekledim.
            });

            app.Run();
        }
    }
}