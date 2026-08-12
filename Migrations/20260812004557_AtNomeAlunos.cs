using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDALNT1.Migrations
{
    /// <inheritdoc />
    public partial class AtNomeAlunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "aluno");

            migrationBuilder.AddPrimaryKey(
                name: "PK_aluno",
                table: "aluno",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_aluno",
                table: "aluno");

            migrationBuilder.RenameTable(
                name: "aluno",
                newName: "Alunos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "id");
        }
    }
}
