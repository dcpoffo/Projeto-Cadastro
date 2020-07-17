using Microsoft.EntityFrameworkCore;
using projetoCadastro.Models;

namespace projetoCadastro.Contexto
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Curso> Curso { get; set; }
    }
}
