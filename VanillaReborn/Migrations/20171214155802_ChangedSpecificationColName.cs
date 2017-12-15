using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VanillaReborn.Migrations
{
    public partial class ChangedSpecificationColName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecificationImage",
                table: "WarcraftClassSpecifications");

            migrationBuilder.AddColumn<string>(
                name: "SpecificationIcon",
                table: "WarcraftClassSpecifications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecificationIcon",
                table: "WarcraftClassSpecifications");

            migrationBuilder.AddColumn<string>(
                name: "SpecificationImage",
                table: "WarcraftClassSpecifications",
                nullable: true);
        }
    }
}
