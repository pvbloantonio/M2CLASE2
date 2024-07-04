using Compartido.Dto;
using Compartido.Utiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Configuraciones
{
    public class SolicitudConfig : IEntityTypeConfiguration<Solicitud>
    {
        public void Configure(EntityTypeBuilder<Solicitud> Builder)
        {

            Builder.HasKey(x => x.IdSolicitud);
            Builder.Property(x => x.FechaCreacion).ValueGeneratedOnAdd();

            ValueConverter<Solicitud.ZonaEnum, string> convertirEnum = new ValueConverter<Solicitud.ZonaEnum, string>
                                                            (valorEntrante => Enum.GetName(typeof(Solicitud.ZonaEnum), valorEntrante),
                                                            valorDesdeDB => EnumAyuda.GetEnumValue<Solicitud.ZonaEnum>(valorDesdeDB));

            Builder.Property(x => x.Zona).HasConversion(convertirEnum);


            Builder.HasIndex(x => new { x.CodEmpresa, x.CodSolicitud }).IsUnique();

            //Builder.HasOne(i => i.TecnicoUsuario)
            //       .WithMany(x => x.ListaSolicitudes)
            //       .HasForeignKey(x => new { x.CodEmpresa, x.CodSolicitud });
            //Builder.HasOne(x => x.ImagenOs).WithOne(x => x.Solicitud).HasForeignKey<Solicitud>(x => x.IdImagen);

        }
    }
}
