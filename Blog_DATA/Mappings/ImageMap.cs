using Blog_ENTİTY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog_DATA.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("469D0705-F843-42DB-8E28-2EAE75AC1270"),
                FileName = "Images/TestImage",
                FileType = "jpg",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                
            },
            new Image
            {
                Id = Guid.Parse("214F9F14-7C40-44D1-8BD9-0648A787B77B"),
                FileName = "Visual StudioImages/TestImage",
                FileType = "png",
                CreatedBy = "Visual Studio Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });

        }
    }
}
