﻿using System;
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

        [StringLength(40)]
        [DisplayName("Descricao")]
        [Required(ErrorMessage ="Campo descricao é obrigatório")]
        public string descricao { get; set; }

        public string municipio { get; set; }
        public string outros { get; set; }

    }
}

