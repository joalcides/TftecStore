using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFTEC.Web.Ecommerce.Migrations
{
    public partial class PopulaCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into categoria(CategoriaNome, Descricao, CreatedOn, ModifiedOn) " +
                "VALUES ('Vestuário', 'Categoria voltada para o segmento de roupas da TFTEC', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')");

            migrationBuilder.Sql("insert into categoria(CategoriaNome, Descricao, CreatedOn, ModifiedOn) " +
                "VALUES ('Utensílios', 'Categoria voltada para ferramentas manuais usadas para a preparação de alimentos', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}
