using CrudMYSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMYSQL.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options)
        { }

        public DbSet<Clientes> Clientes { get; set; }


    }
}
