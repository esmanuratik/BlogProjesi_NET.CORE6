using Blog_ENTİTY.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DATA.Mappings
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder) //IEntityConfiguration implemente ettim ve microsft sayfasında hazır ıdentity user kodları kopyala yapıştur olarak aldım.
        {
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            //Yeni User oluşturuyorum.
            var superadmin = new AppUser
            {
                Id = Guid.Parse("CE819932-AA76-4DFD-BC26-D450CC43644D"),
                UserName = "superadmin@gmail.com",
                NormalizedUserName = "SUPERADMIN@GMAİL.COM",
                Email = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAİL.COM",
                PhoneNumber = "+905674657235",
                FirstName = "Esmanur",
                LastName = "Atik",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            
            superadmin.PasswordHash=CreatePassWordHash(superadmin,"123456");

            var admin = new AppUser
            {
                Id = Guid.Parse("89840E40-5233-4268-A713-01833FBAAEF7"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAİL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAİL.COM",
                PhoneNumber = "+905674657235",
                FirstName = "Admin",
                LastName = "User",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            admin.PasswordHash = CreatePassWordHash(admin, "123456");

            builder.HasData(superadmin,admin);

        }

      
        //Identity den dolayı biz bir kullancı ekledğimizde bu kullanıcının şifresi Hash lenmiş olarak karşımıza çıkıyor bundan dolayı da direkt olarak bir şifre yazmak ve bunu direkt olarak kaydetmek pek de mümkün olmuyor.Bunun için de ilk önce bu metodu yasıp daha osnra user ekliyoruz.
        private string CreatePassWordHash(AppUser user,string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
