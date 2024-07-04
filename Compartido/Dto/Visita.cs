using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class Visita
    {
        public int CodVisita { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltimoUpdate { get; set; }

        public int IdSolicitud { get; set; }

        public string? CodEmpresa { get; set; }
        public string? CodSolicitud { get; set; }
        public string? CodSolicitudHija { get; set; }

        public string? CodTecnico { get; set; }

        public int CodOsParcial { get; set; }

        public string? Reparacion { get; set; }

        public DateTime? FechaEncamino { get; set; }
        public double? EncaminoLongitud { get; set; }
        public double? EncaminoLatitud { get; set; }

        public DateTime? FechaTrabajando { get; set; }
        public double? TrabajandoLongitud { get; set; }
        public double? TrabajandoLatitud { get; set; }

        public DateTime? FechaTermino { get; set; }
        public double? TerminoLongitud { get; set; }
        public double? TerminoLatitud { get; set; }

        public DateTime? FechaPendiente { get; set; }
        public double? PendienteLongitud { get; set; }
        public double? PendienteLatitud { get; set; }

        public Solicitud? Solicitudes { get; set; }

        public List<ImagenArt>? ListaImagenesART { get; set; }
    }
}
