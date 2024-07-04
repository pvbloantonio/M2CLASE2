using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class MantenedorArea
    {
        public long Id { get; set; }
        public string? Nombre { get; set; }

        public List<MantenedorRepuesto>? ListaMRepuestos { get; set; }
    }
}
