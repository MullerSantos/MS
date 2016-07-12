using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MS
{
    public class Setores
    {
        [Required]
        [MaxLength(4)]
        [Display(Name = "Código")]
        [Key]
        public int IDsetor { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento obrigatório", AllowEmptyStrings = false)]
        [MaxLength(30)]
        [Display(Name = "Setor")]
        public string setor { get; set; }

    }
}
