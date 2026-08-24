using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDALNT1.Migrations
{
    /// <inheritdoc />
    public partial class curso_aluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "curso",
                table: "aluno");

            migrationBuilder.AddColumn<int>(
                name: "cursoid",
                table: "aluno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_aluno_cursoid",
                table: "aluno",
                column: "cursoid");

            migrationBuilder.AddForeignKey(
                name: "FK_aluno_curso_cursoid",
                table: "aluno",
                column: "cursoid",
                principalTable: "curso",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_aluno_curso_cursoid",
                table: "aluno");

            migrationBuilder.DropIndex(
                name: "IX_aluno_cursoid",
                table: "aluno");

            migrationBuilder.DropColumn(
                name: "cursoid",
                table: "aluno");

            migrationBuilder.AddColumn<string>(
                name: "curso",
                table: "aluno",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
