using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TFTEC.Web.Ecommerce.Models
{
    [Table("ItensListaPreco")]
    public class ItensListaPreco
    {
        [Key]
        public int ItensListaPrecoId { get; set; }

        [Required(ErrorMessage = "Informe o preço do Produto")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Data de Modificação")]
        public DateTime ModifiedOn { get; set; }

    }
}
