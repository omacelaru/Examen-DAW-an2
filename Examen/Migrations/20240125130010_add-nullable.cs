using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Migrations
{
    /// <inheritdoc />
    public partial class addnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_PublishingHouse_PublishingHouseId",
                table: "Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublishingHouse",
                table: "PublishingHouse");

            migrationBuilder.RenameTable(
                name: "PublishingHouse",
                newName: "PublishingHouses");

            migrationBuilder.AlterColumn<Guid>(
                name: "PublishingHouseId",
                table: "Authors",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublishingHouses",
                table: "PublishingHouses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_PublishingHouses_PublishingHouseId",
                table: "Authors",
                column: "PublishingHouseId",
                principalTable: "PublishingHouses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_PublishingHouses_PublishingHouseId",
                table: "Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublishingHouses",
                table: "PublishingHouses");

            migrationBuilder.RenameTable(
                name: "PublishingHouses",
                newName: "PublishingHouse");

            migrationBuilder.AlterColumn<Guid>(
                name: "PublishingHouseId",
                table: "Authors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublishingHouse",
                table: "PublishingHouse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_PublishingHouse_PublishingHouseId",
                table: "Authors",
                column: "PublishingHouseId",
                principalTable: "PublishingHouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
