using Microsoft.EntityFrameworkCore.Migrations;

namespace Group5Try1.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NPI No",
                table: "Setting",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Practice Location",
                table: "Setting",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NPI No",
                table: "Setting");

            migrationBuilder.DropColumn(
                name: "Practice Location",
                table: "Setting");
        }
    }
}
