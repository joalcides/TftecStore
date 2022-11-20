using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace TFTEC.Web.Ecommerce.Models
{
    [Table("ListaPreco")]
    public class ListaPreco
    {
        [Key]
        public int ListaPrecoId { get; set; }

        [Required]
        [Display(Name = "Nome da Lista de Preço")]
        public string NomeListaPreco { get; set; }

        [Required]
        [Display(Name = "Data Inicio Vigência")]
        public DateTime InicioVigencia { get; set; }

        [Required]
        [Display(Name = "Data Fim Vigência")]
        public DateTime FimVigencia { get; set; }
        
        [Display(Name = "Data de Criação")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Data de Modificação")]
        public DateTime ModifiedOn { get; set; }

        [Required]
        [Display(Name = "Status da Listagem")]
        public bool Status { get; set; }
    }
}
