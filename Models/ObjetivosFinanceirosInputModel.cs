using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poupadev.api.Models
{
    public class ObjetivosFinanceirosInputModel
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public decimal? ValorObjetivo { get; set; }
 
    }
}