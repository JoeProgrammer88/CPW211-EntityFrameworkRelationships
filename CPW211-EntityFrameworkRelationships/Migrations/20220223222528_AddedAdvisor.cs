using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW211_EntityFrameworkRelationships.Migrations
{
    public partial class AddedAdvisor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedAdvisorAdvisorId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Advisor",
                columns: table => new
                {
                    AdvisorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advisor", x => x.AdvisorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_AssignedAdvisorAdvisorId",
                table: "Students",
                column: "AssignedAdvisorAdvisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Advisor_AssignedAdvisorAdvisorId",
                table: "Students",
                column: "AssignedAdvisorAdvisorId",
                principalTable: "Advisor",
                principalColumn: "AdvisorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Advisor_AssignedAdvisorAdvisorId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Advisor");

            migrationBuilder.DropIndex(
                name: "IX_Students_AssignedAdvisorAdvisorId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AssignedAdvisorAdvisorId",
                table: "Students");
        }
    }
}
