using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBCOREADS2021.Migrations
{
    public partial class AnotacoesTodasClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pescadores_Premiacoes_Premiacaoid",
                table: "Pescadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Premiacoes_Pescadores_pescadorid",
                table: "Premiacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Premiacoes",
                table: "Premiacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pescadores",
                table: "Pescadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peixes",
                table: "Peixes");

            migrationBuilder.RenameTable(
                name: "Premiacoes",
                newName: "Premiacao");

            migrationBuilder.RenameTable(
                name: "Pescadores",
                newName: "Pescador");

            migrationBuilder.RenameTable(
                name: "Peixes",
                newName: "Peixe");

            migrationBuilder.RenameIndex(
                name: "IX_Premiacoes_pescadorid",
                table: "Premiacao",
                newName: "IX_Premiacao_pescadorid");

            migrationBuilder.RenameIndex(
                name: "IX_Pescadores_Premiacaoid",
                table: "Pescador",
                newName: "IX_Pescador_Premiacaoid");

            migrationBuilder.AlterColumn<string>(
                name: "outros",
                table: "Tipo",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Municipio",
                table: "Tipo",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "premio",
                table: "Premiacao",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Pescador",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "idade",
                table: "Pescador",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "Pescador",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Pescador",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Peixe",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "isca",
                table: "Peixe",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Premiacao",
                table: "Premiacao",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pescador",
                table: "Pescador",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peixe",
                table: "Peixe",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pescador_Premiacao_Premiacaoid",
                table: "Pescador",
                column: "Premiacaoid",
                principalTable: "Premiacao",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Premiacao_Pescador_pescadorid",
                table: "Premiacao",
                column: "pescadorid",
                principalTable: "Pescador",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pescador_Premiacao_Premiacaoid",
                table: "Pescador");

            migrationBuilder.DropForeignKey(
                name: "FK_Premiacao_Pescador_pescadorid",
                table: "Premiacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Premiacao",
                table: "Premiacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pescador",
                table: "Pescador");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peixe",
                table: "Peixe");

            migrationBuilder.RenameTable(
                name: "Premiacao",
                newName: "Premiacoes");

            migrationBuilder.RenameTable(
                name: "Pescador",
                newName: "Pescadores");

            migrationBuilder.RenameTable(
                name: "Peixe",
                newName: "Peixes");

            migrationBuilder.RenameIndex(
                name: "IX_Premiacao_pescadorid",
                table: "Premiacoes",
                newName: "IX_Premiacoes_pescadorid");

            migrationBuilder.RenameIndex(
                name: "IX_Pescador_Premiacaoid",
                table: "Pescadores",
                newName: "IX_Pescadores_Premiacaoid");

            migrationBuilder.AlterColumn<string>(
                name: "outros",
                table: "Tipo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "Municipio",
                table: "Tipo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "premio",
                table: "Premiacoes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Pescadores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "idade",
                table: "Pescadores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "Pescadores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Pescadores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Peixes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "isca",
                table: "Peixes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Premiacoes",
                table: "Premiacoes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pescadores",
                table: "Pescadores",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peixes",
                table: "Peixes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pescadores_Premiacoes_Premiacaoid",
                table: "Pescadores",
                column: "Premiacaoid",
                principalTable: "Premiacoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Premiacoes_Pescadores_pescadorid",
                table: "Premiacoes",
                column: "pescadorid",
                principalTable: "Pescadores",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
