using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialModelsCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatabaseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lookups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lookups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lookups_Lookups_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Lookups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsSuperAdmin = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Databases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DatabaseTypeId = table.Column<int>(type: "int", nullable: false),
                    ConnectionString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Databases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Databases_DatabaseTypes_DatabaseTypeId",
                        column: x => x.DatabaseTypeId,
                        principalTable: "DatabaseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Databases_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loggings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Request = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loggings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loggings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceDatabaseId = table.Column<int>(type: "int", nullable: false),
                    TargetDatabaseId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Databases_SourceDatabaseId",
                        column: x => x.SourceDatabaseId,
                        principalTable: "Databases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_Databases_TargetDatabaseId",
                        column: x => x.TargetDatabaseId,
                        principalTable: "Databases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DatabaseTypes",
                columns: new[] { "Id", "CreatedBy", "IsActive", "ModifiedBy", "ModifiedOn", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, 1, true, null, null, "Microsoft SQL Server", 1 },
                    { 2, 1, true, null, null, "PostgreSQL", 1 },
                    { 3, 1, true, null, null, "MySQL", 1 },
                    { 4, 1, true, null, null, "Cosmos DB", 2 },
                    { 5, 1, true, null, null, "Mongo DB", 3 },
                    { 6, 1, true, null, null, "Dynamo DB", 3 },
                    { 7, 1, true, null, null, "Azure Storage Table", 2 }
                });

            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "Id", "CreatedBy", "GroupId", "IsActive", "Key", "ModifiedBy", "ModifiedOn", "ParentId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, true, "SQL Relational DB", null, null, null, "SRD" },
                    { 2, 1, 1, true, "SQL Non-Relational DB", null, null, null, "SNRD" },
                    { 3, 1, 1, true, "NoSQL Non-Relational DB", null, null, null, "NSNRD" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "Email", "FullName", "IsActive", "IsSuperAdmin", "Mobile", "ModifiedBy", "ModifiedOn", "UserName" },
                values: new object[] { 1, 1, "hurshah7862@gmail.com", "Hur Abbas Shah", true, true, "+92 (305) 6252620", null, null, "hurshah7862" });

            migrationBuilder.CreateIndex(
                name: "IX_Databases_DatabaseTypeId",
                table: "Databases",
                column: "DatabaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Databases_Name",
                table: "Databases",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Databases_UserId",
                table: "Databases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DatabaseTypes_Name",
                table: "DatabaseTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loggings_UserId",
                table: "Loggings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lookups_ParentId",
                table: "Lookups",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_SourceDatabaseId",
                table: "Transactions",
                column: "SourceDatabaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TargetDatabaseId",
                table: "Transactions",
                column: "TargetDatabaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loggings");

            migrationBuilder.DropTable(
                name: "Lookups");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Databases");

            migrationBuilder.DropTable(
                name: "DatabaseTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
