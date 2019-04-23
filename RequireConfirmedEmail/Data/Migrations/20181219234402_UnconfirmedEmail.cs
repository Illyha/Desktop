using Microsoft.EntityFrameworkCore.Migrations;

namespace RequireConfirmedEmail.Data.Migrations
{
    public partial class UnconfirmedEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UnconfirmedEmail",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnconfirmedEmail",
                table: "AspNetUsers");
        }
    }
}
