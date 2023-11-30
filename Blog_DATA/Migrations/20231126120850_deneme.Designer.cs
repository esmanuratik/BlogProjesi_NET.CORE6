﻿// <auto-generated />
using System;
using Blog_DATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog_DATA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231126120850_deneme")]
    partial class deneme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("27b7d024-e617-48c4-b738-f6dac56f8f37"),
                            ConcurrencyStamp = "35aa9e50-54ac-45bb-85f6-fb37cc636ea5",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMİN"
                        },
                        new
                        {
                            Id = new Guid("d026549b-b273-4b41-8d4e-7f9894baa63f"),
                            ConcurrencyStamp = "f4e6eef8-0114-4808-a273-5f341d98a273",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("3da0067a-2a84-4841-a0db-228c558ed59d"),
                            ConcurrencyStamp = "6bd6b9eb-1f5d-47c9-93e5-6d89ec99b41b",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("89840e40-5233-4268-a713-01833fbaaef7"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "247f6c4d-2033-4abc-b1c1-cc21e854becb",
                            Email = "Admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAİL.COM",
                            NormalizedUserName = "ADMIN@GMAİL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEM3M+BCcGrREpOr8kKAHS/D7p4tidWlmjDqqW0SkDRfDlk6Nsij4pFmK1Ph55VSEwg==",
                            PhoneNumber = "+905676757235",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f9bdaeb7-ed91-438f-b992-86204cd87cd3",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5b20140f-9fe5-4526-9640-3736b82137bb",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Esmanur",
                            ImageId = new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                            LastName = "Atik",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAİL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAİL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKXzsIaTqd7Qa9bEUk6a6MLVFJQxj4cSpTn/jI8E9zYUwE2lk+09Xhe9DjkDQd0ohw==",
                            PhoneNumber = "+905674657235",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "3b13796f-15ef-4073-a697-8f9e3ff4bd97",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("bfc911a6-ca06-4df8-bccd-60e35435234a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f289f15-fb44-4d7e-8c49-ca5165e3524f",
                            Email = "esmaatik@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin2",
                            ImageId = new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "Esmaatik@gmail.com",
                            NormalizedUserName = "Esmaatik@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEHSzDofIu9rZOyaeyCaESBuQUmSyVbehmQjNNHTjwujv5KJZCz1vYnGw/2rvRP5HJQ==",
                            PhoneNumber = "+905456788543",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "74b6787b-fc29-4788-81f7-192a876a42a8",
                            TwoFactorEnabled = false,
                            UserName = "esmaatik@gmail.com"
                        });
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                            RoleId = new Guid("27b7d024-e617-48c4-b738-f6dac56f8f37")
                        },
                        new
                        {
                            UserId = new Guid("89840e40-5233-4268-a713-01833fbaaef7"),
                            RoleId = new Guid("d026549b-b273-4b41-8d4e-7f9894baa63f")
                        },
                        new
                        {
                            UserId = new Guid("bfc911a6-ca06-4df8-bccd-60e35435234a"),
                            RoleId = new Guid("3da0067a-2a84-4841-a0db-228c558ed59d")
                        });
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("495e0e2f-3f09-4044-b5b4-0e20be9fe5a5"),
                            CategoryId = new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"),
                            Content = "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5193),
                            ImageId = new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                            IsDeleted = false,
                            Title = "Asp.Net Core Deneme Makalesi",
                            UserId = new Guid("ce819932-aa76-4dfd-bc26-d450cc43644d"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("0b5dc75e-f529-4d83-8d33-1aded06ac746"),
                            CategoryId = new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                            Content = "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.",
                            CreatedBy = "Visual Studio Admin Test",
                            CreatedDate = new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5198),
                            ImageId = new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                            IsDeleted = false,
                            Title = "Visual Studio Deneme Makalesi",
                            UserId = new Guid("89840e40-5233-4268-a713-01833fbaaef7"),
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5382),
                            IsDeleted = false,
                            Name = "Asp.Net Core"
                        },
                        new
                        {
                            Id = new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                            CreatedBy = "Visual Studio Admin Test",
                            CreatedDate = new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5385),
                            IsDeleted = false,
                            Name = "Visual Studio"
                        });
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5482),
                            FileName = "Images/TestImage",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                            CreatedBy = "Visual Studio Admin Test",
                            CreatedDate = new DateTime(2023, 11, 26, 15, 8, 49, 684, DateTimeKind.Local).AddTicks(5484),
                            FileName = "Visual StudioImages/TestImage",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("Blog_ENTİTY.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUser", b =>
                {
                    b.HasOne("Blog_ENTİTY.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUserClaim", b =>
                {
                    b.HasOne("Blog_ENTİTY.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUserLogin", b =>
                {
                    b.HasOne("Blog_ENTİTY.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUserRole", b =>
                {
                    b.HasOne("Blog_ENTİTY.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog_ENTİTY.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUserToken", b =>
                {
                    b.HasOne("Blog_ENTİTY.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.Article", b =>
                {
                    b.HasOne("Blog_ENTİTY.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog_ENTİTY.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("Blog_ENTİTY.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
