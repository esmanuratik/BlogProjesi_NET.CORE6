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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>

    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("CE819932-AA76-4DFD-BC26-D450CC43644D"),//UserMap deki superadmin ıd si
                RoleId = Guid.Parse("27B7D024-E617-48C4-B738-F6DAC56F8F37"),//RoleMap dek superadminrole ıd si
            },
            new AppUserRole
            {
                UserId = Guid.Parse("89840E40-5233-4268-A713-01833FBAAEF7"),//UserMap deki admin ıd si
                RoleId = Guid.Parse("D026549B-B273-4B41-8D4E-7F9894BAA63F"),//RoleMApdeki adminrole ıd si
            });
        }
    }
}
