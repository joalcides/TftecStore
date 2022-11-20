using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFTEC.Web.Ecommerce.Migrations
{
    public partial class PopulaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into produto(CategoriaId, NomeProduto, DescricaoCurta, DescricaoDetalhada, ImageUrl, ImageThumbnailUrl, EmEstoque, Tamanho, CreatedOn, ModifiedOn) " +
                "VALUES (2, 'Camiseta CertWeek', 'Camiseta do lançamento da Cert Week', 'Camiseta de poliester crida pelo nosso parceiro tamanhos do PP ao GG', 'http://tftec.com.br/images/criativos_2022/boneco-footer-right.webp', 'https://tftec.com.br/images/criativos_2022/boneco-footer-right.webp', 0, 3, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')");

            migrationBuilder.Sql("insert into produto(CategoriaId, NomeProduto, DescricaoCurta, DescricaoDetalhada, ImageUrl, ImageThumbnailUrl, EmEstoque, Tamanho, CreatedOn, ModifiedOn) " +
                "VALUES (3, 'Caneca CertWeek', 'Caneca do lançamento da Cert Week', 'Caneca customizada para café do evento cert week', 'http://tftec.com.br/images/criativos_2022/boneco-footer-right.webp', 'http://tftec.com.br/images/criativos_2022/boneco-footer-right.webp', 0, 0, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
