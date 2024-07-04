using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public string? CodEmpresa { get; set; }
        public string? CodSolicitud { get; set; }
        public string? CodSolicitudMadre { get; set; }

        public string? CodTecnico { get; set; }

        public string? Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaAsigCliente { get; set; }
        public double TiempoHSolucion { get; set; }
        public string? RutCliente { get; set; }
        public string? EmpresaCliente { get; set; }
        public int? CodOrdenServicio { get; set; }
        public string? CodUbicacion { get; set; }
        public string? Nor { get; set; }

        public enum ZonaEnum { Norte = 1, Central, Sur, Region_V }
        public ZonaEnum? Zona { get; set; }


        public string? EstadoOs { get; set; }
        public bool PendienteRepuesto { get; set; }
        public bool RepuestoEnviado { get; set; }
        public string? ObsBodeguero { get; set; }
        public int IdImagen { get; set; }

        public Tecnico? TecnicoUsuario { get; set; }

        public Imagen? ImagenOs { get; set; }

        public List<Visita>? ListaVisitas { get; set; }
    }
}
