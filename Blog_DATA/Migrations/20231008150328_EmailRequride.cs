using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_DATA.Migrations
{
    public partial class EmailRequride : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1215bf89-b8bf-45c2-a697-5fea7d243fdb", "Admin@gmail.com", "AQAAAAEAACcQAAAAEP8qtri5Ai5quBh2PevRcHjnzmM5pAeCLbU3oQ0VWCmSZTG+68ALB6J+KKjodXmCcw==", "6bff00ff-c624-4145-b5f8-fab406ff544d" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d146fcd-9e67-4f0d-9540-2ccba56d46e3", "admin@gmail.com", "AQAAAAEAACcQAAAAEOVRkIv75SsbLYtv/p/5Pt3z1s+pWHz/z0ewXqiVQBhS7hm4PSdo66iSaU9dwEEbww==", "7a791b76-8af1-498f-ba00-624f2e3612fb" });

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
    }
}
