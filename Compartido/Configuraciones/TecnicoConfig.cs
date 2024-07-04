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
    public class TecnicoConfig : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> Builder)
        {
            Builder.HasKey(x => new { x.CodEmpresa, x.CodTecnico});
        }
    }
}
