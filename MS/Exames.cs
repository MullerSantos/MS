using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MS
{
    public class Exames
    {
        [Required]
        [MaxLength(5)]
        [Display(Name = "Código:")]
        [Key]
        public int IdExame { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento obrigatório", AllowEmptyStrings = false)]
        [MaxLength(20)]
        [Display(Name = "Descrição:")]
        public string Descricao { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Valor:")]
        public Decimal ValorExame { get; set; }
    }
}
