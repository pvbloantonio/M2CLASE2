using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compartido.Configuraciones
{
    public class ImagenArtTipoConfig : IEntityTypeConfiguration<ImagenArtTipo>
    {
        public void Configure(EntityTypeBuilder<ImagenArtTipo> Builder)
        {
            Builder.HasKey(g => g.IdImagenArtTipo);
        }
    }
}
