using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group5Try1.Migrations
{
    public partial class initial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PImage",
                table: "AccountSetting",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PImage",
                table: "AccountSetting");
        }
    }
}
