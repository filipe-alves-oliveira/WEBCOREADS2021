using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREADS2021.Models.Dominio
{
        [Table("Tipo")]
        public class Tipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage ="Tamanho do campo é inválido", MinimumLength =5)]
        [DisplayName("Descricao")]
        [Required(ErrorMessage ="Campo descrição é obrigatório")]
        public string descricao { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do campo é inválido", MinimumLength = 5)]
        [DisplayName("Municipio")]
        [Required(ErrorMessage = "Campo municipio é obrigatório")]
        public string Municipio { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do campo é inválido", MinimumLength = 5)]
        [DisplayName("Outros")]
        [Required(ErrorMessage = "Campo Outros é obrigatório")]
        public string outros { get; set; }

    }
}

