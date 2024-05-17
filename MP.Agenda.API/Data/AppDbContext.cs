using Microsoft.EntityFrameworkCore;
using MP.Agenda.API.Models;

namespace MP.Agenda.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // models here
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        

    }
}
