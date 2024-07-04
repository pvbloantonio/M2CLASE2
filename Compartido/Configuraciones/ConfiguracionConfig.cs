using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compartido.Configuraciones
{
    public class ConfiguracionConfig : IEntityTypeConfiguration<Configuracion>
    {
        public void Configure(EntityTypeBuilder<Configuracion> Builder)
        {
            Builder.HasKey(g => g.Id);
        }
    }
}
