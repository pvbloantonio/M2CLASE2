﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dto
{
    public class ImagenArtTipo
    {
        public int IdImagenArtTipo { get; set; }
        public string? Tipo { get; set; }
        public string? Descripcion { get; set; }

        public List<ImagenArt>? ListaImagenArt { get; set; }
    }
}
