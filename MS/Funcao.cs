using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MS
{
   public class Funcao
    {
        [Required]
        [MaxLength(4)]
        [Display(Name ="Código")]
        [Key]
        public int IDfuncao { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento obrigatório", AllowEmptyStrings = false)]
        [MaxLength(30)]
        [Display(Name ="Função")]
        [Key]
        public string funcao { get; set; }
    }
}
