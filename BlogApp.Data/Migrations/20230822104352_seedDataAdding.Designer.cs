﻿// <auto-generated />
using System;
using BlogApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230822104352_seedDataAdding")]
    partial class seedDataAdding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogApp.Entity.Entities.Article", b =>
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("18bc0835-9cc0-4b96-a425-85c020cc9599"),
                            CategoryId = new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"),
                            Content = "Clean Architecture style focus on a loosely coupled implementation of use cases. Use cases as central organizing structure, decoupled from frameworks and technology details.",
                            CreatedBy = "Admin User",
                            CreatedDate = new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1484),
                            ImageId = new Guid("26d92493-2674-4424-ba1d-1159697d7c03"),
                            IsDeleted = false,
                            Title = ".Net Core Clean Architecture",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("3433398a-1bd1-4e8a-9341-3de5bafedf7c"),
                            CategoryId = new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"),
                            Content = "React is a popular front-end JavaScript library for creating interactive user interfaces. Node.js, on the other hand, is a server-side JavaScript environment that lets developers build scalable web applications with high performance and low latency.",
                            CreatedBy = "Admin User",
                            CreatedDate = new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1490),
                            ImageId = new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"),
                            IsDeleted = false,
                            Title = "Node.js & React Full-Stack Web Application",
                            ViewCount = 10
                        });
                });

            modelBuilder.Entity("BlogApp.Entity.Entities.Category", b =>
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
                            Id = new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"),
                            CreatedBy = "Admin User",
                            CreatedDate = new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1761),
                            IsDeleted = false,
                            Name = ".NET Architecture"
                        },
                        new
                        {
                            Id = new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"),
                            CreatedBy = "Admin User",
                            CreatedDate = new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1776),
                            IsDeleted = false,
                            Name = "MERN Stack Apps"
                        });
                });

            modelBuilder.Entity("BlogApp.Entity.Entities.Image", b =>
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
                            Id = new Guid("26d92493-2674-4424-ba1d-1159697d7c03"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1906),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1909),
                            FileName = "images/nodeimage",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("BlogApp.Entity.Entities.Article", b =>
                {
                    b.HasOne("BlogApp.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogApp.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("BlogApp.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogApp.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
