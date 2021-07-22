using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationTest.Data.Migrations
{
    public partial class institucion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstitucionId",
                table: "Curso",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Institucion",
                columns: table => new
                {
                    InstitucionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institucion", x => x.InstitucionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_InstitucionId",
                table: "Curso",
                column: "InstitucionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Institucion_InstitucionId",
                table: "Curso",
                column: "InstitucionId",
                principalTable: "Institucion",
                principalColumn: "InstitucionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Institucion_InstitucionId",
                table: "Curso");

            migrationBuilder.DropTable(
                name: "Institucion");

            migrationBuilder.DropIndex(
                name: "IX_Curso_InstitucionId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "InstitucionId",
                table: "Curso");
        }
    }
}
