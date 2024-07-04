using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class AlertaTecnico
    {
        public int Id { get; set; }
        public string? CodEmpresa { get; set; }
        public string? CodSolicitud { get; set; }
        public string? CodTecnico { get; set; }
        public bool Visto { get; set; }
    }
}
