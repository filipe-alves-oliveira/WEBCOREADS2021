using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREADS2021.Models.Dominio
{
        [Table("Premiacao")]
        public class Premiacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do campo é inválido", MinimumLength = 5)]
        [DisplayName("Colocacao")]
        [Required(ErrorMessage = "Campo colocacao é obrigatório")]
        public int colocacao { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do campo é inválido", MinimumLength = 5)]
        [DisplayName("Pescador")]
        [Required(ErrorMessage = "Campo pescador é obrigatório")]
        public Pescador pescador { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho do campo é inválido", MinimumLength = 5)]
        [DisplayName("Premio")]
        [Required(ErrorMessage = "Campo Premio é obrigatório")]
        public string premio { get; set; }

        public ICollection<Pescador> nome { get; set; }
    }
}
