using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MS
{
    public class Cidades
    {
        [Required]
        [Display(Name = "Código:")]
        [MaxLength(6)]
        [Key]
        public int IdCidade { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Cidade:")]
        [MaxLength(30)]
        public string DescricaoCidade { get; set; }

        [MaxLength(2)]
        [Required(ErrorMessage = "Campo de Preenchimento Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "UF:")]
        public string UF { get; set; }
    }
}
