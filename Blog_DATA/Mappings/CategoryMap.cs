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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {              
                    Id = Guid.Parse("F312C378-F16B-41F2-8186-E3703DDCD524"),
                    Name = "Asp.Net Core",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
               
            },
            new Category
            {
                Id = Guid.Parse("A984D2EA-6128-44F8-96F8-4AEC73217AFF"),
                Name = "Visual Studio",
                CreatedBy = "Visual Studio Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });

        }
    }
}

