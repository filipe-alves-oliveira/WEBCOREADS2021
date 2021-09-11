using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREADS2021.Models.Dominio
{
        [Table("Peixe")]
        public class Peixe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do campo é inválido", MinimumLength = 5)]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        public string nome { get; set; }

        [DisplayName("Peso")]
        [DisplayFormat(DataFormatString ="0:F2", ApplyFormatInEditMode =true)]
        [Required(ErrorMessage = "Campo peso é obrigatório")]
        public float peso { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do campo é inválido", MinimumLength = 5)]
        [DisplayName("Isca")]
        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        public string isca { get; set; }


    }
}
