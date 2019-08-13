using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Setor
    {

        [Key]
        public int SetorID { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public bool Situacao { get; set; }

    }
}
