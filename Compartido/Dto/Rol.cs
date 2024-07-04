using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class Rol
    {
        public int Id { get; set; }
        public string? NombreRol { get; set; }
        public string? Descripcion { get; set; }
        public bool MenuDocumentos { get; set; }
        public bool MenuEstadoTecnicos { get; set; }
        public bool MenuConsultaRepuestos { get; set; }
        public bool MenuLogsvista { get; set; }
        public bool MenuInfovista { get; set; }

        public List<Usuario>? ListaUsuarios { get; set; }
    }
}
