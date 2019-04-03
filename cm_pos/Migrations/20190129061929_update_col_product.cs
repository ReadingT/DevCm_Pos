using Microsoft.EntityFrameworkCore.Migrations;

namespace cm_pos.Migrations
{
    public partial class update_col_product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nattapong",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nattapong",
                table: "Products");
        }
    }
}
