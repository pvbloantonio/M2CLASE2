using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compartido.Configuraciones
{
    public class ImagenConfig : IEntityTypeConfiguration<Imagen>
    {
        public void Configure(EntityTypeBuilder<Imagen> Builder)
        {
            Builder.HasKey(g => g.IdImagen);
        }
    }
}
