using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class Usuario
    {

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Correo Requerido")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "Contraseña Requerida")]
        public string? Clave { get; set; }
        public string? Nombre { get; set; }
        public int IdRol { get; set; }

        public Rol? RolUsuario { get; set; }
    }
}
