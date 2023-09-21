using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_DATA.Migrations
{
    public partial class emailUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d8f44aaf-c2a0-4567-a6bf-cc8d185d8a1b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dd26bfc4-3485-4492-a4f0-369ad22fa6bd"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("851c50a7-cbbd-4952-8602-0868302ba8e0"), new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"), "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Visual Studio Admin Test", new DateTime(2023, 9, 21, 13, 54, 50, 206, DateTimeKind.Local).AddTicks(9425), null, null, new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("89840e40-5233-4268-a713-01833fbaaef7"), 15 },
                    { new Guid("b184216a-d258-4827-aa08-79beaa84f1f5"), new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"), "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Admin Test", new DateTime(2023, 9, 21, 13, 54, 50, 206, DateTimeKind.Local).AddTicks(9420), null, null, new Guid("469d0705-f843-42db-8e28-2eae75ac1270"), false, null, null, "Asp.Net Core Deneme Makalesi", new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("27b7d024-e617-48c4-b738-f6dac56f8f37"),
                column: "ConcurrencyStamp",
                value: "630e216d-2079-482d-ace4-867df2ae6d38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3da0067a-2a84-4841-a0db-228c558ed59d"),
                column: "ConcurrencyStamp",
                value: "a5f44d4d-c1e4-4a19-b4be-203128cb07b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d026549b-b273-4b41-8d4e-7f9894baa63f"),
                column: "ConcurrencyStamp",
                value: "17483f37-d72b-4d4e-9ff5-c29ca8be8faa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89840e40-5233-4268-a713-01833fbaaef7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c586680-2209-445e-893e-9e08777d3871", "AQAAAAEAACcQAAAAEEbr6gK8Re1WDHA1+PsnL+3hzhasYZBcy3pDRiq5JXecC5DafsOrZNX63cHzzy6uAA==", "83f518ca-9f00-44e4-b55c-3064702304cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d571b45b-779d-4101-b6e3-9993b448a693", "AQAAAAEAACcQAAAAEKrJMLbVZEcbTdaVjcho+17Zxb+sAidiQ95m8dGflF/zt2nd1Cz2iassbUAwCG7pZQ==", "5a7dee66-de80-4345-99b7-33930abd2266" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 54, 50, 206, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 54, 50, 206, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 54, 50, 206, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 13, 54, 50, 206, DateTimeKind.Local).AddTicks(9686));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("851c50a7-cbbd-4952-8602-0868302ba8e0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b184216a-d258-4827-aa08-79beaa84f1f5"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("d8f44aaf-c2a0-4567-a6bf-cc8d185d8a1b"), new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"), "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Admin Test", new DateTime(2023, 9, 20, 16, 59, 32, 727, DateTimeKind.Local).AddTicks(15), null, null, new Guid("469d0705-f843-42db-8e28-2eae75ac1270"), false, null, null, "Asp.Net Core Deneme Makalesi", new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"), 15 },
                    { new Guid("dd26bfc4-3485-4492-a4f0-369ad22fa6bd"), new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"), "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Visual Studio Admin Test", new DateTime(2023, 9, 20, 16, 59, 32, 727, DateTimeKind.Local).AddTicks(38), null, null, new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("89840e40-5233-4268-a713-01833fbaaef7"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("27b7d024-e617-48c4-b738-f6dac56f8f37"),
                column: "ConcurrencyStamp",
                value: "33ad36ea-9fe5-415c-96fd-f2fc18304d0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3da0067a-2a84-4841-a0db-228c558ed59d"),
                column: "ConcurrencyStamp",
                value: "8fd74f2b-a408-4b09-9f20-d7c81e8da7e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d026549b-b273-4b41-8d4e-7f9894baa63f"),
                column: "ConcurrencyStamp",
                value: "34e1e2fc-b128-4db2-9ed7-126b312069f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89840e40-5233-4268-a713-01833fbaaef7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d100f185-675f-4832-ba0b-0d33eee6f683", "AQAAAAEAACcQAAAAEEunZC9QG86tVgSdMOg6795ABos+McFqwVFtyJ7rakFfgj1gMGGvWplCOs6Fa1De4w==", "952bed79-5b48-44a3-abd0-456348dd9873" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ace05e5-4973-48d3-a0ab-4fd5ee2233f6", "AQAAAAEAACcQAAAAEN2RSr6bl9t7GCga5T9M6TYD547URI3RVJZzV8XOtfakTSi5EZMv+fRn9hqJOhvaQw==", "f125c646-3fc6-431e-98b2-e0d00c0bee8a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 16, 59, 32, 727, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 16, 59, 32, 727, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 16, 59, 32, 727, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 16, 59, 32, 727, DateTimeKind.Local).AddTicks(501));
        }
    }
}
