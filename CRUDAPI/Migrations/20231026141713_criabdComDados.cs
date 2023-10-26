using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRUDAPI.Migrations
{
    /// <inheritdoc />
    public partial class criabdComDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "PessoaId", "Idade", "Nome", "Profissao", "Sobrenome" },
                values: new object[,]
                {
                    { 1, 50, "Robson", "Programador", "O Programador" },
                    { 2, 48, "Rosângela", "Secretária", "A Secretária da Academia" },
                    { 3, 26, "Roberta", "Vendedora", "Pode Chamar de Beta" },
                    { 4, 9, "Nick", "Cachorro", "The Dog" },
                    { 5, 40, "Severino", "Faz Tudo", "O Faz Tudo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "PessoaId",
                keyValue: 5);
        }
    }
}
