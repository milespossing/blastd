using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blastd_server.Migrations
{
    public partial class relationshipTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SponsorRelationship",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SponsorID = table.Column<int>(nullable: true),
                    AccountableID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorRelationship", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SponsorRelationship_Users_AccountableID",
                        column: x => x.AccountableID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SponsorRelationship_Users_SponsorID",
                        column: x => x.SponsorID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SponsorRelationship_AccountableID",
                table: "SponsorRelationship",
                column: "AccountableID");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorRelationship_SponsorID",
                table: "SponsorRelationship",
                column: "SponsorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SponsorRelationship");
        }
    }
}
