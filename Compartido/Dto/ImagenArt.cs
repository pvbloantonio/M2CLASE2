using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class ImagenArt
    {
        public int IdImagenArt { get; set; }
        public int IdVisita { get; set; }
        public int IdTipoImagenart { get; set; }
        public string? Imagenb64 { get; set; }

        public Visita? Visita { get; set; }

        public ImagenArtTipo? ImagenArtTipo { get; set; }
    }
}
