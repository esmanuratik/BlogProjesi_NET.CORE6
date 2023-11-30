using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_DATA.Migrations
{
    public partial class addusername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0b5dc75e-f529-4d83-8d33-1aded06ac746"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("495e0e2f-3f09-4044-b5b4-0e20be9fe5a5"));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("af30c93d-e113-482d-9a4b-ac0819280ce5"), new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"), "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Visual Studio Admin Test", new DateTime(2023, 11, 26, 15, 19, 38, 362, DateTimeKind.Local).AddTicks(7417), null, null, new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("89840e40-5233-4268-a713-01833fbaaef7"), 15 },
                    { new Guid("baaf61b7-2af3-4395-b2cc-735f6721afcf"), new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"), "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Admin Test", new DateTime(2023, 11, 26, 15, 19, 38, 362, DateTimeKind.Local).AddTicks(7407), null, null, new Guid("469d0705-f843-42db-8e28-2eae75ac1270"), false, null, null, "Asp.Net Core Deneme Makalesi", new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("27b7d024-e617-48c4-b738-f6dac56f8f37"),
                column: "ConcurrencyStamp",
                value: "cccd2647-bad3-4e1e-a1db-ded31f7db158");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3da0067a-2a84-4841-a0db-228c558ed59d"),
                column: "ConcurrencyStamp",
                value: "988cae7f-7666-484d-805e-2ce8b5cab269");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d026549b-b273-4b41-8d4e-7f9894baa63f"),
                column: "ConcurrencyStamp",
                value: "f4bcb6fe-7824-4aef-b61c-55710a62fcda");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89840e40-5233-4268-a713-01833fbaaef7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "250dfc21-f902-4f20-a070-0370d4b71994", "AQAAAAEAACcQAAAAEA/KtRYdqa0TLCL6sZfKggfu+uzGKAsI6m5Mk9/V/slYp7/5/7VFuGnhqWgxtUFbqA==", "79bf931e-18ef-4ee1-af6b-c628f42952d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bfc911a6-ca06-4df8-bccd-60e35435234a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce00a2da-65df-42fd-ad07-20b03e0b4b70", "AQAAAAEAACcQAAAAEB4deU40bQ0J89xAwtqhUcIaHxwXSjziF3E9n4/MPpuJlsx/yoBRZ3yHT29i+7c7Hw==", "1f202e22-ff85-4b9a-8fd7-f8c6e2b247a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f55c705-a03a-47fb-80ae-0dc0ecfa07dd", "AQAAAAEAACcQAAAAEOd/KhcUchHKwcSpp6aoPtFzNLVATPTcYg4FEPrJ4Ax0CaJy7gkwhGYSAxHkRqoTNQ==", "e20fe7ee-bc06-48bf-971e-c71377fc36bb" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 26, 15, 19, 38, 362, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 26, 15, 19, 38, 362, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 26, 15, 19, 38, 362, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 26, 15, 19, 38, 362, DateTimeKind.Local).AddTicks(7984));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("af30c93d-e113-482d-9a4b-ac0819280ce5"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("baaf61b7-2af3-4395-b2cc-735f6721afcf"));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0b5dc75e-f529-4d83-8d33-1aded06ac746"), new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"), "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Visual Studio Admin Test", new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5198), null, null, new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("89840e40-5233-4268-a713-01833fbaaef7"), 15 },
                    { new Guid("495e0e2f-3f09-4044-b5b4-0e20be9fe5a5"), new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"), "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Admin Test", new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5193), null, null, new Guid("469d0705-f843-42db-8e28-2eae75ac1270"), false, null, null, "Asp.Net Core Deneme Makalesi", new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("27b7d024-e617-48c4-b738-f6dac56f8f37"),
                column: "ConcurrencyStamp",
                value: "35aa9e50-54ac-45bb-85f6-fb37cc636ea5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3da0067a-2a84-4841-a0db-228c558ed59d"),
                column: "ConcurrencyStamp",
                value: "6bd6b9eb-1f5d-47c9-93e5-6d89ec99b41b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d026549b-b273-4b41-8d4e-7f9894baa63f"),
                column: "ConcurrencyStamp",
                value: "f4e6eef8-0114-4808-a273-5f341d98a273");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89840e40-5233-4268-a713-01833fbaaef7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "247f6c4d-2033-4abc-b1c1-cc21e854becb", "AQAAAAEAACcQAAAAEM3M+BCcGrREpOr8kKAHS/D7p4tidWlmjDqqW0SkDRfDlk6Nsij4pFmK1Ph55VSEwg==", "f9bdaeb7-ed91-438f-b992-86204cd87cd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bfc911a6-ca06-4df8-bccd-60e35435234a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f289f15-fb44-4d7e-8c49-ca5165e3524f", "AQAAAAEAACcQAAAAEHSzDofIu9rZOyaeyCaESBuQUmSyVbehmQjNNHTjwujv5KJZCz1vYnGw/2rvRP5HJQ==", "74b6787b-fc29-4788-81f7-192a876a42a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b20140f-9fe5-4526-9640-3736b82137bb", "AQAAAAEAACcQAAAAEKXzsIaTqd7Qa9bEUk6a6MLVFJQxj4cSpTn/jI8E9zYUwE2lk+09Xhe9DjkDQd0ohw==", "3b13796f-15ef-4073-a697-8f9e3ff4bd97" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5482));
        }
    }
}
