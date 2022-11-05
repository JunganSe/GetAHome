using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetAHomeApi.Data.Migrations
{
    public partial class blarg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ResidenceTypes",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ResidenceTypes",
                newName: "Description");
        }
    }
}
