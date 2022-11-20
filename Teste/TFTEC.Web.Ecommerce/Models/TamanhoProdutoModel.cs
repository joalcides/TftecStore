using System.ComponentModel.DataAnnotations;

namespace TFTEC.Web.Ecommerce.Models
{
    public enum TamanhoProdutoModel
    {
        [Display(Name = "Único")]
        U,
        [Display(Name = "P")]
        p,
        [Display(Name = "M")]
        m,
        [Display(Name = "G")]
        g,
        [Display(Name = "GG")]
        gg,
        [Display(Name = "XGG")]
        xgg
    }
}
