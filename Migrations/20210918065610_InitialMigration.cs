using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DESCPRIPTION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TOTAL = table.Column<double>(type: "float", nullable: false),
                    DATE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CATEGORY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GPSX = table.Column<double>(type: "float", nullable: false),
                    GPSY = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Uuid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");
        }
    }
}
