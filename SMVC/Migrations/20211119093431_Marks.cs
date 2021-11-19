using Microsoft.EntityFrameworkCore.Migrations;

namespace SMVC.Migrations
{
    public partial class Marks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SId",
                table: "Mark",
                newName: "SID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SID",
                table: "Mark",
                newName: "SId");
        }
    }
}
