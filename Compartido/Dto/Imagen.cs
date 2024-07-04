using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class Imagen
    {
        public int IdImagen { get; set; }
        public string? ImagenBase { get; set; }  // string en base 64

        public int IdSolicitudfk { get; set; } 
        public Solicitud? Solicitud { get; set; }
    }
}
