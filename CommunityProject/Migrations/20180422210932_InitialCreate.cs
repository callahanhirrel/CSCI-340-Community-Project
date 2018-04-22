using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CommunityProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BowlathonInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Payment = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false),
                    PicConsent = table.Column<bool>(nullable: false),
                    ShirtSize = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    TeamID = table.Column<int>(nullable: false),
                    ZIP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BowlathonInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FishingDerbyInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Consent = table.Column<bool>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    PicConsent = table.Column<bool>(nullable: false),
                    ShirtSize = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    ZIP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishingDerbyInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WalkathonInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Payment = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    PicConsent = table.Column<bool>(nullable: false),
                    ShirtSize = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    ZIP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalkathonInfo", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BowlathonInfo");

            migrationBuilder.DropTable(
                name: "FishingDerbyInfo");

            migrationBuilder.DropTable(
                name: "WalkathonInfo");
        }
    }
}
