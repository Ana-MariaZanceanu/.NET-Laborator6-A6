using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace laborator6.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 1, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do .NET Homework!", false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 2, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do ML Homework!", false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 3, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do ISSA Homework!", true });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 4, new DateTime(2020, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do SI Homework!", false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 5, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do Python Homework!", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}
