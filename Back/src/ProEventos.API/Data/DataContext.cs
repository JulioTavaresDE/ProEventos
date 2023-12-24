using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class DaTaContext:DbContext
    {
        public DaTaContext(DbContextOptions<DaTaContext> options):base(options){}
        public DbSet<Evento>? Eventos { get; set; }
    }

}