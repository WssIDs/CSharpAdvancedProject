using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpAdvancedProjectDAL.Migrations
{
    public partial class AddUniqueIndex_PositionName_on_Position : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Positions_Name",
                table: "Positions",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Positions_Name",
                table: "Positions");
        }
    }
}
