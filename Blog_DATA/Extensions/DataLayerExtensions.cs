using Blog_DATA.Context;
using Blog_DATA.Repositories.Abstracts;
using Blog_DATA.Repositories.Concrete;
using Blog_DATA.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DATA.Extensions
{
    public static class DataLayerExtensions
    {
        //DependencyInjection kullanmak için bunhu yazdık .IServiceCollection arayüzünü kullandık ve LoadDataLayerExtension ile iki parametre vererek ki iki tane parametre alır Repository ve Irepositor bağlamış olduk.
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            //builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            //bu şekilde yazdığım sql e bağlanmak için configuration ı extensions da yazıyorum ki yine aynı anlama gelir ve ayrıca program.cs de kod kalabalığına sebep olmaz .Dolayısıyla Blog.Web katmanındaki SQl server bağımlılığını(yüklenen entityframework paketini SQlserver) kaldırabiliriz.Bunları kaldırmalıyız çünkü projenin çalışmasında maliyeti yükseltip çalışma hızını azltıyor.

            services.AddScoped<IUnitOfWork, UnitOfWork>();//Her IUnitOfWork istendiğinde UnitofWork de gelsin diye burada service ile tanımlıyoruz.

            return services;
        }
    }
}
