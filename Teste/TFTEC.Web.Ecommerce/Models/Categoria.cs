using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFTEC.Web.Ecommerce.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [Display(Name = "Nome da Categoria")]
        [MaxLength(200, ErrorMessage = "O nome da categoria deve conter no máximo {1} caracteres")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "A descrição da categoria deve ser informada")]
        [Display(Name = "Descrição detalhada do Produto")]
        [MaxLength(400, ErrorMessage = "Descrição detalhada do produto deve conter no máximo {1} caracteres")]
        public string Descricao { get; set; }
        
        [Display(Name = "Data de Criação")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Data de Modificação")]
        public DateTime ModifiedOn { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
