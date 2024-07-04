using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class EnvioCorreo
    {
        public int Id { get; set; }
        public string? Para { get; set; }
        public string? Copia { get; set; }
        public string? Cco { get; set; }
        public string? Descripcion { get; set; }
    }
}
