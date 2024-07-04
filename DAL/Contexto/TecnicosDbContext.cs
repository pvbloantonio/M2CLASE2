using Compartido.Configuraciones;
using Compartido.Dto;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Metadata;

namespace DAL.Contexto
{
    public class TecnicosDbContext: DbContext
    {

        public TecnicosDbContext()
        {
            
        }

        public TecnicosDbContext(DbContextOptions<TecnicosDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Visita>()
                    .HasAlternateKey(x => new { x.CodEmpresa, x.CodSolicitud })
                    .HasName("ICodEmpresaCodSolicitud");

            modelBuilder.Entity<Solicitud>()
                    .HasOne(s => s.ImagenOs)
                    .WithOne(i => i.Solicitud)
                    .HasForeignKey<Imagen>(i => i.IdSolicitudfk);

            modelBuilder.ApplyConfiguration(new AlertaTecnicoConfig());
            modelBuilder.ApplyConfiguration(new ImagenArtConfig());
            modelBuilder.ApplyConfiguration(new ImagenArtTipoConfig());
            modelBuilder.ApplyConfiguration(new ImagenConfig());
            modelBuilder.ApplyConfiguration(new RolConfig());
            modelBuilder.ApplyConfiguration(new SolicitudConfig());
            modelBuilder.ApplyConfiguration(new TecnicoConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new VisitaConfig());
            modelBuilder.ApplyConfiguration(new ConfiguracionConfig());
            modelBuilder.ApplyConfiguration(new EnvioCorreoConfig());
            modelBuilder.ApplyConfiguration(new InfoLogConfig());
            modelBuilder.ApplyConfiguration(new MantenedorAreaConfig());
            modelBuilder.ApplyConfiguration(new MantenedorRepuestoConfig());
            modelBuilder.ApplyConfiguration(new ServicioWindowsConfig());
            






            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<AlertaTecnico> AlertaTecnicos => Set<AlertaTecnico>();
        public DbSet<Imagen> Imagenes => Set<Imagen>();
        public DbSet<ImagenArt> ImagenArtes => Set<ImagenArt>();
        public DbSet<ImagenArtTipo> ImagenArtTipos => Set<ImagenArtTipo>();
        public DbSet<Rol> Roles => Set<Rol>();
        public DbSet<Solicitud> Solicitudes => Set<Solicitud>();
        public DbSet<Tecnico> Tecnicos => Set<Tecnico>();
        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Visita> Visitas => Set<Visita>();


    }
}
