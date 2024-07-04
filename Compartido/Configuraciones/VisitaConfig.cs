using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;
using System.Reflection.Emit;

namespace Compartido.Configuraciones
{
    public class VisitaConfig : IEntityTypeConfiguration<Visita>
    {
        public void Configure(EntityTypeBuilder<Visita> Builder)
        {
            Builder.HasKey(x => x.CodVisita);
            Builder.Property(x => x.FechaCreacion).ValueGeneratedOnAdd();
            Builder.Property(x => x.FechaUltimoUpdate).ValueGeneratedOnAddOrUpdate();

            Builder.HasOne(x => x.Solicitudes).WithMany(x => x.ListaVisitas).HasForeignKey(x => x.IdSolicitud);

            Builder.HasIndex(x => new { x.CodEmpresa, x.CodSolicitud });

        }

    }
}
