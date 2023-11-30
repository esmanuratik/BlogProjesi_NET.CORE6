using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_DATA.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d175c6f3-5526-4494-82a3-72ac2a687524"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e258581a-899d-4ef8-8dec-ccdf3b9aef8c"));

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
                keyValue: new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b20140f-9fe5-4526-9640-3736b82137bb", "AQAAAAEAACcQAAAAEKXzsIaTqd7Qa9bEUk6a6MLVFJQxj4cSpTn/jI8E9zYUwE2lk+09Xhe9DjkDQd0ohw==", "3b13796f-15ef-4073-a697-8f9e3ff4bd97" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("bfc911a6-ca06-4df8-bccd-60e35435234a"), 0, "3f289f15-fb44-4d7e-8c49-ca5165e3524f", "esmaatik@gmail.com", true, "Admin2", new Guid("469d0705-f843-42db-8e28-2eae75ac1270"), "Admin", false, null, "Esmaatik@gmail.com", "Esmaatik@gmail.com", "AQAAAAEAACcQAAAAEHSzDofIu9rZOyaeyCaESBuQUmSyVbehmQjNNHTjwujv5KJZCz1vYnGw/2rvRP5HJQ==", "+905456788543", true, "74b6787b-fc29-4788-81f7-192a876a42a8", false, "esmaatik@gmail.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3da0067a-2a84-4841-a0db-228c558ed59d"), new Guid("bfc911a6-ca06-4df8-bccd-60e35435234a") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0b5dc75e-f529-4d83-8d33-1aded06ac746"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("495e0e2f-3f09-4044-b5b4-0e20be9fe5a5"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3da0067a-2a84-4841-a0db-228c558ed59d"), new Guid("bfc911a6-ca06-4df8-bccd-60e35435234a") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bfc911a6-ca06-4df8-bccd-60e35435234a"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("d175c6f3-5526-4494-82a3-72ac2a687524"), new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"), "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Admin Test", new DateTime(2023, 10, 8, 18, 3, 28, 344, DateTimeKind.Local).AddTicks(1908), null, null, new Guid("469d0705-f843-42db-8e28-2eae75ac1270"), false, null, null, "Asp.Net Core Deneme Makalesi", new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"), 15 },
                    { new Guid("e258581a-899d-4ef8-8dec-ccdf3b9aef8c"), new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"), "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.", "Visual Studio Admin Test", new DateTime(2023, 10, 8, 18, 3, 28, 344, DateTimeKind.Local).AddTicks(1914), null, null, new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("89840e40-5233-4268-a713-01833fbaaef7"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("27b7d024-e617-48c4-b738-f6dac56f8f37"),
                column: "ConcurrencyStamp",
                value: "87f64b25-2c92-4111-beb3-9e04b1fdfd7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3da0067a-2a84-4841-a0db-228c558ed59d"),
                column: "ConcurrencyStamp",
                value: "e59bdb57-d524-4991-8a65-070952126c5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d026549b-b273-4b41-8d4e-7f9894baa63f"),
                column: "ConcurrencyStamp",
                value: "ee6dffcf-75bc-495f-887a-6852c90d652c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89840e40-5233-4268-a713-01833fbaaef7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1215bf89-b8bf-45c2-a697-5fea7d243fdb", "AQAAAAEAACcQAAAAEP8qtri5Ai5quBh2PevRcHjnzmM5pAeCLbU3oQ0VWCmSZTG+68ALB6J+KKjodXmCcw==", "6bff00ff-c624-4145-b5f8-fab406ff544d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9027be4f-7331-43e1-ba2b-2fc1b5f452b3", "AQAAAAEAACcQAAAAEKcx9YXIiCG+cQVBm26b+vjF1o37S+yeoR0UDBRDJTGP2k/NUiOPekDL+n+YZu/REw==", "4b3b22cb-0e7c-4ee0-9716-0ceb120aa10c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 18, 3, 28, 344, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 18, 3, 28, 344, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 18, 3, 28, 344, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 8, 18, 3, 28, 344, DateTimeKind.Local).AddTicks(2366));
        }
    }
}
