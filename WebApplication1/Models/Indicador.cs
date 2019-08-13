using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Indicador
    {
        [Key]
        public int IndicadorId { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public bool Situacao { get; set; }

        //[ForeignKey("SetorID")]
        [Required]

        public int SetorID { get; set; }

    }
}
