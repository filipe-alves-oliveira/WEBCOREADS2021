using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREADS2021.Models.Dominio
{
        [Table("Pescador")]
        public class Pescador   
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do campo é inválido", MinimumLength = 5)]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo nome é obrigatório")]
        public string nome { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do campo é inválido", MinimumLength = 5)]
        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Campo cidade é obrigatório")]
        public string cidade { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do campo é inválido", MinimumLength = 5)]
        [DisplayName("Estado")]
        [Required(ErrorMessage = "Campo estado é obrigatório")]
        public string estado { get; set; }

        [StringLength(2, ErrorMessage = "Tamanho do campo é inválido")]
        [DisplayName("Idade")]
        [Required(ErrorMessage = "Campo idade é obrigatório")]
        public int idade { get; set; }
    }
}

