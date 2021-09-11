using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBCOREADS2021.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peixes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    peso = table.Column<float>(type: "real", nullable: false),
                    isca = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peixes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    outros = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Premiacoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    colocacao = table.Column<int>(type: "int", nullable: false),
                    pescadorid = table.Column<int>(type: "int", nullable: true),
                    premio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premiacoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pescadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Premiacaoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pescadores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pescadores_Premiacoes_Premiacaoid",
                        column: x => x.Premiacaoid,
                        principalTable: "Premiacoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pescadores_Premiacaoid",
                table: "Pescadores",
                column: "Premiacaoid");

            migrationBuilder.CreateIndex(
                name: "IX_Premiacoes_pescadorid",
                table: "Premiacoes",
                column: "pescadorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Premiacoes_Pescadores_pescadorid",
                table: "Premiacoes",
                column: "pescadorid",
                principalTable: "Pescadores",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pescadores_Premiacoes_Premiacaoid",
                table: "Pescadores");

            migrationBuilder.DropTable(
                name: "Peixes");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Premiacoes");

            migrationBuilder.DropTable(
                name: "Pescadores");
        }
    }
}
