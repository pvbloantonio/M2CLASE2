using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compartido.Configuraciones
{
    public class MantenedorAreaConfig : IEntityTypeConfiguration<MantenedorArea>
    {
        public void Configure(EntityTypeBuilder<MantenedorArea> Builder)
        {
            Builder.HasKey(g => g.Id);
        }
    }
}
