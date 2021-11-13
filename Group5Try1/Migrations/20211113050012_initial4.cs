using Microsoft.EntityFrameworkCore.Migrations;

namespace Group5Try1.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Practice Location",
                table: "AccountSetting");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "AccountSetting",
                newName: "PhNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhNumber",
                table: "AccountSetting",
                newName: "Number");

            migrationBuilder.AddColumn<string>(
                name: "Practice Location",
                table: "AccountSetting",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
