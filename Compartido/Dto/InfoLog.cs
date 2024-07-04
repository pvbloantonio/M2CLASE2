using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class InfoLog
    {
        public int Id { get; set; }
        public DateTime Fecha { get; }
        public string? CodTecnico { get; set; }
        public string? Mensaje { get; set; }

        public enum TipoEnum { Info = 1, Warning, Error }
        public TipoEnum Tipo { get; set; }
    }
}
