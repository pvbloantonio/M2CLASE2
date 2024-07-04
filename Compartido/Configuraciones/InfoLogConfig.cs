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
    public class InfoLogConfig : IEntityTypeConfiguration<InfoLog>
    {
        public void Configure(EntityTypeBuilder<InfoLog> Builder)
        {
            Builder.HasKey(g => g.Id);
            Builder.Property(x => x.Fecha).ValueGeneratedOnAddOrUpdate();
        }
    }
}
