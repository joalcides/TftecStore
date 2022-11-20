using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFTEC.Web.Ecommerce.Migrations
{
    public partial class AtualizaEcommerce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Produto_ProdutoId",
                table: "PedidoDetalhes");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "PedidoDetalhes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Produto_ProdutoId",
                table: "PedidoDetalhes",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Produto_ProdutoId",
                table: "PedidoDetalhes");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "PedidoDetalhes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Produto_ProdutoId",
                table: "PedidoDetalhes",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "ProdutoId");
        }
    }
}
