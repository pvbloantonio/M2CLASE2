using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compartido.Configuraciones
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> Builder)
        {
            Builder.HasKey(x => x.IdUsuario);
            Builder.HasOne(x => x.RolUsuario).WithMany(x => x.ListaUsuarios).HasForeignKey(x => x.IdRol);
        }
    }
}
