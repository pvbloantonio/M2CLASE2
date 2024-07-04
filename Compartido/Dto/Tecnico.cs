using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class Tecnico
    {
        public string? CodEmpresa { get; set; }
        public string? CodTecnico { get; set; }

        public string? Nombre { get; set; }
        public string? Usuario { get; set; }
        public string? Clave { get; set; }
        public int CantidadAsignados { get; set; }
        public string? FireBaseToken { get; set; }

        public List<Solicitud>? ListaSolicitudes { get; set; }
    }
}
