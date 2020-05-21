using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingMapTypesEditor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MapType",
                table: "Maps",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "MapType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TimeCreated = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    WalkThroughPlayers = table.Column<bool>(nullable: false),
                    CanAttackNpcs = table.Column<bool>(nullable: false),
                    CanAttackPlayers = table.Column<bool>(nullable: false),
                    DropItemsOnDeath = table.Column<bool>(nullable: false),
                    MapNameColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapType");

            migrationBuilder.DropColumn(
                name: "MapType",
                table: "Maps");
        }
    }
}
