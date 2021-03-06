﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MS
{
    public class Riscos
    {
        [Required]
        [MaxLength(4)]
        [Display(Name ="Código")]
        [Key]
        public int IDRisco { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento obrigatório", AllowEmptyStrings = false)]
        [MaxLength(30)]
        [Display(Name ="Risco")]
        public string risco { get; set; }
    }
}
