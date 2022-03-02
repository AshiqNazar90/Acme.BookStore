using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.BookStore.Migrations
{
    public partial class thirdintial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUserProfiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserProfiles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTransactions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTransactions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AppUserAccounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActNumber = table.Column<int>(type: "int", maxLength: 18, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateofBrith = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    UserTransactionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserAccounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AppUserAccounts_AppUserProfiles_UserID",
                        column: x => x.UserID,
                        principalTable: "AppUserProfiles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserAccounts_AppUserTransactions_UserTransactionID",
                        column: x => x.UserTransactionID,
                        principalTable: "AppUserTransactions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserAccounts_BankName",
                table: "AppUserAccounts",
                column: "BankName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUserAccounts_UserID",
                table: "AppUserAccounts",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserAccounts_UserTransactionID",
                table: "AppUserAccounts",
                column: "UserTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserProfiles_Name",
                table: "AppUserProfiles",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserAccounts");

            migrationBuilder.DropTable(
                name: "AppUserProfiles");

            migrationBuilder.DropTable(
                name: "AppUserTransactions");
        }
    }
}
