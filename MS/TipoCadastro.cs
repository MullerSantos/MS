using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MS
{
    public class TipoCadastro
    {
        [Required]
        [MaxLength(2)]
        [Display(Name = "Código")]
        [Key]
        public int IDtpCadastro { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento obrigatório", AllowEmptyStrings = false)]
        [MaxLength(30)]
        [Display(Name = "Descrição")]
        public string DescTpCadastro { get; set; }       



    }
}
