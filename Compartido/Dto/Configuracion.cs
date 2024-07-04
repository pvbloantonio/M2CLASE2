using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class Configuracion
    {
        public int Id { get; set; }

        public bool Activo { get; set; }

        public int NumInt { get; set; }
        public double NumDouble { get; set; }
        public string? Descripcion { get; set; }
    }
}
