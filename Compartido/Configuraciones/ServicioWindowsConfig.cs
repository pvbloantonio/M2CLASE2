using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Configuraciones
{
    public class ServicioWindowsConfig : IEntityTypeConfiguration<ServicioWindows>
    {
        public void Configure(EntityTypeBuilder<ServicioWindows> Builder)
        {
            Builder.HasKey(g => g.Id);
        }
    }
}
