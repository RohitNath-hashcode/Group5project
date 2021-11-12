using Microsoft.EntityFrameworkCore.Migrations;

namespace Group5Try1.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Setting",
                table: "Setting");

            migrationBuilder.RenameTable(
                name: "Setting",
                newName: "AccountSetting");

            migrationBuilder.AddColumn<int>(
                name: "PLocation_id",
                table: "AccountSetting",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Speciality_id",
                table: "AccountSetting",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountSetting",
                table: "AccountSetting",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Catagory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountSetting_PLocation_id",
                table: "AccountSetting",
                column: "PLocation_id");

            migrationBuilder.CreateIndex(
                name: "IX_AccountSetting_Speciality_id",
                table: "AccountSetting",
                column: "Speciality_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountSetting_PLocations_PLocation_id",
                table: "AccountSetting",
                column: "PLocation_id",
                principalTable: "PLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountSetting_Specialities_Speciality_id",
                table: "AccountSetting",
                column: "Speciality_id",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountSetting_PLocations_PLocation_id",
                table: "AccountSetting");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountSetting_Specialities_Speciality_id",
                table: "AccountSetting");

            migrationBuilder.DropTable(
                name: "PLocations");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountSetting",
                table: "AccountSetting");

            migrationBuilder.DropIndex(
                name: "IX_AccountSetting_PLocation_id",
                table: "AccountSetting");

            migrationBuilder.DropIndex(
                name: "IX_AccountSetting_Speciality_id",
                table: "AccountSetting");

            migrationBuilder.DropColumn(
                name: "PLocation_id",
                table: "AccountSetting");

            migrationBuilder.DropColumn(
                name: "Speciality_id",
                table: "AccountSetting");

            migrationBuilder.RenameTable(
                name: "AccountSetting",
                newName: "Setting");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Setting",
                table: "Setting",
                column: "Id");
        }
    }
}
