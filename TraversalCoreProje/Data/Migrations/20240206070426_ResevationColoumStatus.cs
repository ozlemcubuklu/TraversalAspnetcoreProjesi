using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ResevationColoumStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bool",
                table: "Reservations",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Reservations",
                newName: "Bool");
        }
    }
}
