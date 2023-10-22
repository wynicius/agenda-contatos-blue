using Microsoft.EntityFrameworkCore;
using agenda_contatos.Models;

namespace agenda_contatos.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
        {
        }

        public DbSet<Contato> Contatos {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contato>().HasData(
                new Contato { Id = 1, Nome = "Joaquim Maria Machado de Assis", Email = "machadodass__s@gmail.com", Telefone = "81996542384"},
                new Contato { Id = 2, Nome = "José de Sousa Saramago", Email = "saramagoo22@outlook.com", Telefone = "83987785427"},
                new Contato { Id = 3, Nome = "João Cabral de Melo Neto", Email = "joaozindemelo@hotlink.com.br", Telefone = "81999578981"}
            );
        }
    }
}
