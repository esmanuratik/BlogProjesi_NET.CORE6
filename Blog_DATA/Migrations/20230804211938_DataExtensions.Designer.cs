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
    [Migration("20230804211938_DataExtensions")]
    partial class DataExtensions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.Property<Guid>("ImageId")
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

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("df0e3ff1-e999-43ba-b13a-39be6d661639"),
                            CategoryId = new Guid("f312c378-f16b-41f2-8186-e3703ddcd524"),
                            Content = "Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 8, 5, 0, 19, 38, 151, DateTimeKind.Local).AddTicks(8711),
                            ImageId = new Guid("469d0705-f843-42db-8e28-2eae75ac1270"),
                            IsDeleted = false,
                            Title = "Asp.Net Core Deneme Makalesi",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("b2ab0d82-2885-4d6e-9ef7-6e11feab44b1"),
                            CategoryId = new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                            Content = "Visual Studio Lorem Ipsum, kısaca Lipsum, masaüstü yayıncılık ve basın yayın sektöründe kullanılan taklit yazı bloğu olarak tanımlanır. Lipsum, oluşturulacak şablon ve taslaklarda içerik yerine geçerek yazı bloğunu doldurmak için kullanılır.",
                            CreatedBy = "Visual Studio Admin Test",
                            CreatedDate = new DateTime(2023, 8, 5, 0, 19, 38, 151, DateTimeKind.Local).AddTicks(8716),
                            ImageId = new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                            IsDeleted = false,
                            Title = "Visual Studio Deneme Makalesi",
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
                            CreatedDate = new DateTime(2023, 8, 5, 0, 19, 38, 151, DateTimeKind.Local).AddTicks(9080),
                            IsDeleted = false,
                            Name = "Asp.Net Core"
                        },
                        new
                        {
                            Id = new Guid("a984d2ea-6128-44f8-96f8-4aec73217aff"),
                            CreatedBy = "Visual Studio Admin Test",
                            CreatedDate = new DateTime(2023, 8, 5, 0, 19, 38, 151, DateTimeKind.Local).AddTicks(9083),
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
                            CreatedDate = new DateTime(2023, 8, 5, 0, 19, 38, 151, DateTimeKind.Local).AddTicks(9166),
                            FileName = "Images/TestImage",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("214f9f14-7c40-44d1-8bd9-0648a787b77b"),
                            CreatedBy = "Visual Studio Admin Test",
                            CreatedDate = new DateTime(2023, 8, 5, 0, 19, 38, 151, DateTimeKind.Local).AddTicks(9170),
                            FileName = "Visual StudioImages/TestImage",
                            FileType = "png",
                            IsDeleted = false
                        });
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
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog_ENTİTY.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
