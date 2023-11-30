using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_DATA.Migrations
{
    public partial class Password : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("01e10aa2-64dc-4a56-b603-b2257a87ced7"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bb7b182c-9ca0-4601-910a-4cd95ec8049b"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1b81e547-d69a-488a-9f92-f7b7216ebd51"), new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"), "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Visual Studio Admin Test", new DateTime(2023, 10, 8, 17, 59, 28, 730, DateTimeKind.Local).AddTicks(734), null, null, new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("89840e40-5233-4268-a713-01833fbaaef7"), 15 },
                    { new Guid("96ea23a4-26c8-46ff-a664-3c82344cbdf2"), new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"), "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Admin Test", new DateTime(2023, 10, 8, 17, 59, 28, 730, DateTimeKind.Local).AddTicks(729), null, null, new Guid("469d0705-f843-42db-8e28-2eae75ac1270"), false, null, null, "Asp.Net Core Deneme Makalesi", new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("27b7d024-e617-48c4-b738-f6dac56f8f37"),
                column: "ConcurrencyStamp",
                value: "eba69967-5b15-4d6d-82f7-cba44a0ef2ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3da0067a-2a84-4841-a0db-228c558ed59d"),
                column: "ConcurrencyStamp",
                value: "33c87148-8f2c-453d-844b-9a315af0d16a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d026549b-b273-4b41-8d4e-7f9894baa63f"),
                column: "ConcurrencyStamp",
                value: "2a8e3cd1-b163-43a9-88ae-0aa00ed10fb9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89840e40-5233-4268-a713-01833fbaaef7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d146fcd-9e67-4f0d-9540-2ccba56d46e3", "AQAAAAEAACcQAAAAEOVRkIv75SsbLYtv/p/5Pt3z1s+pWHz/z0ewXqiVQBhS7hm4PSdo66iSaU9dwEEbww==", "7a791b76-8af1-498f-ba00-624f2e3612fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60e671f4-010a-433d-87ac-de43aec41a56", "AQAAAAEAACcQAAAAEKopgLSt41JoYD02Movec7jvN3YSh/t6PAMuE2Ab9kllSzqFt0sdRXykzMpRf1JSUA==", "6d852d1a-61d4-49d6-a354-8383ff677cb5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 17, 59, 28, 730, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 17, 59, 28, 730, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 17, 59, 28, 730, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 17, 59, 28, 730, DateTimeKind.Local).AddTicks(1028));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1b81e547-d69a-488a-9f92-f7b7216ebd51"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("96ea23a4-26c8-46ff-a664-3c82344cbdf2"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("01e10aa2-64dc-4a56-b603-b2257a87ced7"), new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"), "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Visual Studio Admin Test", new DateTime(2023, 10, 8, 16, 45, 12, 494, DateTimeKind.Local).AddTicks(1280), null, null, new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("89840e40-5233-4268-a713-01833fbaaef7"), 15 },
                    { new Guid("bb7b182c-9ca0-4601-910a-4cd95ec8049b"), new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"), "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Admin Test", new DateTime(2023, 10, 8, 16, 45, 12, 494, DateTimeKind.Local).AddTicks(1259), null, null, new Guid("469d0705-f843-42db-8e28-2eae75ac1270"), false, null, null, "Asp.Net Core Deneme Makalesi", new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("27b7d024-e617-48c4-b738-f6dac56f8f37"),
                column: "ConcurrencyStamp",
                value: "715f0ed4-0241-4893-83ea-a000d268857b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3da0067a-2a84-4841-a0db-228c558ed59d"),
                column: "ConcurrencyStamp",
                value: "5a3054f6-d796-40af-ad54-7c6ddad1848f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d026549b-b273-4b41-8d4e-7f9894baa63f"),
                column: "ConcurrencyStamp",
                value: "ef04862f-aa06-4124-b5da-9e62f3b9d8ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89840e40-5233-4268-a713-01833fbaaef7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b68e4dc-1911-4061-9b34-54010f97cdd7", "AQAAAAEAACcQAAAAEC+GC6rOjOaIrWuiOQ95eZ4r4kI4IA8nsEGtJ5HOJs0F6C4CREIDw43bRDFbAVPq5Q==", "713feb59-f6d7-43a0-9c9e-cd8e8a8e3f0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3264dac5-b4c1-43f7-b6c1-f0337e370c4f", "AQAAAAEAACcQAAAAEM5KNGaL7eR5gch8ArhxSqJFto5KFwjDYeVk+S3JAKLpzoimrZ1UttG2d0zoR8fvgg==", "7faf7650-cc01-4c6f-b908-83b35a6d0a2d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 16, 45, 12, 494, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 16, 45, 12, 494, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 16, 45, 12, 494, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 16, 45, 12, 494, DateTimeKind.Local).AddTicks(1565));
        }
    }
}
