using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_DATA.Migrations
{
    public partial class SeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"), "Visual Studio Admin Test", new DateTime(2023, 7, 14, 15, 21, 25, 539, DateTimeKind.Local).AddTicks(5114), null, null, false, null, null, "Visual Studio" },
                    { new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"), "Admin Test", new DateTime(2023, 7, 14, 15, 21, 25, 539, DateTimeKind.Local).AddTicks(5099), null, null, false, null, null, "Asp.Net Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"), "Visual Studio Admin Test", new DateTime(2023, 7, 14, 15, 21, 25, 539, DateTimeKind.Local).AddTicks(5197), null, null, "Visual StudioImages/TestImage", "png", false, null, null },
                    { new Guid("469d0705-f843-42db-8e28-2eae75ac1270"), "Admin Test", new DateTime(2023, 7, 14, 15, 21, 25, 539, DateTimeKind.Local).AddTicks(5194), null, null, "Images/TestImage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("6038e9c0-0de1-4b0d-abbe-1ad3e72c8db3"), new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"), "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Admin Test", new DateTime(2023, 7, 14, 15, 21, 25, 539, DateTimeKind.Local).AddTicks(4891), null, null, new Guid("469d0705-f843-42db-8e28-2eae75ac1270"), false, null, null, "Asp.Net Core Deneme Makalesi", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("65690f1c-7f2b-44cd-952c-14521838d6fe"), new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"), "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Visual Studio Admin Test", new DateTime(2023, 7, 14, 15, 21, 25, 539, DateTimeKind.Local).AddTicks(4896), null, null, new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"), false, null, null, "Visual Studio Deneme Makalesi", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6038e9c0-0de1-4b0d-abbe-1ad3e72c8db3"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("65690f1c-7f2b-44cd-952c-14521838d6fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("469d0705-f843-42db-8e28-2eae75ac1270"));
        }
    }
}
