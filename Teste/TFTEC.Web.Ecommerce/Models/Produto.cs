using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFTEC.Web.Ecommerce.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        [Display(Name ="Nome do Produto")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "A descrição do produto deve ser informada")]
        [Display(Name = "Descrição do Produto")]
        [MinLength(20, ErrorMessage = "Descrição do produto deve conter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição do produto deve conter no máximo {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do produto deve ser informada")]
        [Display(Name = "Descrição detalhada do Produto")]
        [MinLength(20, ErrorMessage = "Descrição detalhada do produto deve conter no mínimo {1} caracteres")]
        [MaxLength(400, ErrorMessage = "Descrição detalhada do produto deve conter no máximo {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Informe o preço do Produto")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImageThumbnailUrl { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public TamanhoProdutoModel Tamanho { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Data de Modificação")]
        public DateTime ModifiedOn { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; } 

    }
}
