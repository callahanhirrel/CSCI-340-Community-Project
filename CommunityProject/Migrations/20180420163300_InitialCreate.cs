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
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CustID = table.Column<int>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Payment = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    PicConsent = table.Column<bool>(nullable: false),
                    ShirtSize = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
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
                    Consent = table.Column<bool>(nullable: false),
                    CustID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishingDerbyInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GenInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    PicConsent = table.Column<bool>(nullable: false),
                    ShirtSize = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZIP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WalkathonInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustID = table.Column<int>(nullable: false),
                    Payment = table.Column<int>(nullable: false)
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
                name: "GenInfo");

            migrationBuilder.DropTable(
                name: "WalkathonInfo");
        }
    }
}
