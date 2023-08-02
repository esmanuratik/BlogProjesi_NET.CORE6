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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder) //bunu AppDbContext de override edeceğiz ikisi de database i etkiliyor onun için oraya yazdık.
        {
            builder.Property(x=>x.Title).HasMaxLength(150);
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.Net Core Deneme Makalesi",
                Content = "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.",
                ViewCount = 15,
                CategoryId = Guid.Parse("F312C378-F16B-41F2-8186-E3703DDCD524"),
                ImageId = Guid.Parse("469D0705-F843-42DB-8E28-2EAE75AC1270"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi",
                Content = "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.",
                ViewCount = 15,              
                CategoryId =Guid.Parse("A984D2EA-6128-44F8-96F8-4AEC73217AFF"),
                ImageId = Guid.Parse("214F9F14-7C40-44D1-8BD9-0648A787B77B"),
                CreatedBy = "Visual Studio Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }

            
            );
        }
    }
}
