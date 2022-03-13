using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.BookStore.Migrations
{
    public partial class pime2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AppUserTransactions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AppUserProfiles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AppUserAccounts",
                newName: "Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "AppUserTransactions",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppUserTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppUserTransactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppUserTransactions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppUserTransactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "AppUserTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserProfileId",
                table: "AppUserTransactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "AppUserProfiles",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppUserProfiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppUserProfiles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppUserProfiles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppUserProfiles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserTransactionID",
                table: "AppUserAccounts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "AppUserAccounts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "AppUserAccounts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppUserAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppUserAccounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppUserAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppUserAccounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUserTransactions_UserProfileId",
                table: "AppUserTransactions",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserTransactions_AppUserProfiles_UserProfileId",
                table: "AppUserTransactions",
                column: "UserProfileId",
                principalTable: "AppUserProfiles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserTransactions_AppUserProfiles_UserProfileId",
                table: "AppUserTransactions");

            migrationBuilder.DropIndex(
                name: "IX_AppUserTransactions_UserProfileId",
                table: "AppUserTransactions");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppUserTransactions");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppUserTransactions");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppUserTransactions");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppUserTransactions");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "AppUserTransactions");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "AppUserTransactions");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppUserProfiles");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppUserProfiles");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppUserProfiles");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppUserProfiles");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppUserAccounts");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppUserAccounts");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppUserAccounts");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppUserAccounts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AppUserTransactions",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AppUserProfiles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AppUserAccounts",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "AppUserTransactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "AppUserProfiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "UserTransactionID",
                table: "AppUserAccounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "AppUserAccounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "AppUserAccounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
