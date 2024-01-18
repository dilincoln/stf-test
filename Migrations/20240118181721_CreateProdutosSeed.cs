using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace stf_test.Migrations
{
    public partial class CreateProdutosSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "NomeProduto", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2911), new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2910), "Produto 1", 10m },
                    { 2, new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2914), new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2914), "Produto 2", 20m },
                    { 3, new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2916), new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2916), "Produto 3", 30m },
                    { 4, new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2918), new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2917), "Produto 4", 40m },
                    { 5, new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2919), new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2919), "Produto 5", 50m },
                    { 6, new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2922), new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2921), "Produto 6", 60m },
                    { 7, new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2923), new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2923), "Produto 7", 70m },
                    { 8, new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2924), new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2924), "Produto 8", 80m },
                    { 9, new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2926), new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2925), "Produto 9", 90m },
                    { 10, new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2928), new DateTime(2024, 1, 18, 18, 17, 20, 882, DateTimeKind.Utc).AddTicks(2928), "Produto 10", 100m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
