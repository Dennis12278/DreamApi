
using DreamApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamApi.Data
{
    public class DreamDbContext : DbContext
    {
        public DreamDbContext(DbContextOptions<DreamDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Anotacao> Anotacoes { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<GrupoUsuario> GruposUsuarios { get; set; }
        public DbSet<Compartilhamento> Compartilhamentos { get; set; }
        public DbSet<Notificacao> Notificacoes { get; set; }
        public DbSet<Calendario> Calendarios { get; set; }
    }
}