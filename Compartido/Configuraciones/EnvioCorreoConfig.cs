using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compartido.Configuraciones
{
    public class EnvioCorreoConfig : IEntityTypeConfiguration<EnvioCorreo>
    {
        public void Configure(EntityTypeBuilder<EnvioCorreo> Builder)
        {
            Builder.HasKey(g => g.Id);
        }
    }
}
