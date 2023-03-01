using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identity框架1.Migrations
{
    /// <inheritdoc />
    public partial class Wx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WeiXinAccount",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeiXinAccount",
                table: "AspNetUsers");
        }
    }
}
