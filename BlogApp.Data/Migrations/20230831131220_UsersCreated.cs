using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UsersCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8636b7af-029e-4fad-9653-170e86c8db97"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("da9bde41-5557-418e-b6e7-aa7497c26ea6"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1a4482aa-de98-4a48-9235-3423af930bc0"), new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"), "Clean Architecture style focus on a loosely coupled implementation of use cases. Use cases as central organizing structure, decoupled from frameworks and technology details.", "Admin User", new DateTime(2023, 8, 31, 16, 12, 20, 333, DateTimeKind.Local).AddTicks(740), null, null, new Guid("26d92493-2674-4424-ba1d-1159697d7c03"), false, null, null, ".Net Core Clean Architecture", 15 },
                    { new Guid("99bb89ef-cd1a-49eb-879f-1cd3b2e7a52c"), new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"), "React is a popular front-end JavaScript library for creating interactive user interfaces. Node.js, on the other hand, is a server-side JavaScript environment that lets developers build scalable web applications with high performance and low latency.", "Admin User", new DateTime(2023, 8, 31, 16, 12, 20, 333, DateTimeKind.Local).AddTicks(750), null, null, new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"), false, null, null, "Node.js & React Full-Stack Web Application", 10 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("23f307eb-f43d-4ff5-8560-a77b4adfda9d"), "ea0acbec-0b52-4f4e-b854-2cac3b7c38ea", "Admin", "ADMIN" },
                    { new Guid("2e842ec9-646d-458e-8701-388b1266d6f1"), "1e823e55-5128-40b1-9e42-03219c317584", "User", "USER" },
                    { new Guid("a1811ff0-8fc3-431e-9a74-456a40db9f2b"), "04a06502-598c-49ff-9aca-159ab0cfc045", "Superadmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("44cfc968-3a34-4b83-8104-57723fc261d9"), 0, "b491636f-0755-4ba5-894e-58036c3808c3", "admin@gmail.com", false, "Maria", "Castellanos", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGoRAk01abdN0biwgSJYAuZexUirVmJAt+FZ2qsKBnSECnAVHUssmwGtTR5LH1CrSQ==", "+905439999998", false, "0b134ad4-e95a-4069-912b-bdf43cabb8f4", false, "admin@gmail.com" },
                    { new Guid("5ba1e7d3-2988-4fe9-a27a-711f5b0d6f55"), 0, "3e9f094e-c959-43d3-8269-16bdbb07c12f", "superadmin@gmail.com", true, "John", "Doe", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECzJSV6PpYKumr+fpOXLke6IDD/79Xrc+s4iddFhmCaOyB+b3jqgrib3cHIzxGRMbg==", "+905439999999", true, "c54f42e8-2ebd-40c3-862a-1b441664b03d", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b099245-e598-42e4-ad35-2673b4f4f090"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 16, 12, 20, 333, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd2e4a58-7c07-4619-aa49-2573e7b1d441"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 16, 12, 20, 333, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("26d92493-2674-4424-ba1d-1159697d7c03"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 16, 12, 20, 333, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b74d71ef-e944-486a-ba69-5b33a6c12f5a"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 16, 12, 20, 333, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("23f307eb-f43d-4ff5-8560-a77b4adfda9d"), new Guid("44cfc968-3a34-4b83-8104-57723fc261d9") },
                    { new Guid("a1811ff0-8fc3-431e-9a74-456a40db9f2b"), new Guid("5ba1e7d3-2988-4fe9-a27a-711f5b0d6f55") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1a4482aa-de98-4a48-9235-3423af930bc0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("99bb89ef-cd1a-49eb-879f-1cd3b2e7a52c"));

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
    }
}
