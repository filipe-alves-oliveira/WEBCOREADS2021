using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREADS2021.Models.Dominio
{
    public class Peixe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Nome")]
        public string nome { get; set; }

        [DisplayName("Peso")]
        public float peso { get; set; }

        [DisplayName("Isca")]
        public string isca { get; set; }


    }
}
