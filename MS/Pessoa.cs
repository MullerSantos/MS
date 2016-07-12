using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MS
{
    public class Pessoa
    {
        [Display(Name = "Código:")]
        [Required]
        [MaxLength(10)]
        [Key]
        public int PessoaID { get; set; }

        [Required(ErrorMessage = "Campo de Preenchimento Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome/Razão:")]
        [MaxLength(30)]        
        public string Nome { get; set; }

        [MaxLength(30)]
        [Display(Name = "Fantasia:")]
        public string Fantasia { get; set; }

        // 0 fisica e 1 juridica
        [MaxLength(1)]
        public Boolean TipoPessoa { get; set; }

        [Display(Name = "Email:")]
        [MaxLength(20)]           
        public string Email { get; set; }

        [Display(Name = "Telefone:")]
        [DisplayFormat(DataFormatString = "{0:(00)-0000-0000}")]        
        public string Telefone { get; set; }

        [Display(Name = "Celular:")]
        [DisplayFormat(DataFormatString = "{0:(00)-0000-0000}")]
        public string Celular { get; set; }

        [Display(Name = "RG:")]
        [MaxLength(15)]
        public string  RG { get; set; }

        [Display(Name = "CPF:")]
        [MaxLength(11)]
        [DisplayFormat(DataFormatString = "{0:000.000.000-00}")]
        public string CPF { get; set; }

        [Display(Name = "CNPJ:")]
        [MaxLength(14)]
        public string CNPJ { get; set; }

        [Display(Name = "Endereço:")]
        [MaxLength(30)]
        public string Endereco { get; set; }

        [Display(Name = "Endereço de Cobrança:")]
        [MaxLength(30)]
        public string EndCob { get; set; }


        [Display(Name = "Número:")]
        [MaxLength(8)]
        public string Numero { get; set; }

        [Display(Name = "CEP:")]
        [MaxLength(8)]
        public string Cep { get; set; }

        [MaxLength(8)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/aaaa}")]
        [Display(Name = "Data de Nascimento:")]
        public DateTime? DataNas { get; set; }

        [MaxLength(8)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/aaaa}")]
        [Display(Name = "Data de Fundação:")]
        public DateTime? DataFund { get; set; }

        [MaxLength(8)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/aaaa}")]
        [Display(Name = "Data de Admissão:")]
        public DateTime? DataAdmisao { get; set; }

        [MaxLength(8)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/aaaa}")]
        [Display(Name = "Data de Demissão:")]
        public DateTime? DataDemissao { get; set; }

        [MaxLength(12)]
        [Display(Name = "Inscrição Estadual")]
        public int InscEstadual { get; set; }

        [MaxLength(15)]
        [Display(Name = "Inscrição Municipal")]
        public int InscMunicipal { get; set; }

        [MaxLength(7)]
        [DisplayFormat(DataFormatString = "{0:0000-0/00}")]
        [Display(Name = "CNAE")]
        public int Cnae { get; set; }

        [MaxLength(15)]
        [Display(Name = "CREA")]
        public int Crea { get; set; }

        [MaxLength(15)]
        [Display(Name = "CRM")]
        public int CRM { get; set; }

        //1 ativo 0 inativo
        [Display(Name = "Situação")]
        public Boolean ativo { get; set; }

        [Display(Name = "Observação")]
        [MaxLength(500)]
        public string ObservacaoPessoa { get; set; }


        [Display(Name = "Cidade")]
        ICollection <Cidades> Cidade { get; set; }

        [Display(Name = "Tipo de Cadastro")]
        ICollection <TipoCadastro> TpCadastro { get; set; }   

    }
}
