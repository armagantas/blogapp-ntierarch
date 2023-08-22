using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataAdding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"), "Admin User", new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1776), null, null, false, null, null, "MERN Stack Apps" },
                    { new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"), "Admin User", new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1761), null, null, false, null, null, ".NET Architecture" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("26d92493-2674-4424-ba1d-1159697d7c03"), "Admin Test", new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1906), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"), "Admin Test", new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1909), null, null, "images/nodeimage", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("18bc0835-9cc0-4b96-a425-85c020cc9599"), new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"), "Clean Architecture style focus on a loosely coupled implementation of use cases. Use cases as central organizing structure, decoupled from frameworks and technology details.", "Admin User", new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1484), null, null, new Guid("26d92493-2674-4424-ba1d-1159697d7c03"), false, null, null, ".Net Core Clean Architecture", 15 },
                    { new Guid("3433398a-1bd1-4e8a-9341-3de5bafedf7c"), new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"), "React is a popular front-end JavaScript library for creating interactive user interfaces. Node.js, on the other hand, is a server-side JavaScript environment that lets developers build scalable web applications with high performance and low latency.", "Admin User", new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1490), null, null, new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"), false, null, null, "Node.js & React Full-Stack Web Application", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("18bc0835-9cc0-4b96-a425-85c020cc9599"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3433398a-1bd1-4e8a-9341-3de5bafedf7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("26d92493-2674-4424-ba1d-1159697d7c03"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
