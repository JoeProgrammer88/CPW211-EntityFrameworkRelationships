using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW211_EntityFrameworkRelationships.Migrations
{
    public partial class AddedExplicitFKColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Advisor_AssignedAdvisorAdvisorId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AssignedAdvisorAdvisorId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AssignedAdvisorAdvisorId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "AssignedAdvisorId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_AssignedAdvisorId",
                table: "Students",
                column: "AssignedAdvisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Advisor_AssignedAdvisorId",
                table: "Students",
                column: "AssignedAdvisorId",
                principalTable: "Advisor",
                principalColumn: "AdvisorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Advisor_AssignedAdvisorId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AssignedAdvisorId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AssignedAdvisorId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "AssignedAdvisorAdvisorId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
