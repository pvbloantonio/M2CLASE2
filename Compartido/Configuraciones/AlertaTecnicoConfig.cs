using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace Compartido.Configuraciones
{
    public class AlertaTecnicoConfig : IEntityTypeConfiguration<AlertaTecnico>
    {
        public void Configure(EntityTypeBuilder<AlertaTecnico> Builder)
        {
            Builder.HasKey(g => g.Id);
        }
    }
}
