using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Infrastructure.Migrations
{
    public partial class remove_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isnew",
                table: "person");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isnew",
                table: "person",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
