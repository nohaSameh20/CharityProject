using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Charity.Persistence.Migrations
{
    public partial class mig01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CaseName = table.Column<string>(nullable: false),
                    CaseDescription = table.Column<string>(nullable: false),
                    CasePhoneNumber = table.Column<string>(nullable: false),
                    CaseAge = table.Column<int>(nullable: false),
                    CaseGender = table.Column<int>(nullable: false),
                    Religion = table.Column<int>(nullable: false),
                    Region = table.Column<string>(nullable: false),
                    FisrtAddress = table.Column<string>(nullable: false),
                    SecondAddress = table.Column<string>(nullable: true),
                    Entitytype = table.Column<int>(nullable: false),
                    EntityName = table.Column<string>(nullable: true),
                    SenderName = table.Column<string>(nullable: false),
                    SenderPhoneNumber = table.Column<string>(nullable: false),
                    SenderAddress = table.Column<string>(nullable: false),
                    CaseAttachment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Descirption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    HashPassword = table.Column<string>(nullable: false),
                    Salt = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PrimaryAddress = table.Column<string>(nullable: true),
                    SecondAddress = table.Column<string>(nullable: true),
                    UserRole = table.Column<int>(nullable: false),
                    CityId = table.Column<Guid>(nullable: false),
                    NationalityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Nationality_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CityId",
                table: "User",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_User_NationalityId",
                table: "User",
                column: "NationalityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Case");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
