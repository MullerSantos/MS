using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MS
{
    public class ContasPagar
    {
        [Key]
        [Display(Name = "Código")]
        [Required]
        [MaxLength(10)]
        public int IdContasPagar { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Valor")]
        [MaxLength(18)]
        public Decimal ValorOriginal { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento Obrigatório", AllowEmptyStrings = false)]
        [MaxLength(8)]
        [Display(Name = "Vencimento:")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/aaaa}")]
        public DateTime Vencimento { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Competência")]
        [DisplayFormat(DataFormatString = "{0:mm/aaaa}")]
        [MaxLength(6)]
        public DateTime Competencia { get; set; }

        []
        ICollection <Pessoa> PessoaIDNome { get; set; }

    }
}
