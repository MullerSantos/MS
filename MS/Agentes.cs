using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MS
{
    public class Agentes
    {
        [Required]
        [MaxLength(4)]
        [Display(Name ="Código")]
        [Key]
        public int IDagente { get; set; }

        [Display(Name ="Risco")]
        ICollection<Riscos> risco { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento Obrigatório", AllowEmptyStrings = false)]
        [MaxLength(30)]
        [Display(Name ="Agente")]
        public string agente { get; set; }

    }
}
