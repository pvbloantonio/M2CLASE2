using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compartido.Configuraciones
{
    public class RolConfig : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> Builder)
        {
            Builder.HasKey(g => g.Id);
            Builder.HasIndex(g => g.Id).IsUnique();
        }
    }
}
