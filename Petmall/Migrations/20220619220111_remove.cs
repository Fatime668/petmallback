using Microsoft.EntityFrameworkCore.Migrations;

namespace Petmall.Migrations
{
    public partial class remove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgInfo",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Settings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgInfo",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
