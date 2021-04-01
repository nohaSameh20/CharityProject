using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Charity.Persistence.Migrations
{
    public partial class mig03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "User",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_User_CountryId",
                table: "User",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Country_CountryId",
                table: "User",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Country_CountryId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CountryId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "User");
        }
    }
}
