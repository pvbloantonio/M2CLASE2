using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compartido.Configuraciones
{
    public class ImagenArtConfig : IEntityTypeConfiguration<ImagenArt>
    {
        public void Configure(EntityTypeBuilder<ImagenArt> Builder)
        {
            Builder.HasKey(g => g.IdImagenArt);

            Builder.HasOne(x => x.Visita).WithMany(x => x.ListaImagenesART).HasForeignKey(x => x.IdVisita);
            Builder.HasOne(x => x.ImagenArtTipo).WithMany(x => x.ListaImagenArt).HasForeignKey(x => x.IdTipoImagenart);
        }
    }
}
