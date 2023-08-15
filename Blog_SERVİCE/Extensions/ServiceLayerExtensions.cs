using Blog_DATA.Context;
using Blog_DATA.Repositories.Abstracts;
using Blog_DATA.Repositories.Concrete;
using Blog_DATA.UnitOfWorks;
using Blog_SERVİCE.Services.Abstract;
using Blog_SERVİCE.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog_SERVİCE.Extensions
{
    public static class ServiceLayerExtensions
    {
        
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)//program.cs de bunu belirtmelisin.
        {
            var assembly = Assembly.GetExecutingAssembly();//Assembly bu sınıfın çağırıldığı AutoMapper ın eklediği katmanın ismi
            services.AddAutoMapper(assembly);

            services.AddScoped<IArticleService, ArticleService>(); //ArticleService IArticleServiceden türetildi bunu belirtiyorum.

            return services;
        }

    }
}
