using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBCOREADS2021.Migrations
{
    public partial class AnotacoesClasses_Peixe_Tipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "idade",
                table: "Pescador",
                type: "int",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "idade",
                table: "Pescador",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 35);
        }
    }
}
