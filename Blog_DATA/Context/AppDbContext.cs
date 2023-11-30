using Blog_DATA.Mappings;
using Blog_ENTİTY.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DATA.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole,Guid,AppUserClaim,AppUserRole,AppUserLogin,AppRoleClaim,AppUserToken>
        //Bu kısımda sırası ile yazmak önemli ! Guid=Key olarak verdiğimiz yapı.Identity de geçerli olmasını istediğimiz tüm yapımızı burada kurmuş olduk.
    {
        protected AppDbContext()//herhangi bir ihtimale karşı oluşturuldu
        {
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; } 
        public DbSet<Category>Categories { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);//Identity yapısını kullandığımda bunu burada bu şekilde belirtiyorum çünkü aksi takdırde hata alabilirim.


            //builder.ApplyConfiguration(new ArticleMap()); 
            //bu şekilde de okutabilirsin database de fakat bu clean code mantığına aykırı çünkü hepsi için yani bütün tanımladığın mapping class larına uygulaman gerekiyor fakat Assembly ile yazdığımızda bunu katmana müdahale ettiği için otomatik olarak hepsini içine alıyor olacak. 

            //builder.Entity<Article>().Property(x=>x.Title).HasMaxLength(150);
            //bu şekilde de yine aynı şekilde değişikliği yapabilirsin fakat yine clean code mantığına aykırı olacaktır.Bu yüzden de Map Class ların da tanımlamak doğru olacaktır.Ancak zorunlu durumlarda bu şekilide tanımlamak uygun olacaktır.

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //burada Assembly kullanarak katmana müdahale etmiş oluyoruz.
            
        }

    }
}
