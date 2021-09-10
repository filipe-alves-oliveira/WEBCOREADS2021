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

        [StringLength(35, ErrorMessage ="Tamanho do campo inválido", MinimumLength =5)]
        [DisplayName("Descricao")]
        [Required(ErrorMessage ="Campo descricao é obrigatório")]
        public string descricao { get; set; }

        [StringLength(25, ErrorMessage ="Tamanho do campo municipio inválido")]
        [Required(ErrorMessage ="campo Municipio é obrigatório")]
        [DisplayName("Municipio")]
        public string municipio { get; set; }

        [StringLength(25, ErrorMessage = "Tamanho do campo outros inválido")]
        [Required(ErrorMessage = "campo Outros é obrigatório")]
        [DisplayName("Outros")]
        public string outros { get; set; }

    }
}

