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
    public class MantenedorRepuestoConfig : IEntityTypeConfiguration<MantenedorRepuesto>
    {
        public void Configure(EntityTypeBuilder<MantenedorRepuesto> Builder)
        {
            Builder.HasKey(g => g.Id);
            Builder.HasOne(un => un.MArea).WithMany(mr => mr.ListaMRepuestos).HasForeignKey(x => x.IdArea).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
