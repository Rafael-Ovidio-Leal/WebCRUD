using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCRUD.Migrations
{
    public partial class Updatestatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status Ativo",
                table: "Cliente",
                newName: "Status");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Cliente",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Cliente",
                newName: "Status Ativo");

            migrationBuilder.AlterColumn<string>(
                name: "Status Ativo",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
