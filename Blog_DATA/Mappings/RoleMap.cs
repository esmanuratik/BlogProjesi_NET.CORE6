using Blog_ENTİTY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DATA.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();


            //Yeni Role ooluşturalım...
            builder.HasData(new AppRole
            {
                Id = Guid.Parse("27B7D024-E617-48C4-B738-F6DAC56F8F37"),
                Name="SuperAdmin",
                NormalizedName="SUPERADMİN",
                ConcurrencyStamp=Guid.NewGuid().ToString()
                //CocurrencyStamp Aynı anda işlem yapıldığında milisaniyesine kadar yapılan işlemler aynı olmayacağından dolayı önce yapılan işlemi tespit edip çakışmayı önler.
            },
            new AppRole
            {
                Id=Guid.Parse("D026549B-B273-4B41-8D4E-7F9894BAA63F"),
                Name="Admin",
                NormalizedName="ADMIN",
                ConcurrencyStamp=Guid.NewGuid().ToString()
            },
            new AppRole
            {
                Id=Guid.Parse("3DA0067A-2A84-4841-A0DB-228C558ED59D"),
                Name="User",
                NormalizedName = "USER",
                ConcurrencyStamp=Guid.NewGuid().ToString()

            }); 
        }
    }
}
