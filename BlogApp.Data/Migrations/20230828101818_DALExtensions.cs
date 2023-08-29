using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("18bc0835-9cc0-4b96-a425-85c020cc9599"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3433398a-1bd1-4e8a-9341-3de5bafedf7c"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("8636b7af-029e-4fad-9653-170e86c8db97"), new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"), "React is a popular front-end JavaScript library for creating interactive user interfaces. Node.js, on the other hand, is a server-side JavaScript environment that lets developers build scalable web applications with high performance and low latency.", "Admin User", new DateTime(2023, 8, 28, 13, 18, 18, 267, DateTimeKind.Local).AddTicks(4281), null, null, new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"), false, null, null, "Node.js & React Full-Stack Web Application", 10 },
                    { new Guid("da9bde41-5557-418e-b6e7-aa7497c26ea6"), new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"), "Clean Architecture style focus on a loosely coupled implementation of use cases. Use cases as central organizing structure, decoupled from frameworks and technology details.", "Admin User", new DateTime(2023, 8, 28, 13, 18, 18, 267, DateTimeKind.Local).AddTicks(4272), null, null, new Guid("26d92493-2674-4424-ba1d-1159697d7c03"), false, null, null, ".Net Core Clean Architecture", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 13, 18, 18, 267, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 13, 18, 18, 267, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("26d92493-2674-4424-ba1d-1159697d7c03"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 13, 18, 18, 267, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 13, 18, 18, 267, DateTimeKind.Local).AddTicks(4649));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8636b7af-029e-4fad-9653-170e86c8db97"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("da9bde41-5557-418e-b6e7-aa7497c26ea6"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("18bc0835-9cc0-4b96-a425-85c020cc9599"), new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"), "Clean Architecture style focus on a loosely coupled implementation of use cases. Use cases as central organizing structure, decoupled from frameworks and technology details.", "Admin User", new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1484), null, null, new Guid("26d92493-2674-4424-ba1d-1159697d7c03"), false, null, null, ".Net Core Clean Architecture", 15 },
                    { new Guid("3433398a-1bd1-4e8a-9341-3de5bafedf7c"), new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"), "React is a popular front-end JavaScript library for creating interactive user interfaces. Node.js, on the other hand, is a server-side JavaScript environment that lets developers build scalable web applications with high performance and low latency.", "Admin User", new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1490), null, null, new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"), false, null, null, "Node.js & React Full-Stack Web Application", 10 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("26d92493-2674-4424-ba1d-1159697d7c03"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 13, 43, 52, 17, DateTimeKind.Local).AddTicks(1909));
        }
    }
}
