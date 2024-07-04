using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class MantenedorRepuesto
    {
        public long Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public long IdArea { get; set; }

        public MantenedorArea? MArea { get; set; }
    }
}
