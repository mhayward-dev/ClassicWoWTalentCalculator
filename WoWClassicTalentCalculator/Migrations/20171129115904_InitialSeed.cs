using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WoWClassicTalentCalculator.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WarcraftClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarcraftClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarcraftClassSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpecificationIndex = table.Column<int>(type: "int", nullable: false),
                    SpecificationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarcraftClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarcraftClassSpecifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarcraftClassSpecifications_WarcraftClasses_WarcraftClassId",
                        column: x => x.WarcraftClassId,
                        principalTable: "WarcraftClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecificationTalents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ColumnIndex = table.Column<int>(type: "int", nullable: false),
                    RowIndex = table.Column<int>(type: "int", nullable: false),
                    TalentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarcraftClassSpecificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificationTalents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecificationTalents_WarcraftClassSpecifications_WarcraftClassSpecificationId",
                        column: x => x.WarcraftClassSpecificationId,
                        principalTable: "WarcraftClassSpecifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalentRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RankDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RankNo = table.Column<int>(type: "int", nullable: false),
                    SpecificationTalentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentRanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalentRanks_SpecificationTalents_SpecificationTalentId",
                        column: x => x.SpecificationTalentId,
                        principalTable: "SpecificationTalents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TalentRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RequirementDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TalentRankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalentRequirements_TalentRanks_TalentRankId",
                        column: x => x.TalentRankId,
                        principalTable: "TalentRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpecificationTalents_WarcraftClassSpecificationId",
                table: "SpecificationTalents",
                column: "WarcraftClassSpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentRanks_SpecificationTalentId",
                table: "TalentRanks",
                column: "SpecificationTalentId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentRequirements_TalentRankId",
                table: "TalentRequirements",
                column: "TalentRankId");

            migrationBuilder.CreateIndex(
                name: "IX_WarcraftClassSpecifications_WarcraftClassId",
                table: "WarcraftClassSpecifications",
                column: "WarcraftClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TalentRequirements");

            migrationBuilder.DropTable(
                name: "TalentRanks");

            migrationBuilder.DropTable(
                name: "SpecificationTalents");

            migrationBuilder.DropTable(
                name: "WarcraftClassSpecifications");

            migrationBuilder.DropTable(
                name: "WarcraftClasses");
        }
    }
}
