using Microsoft.EntityFrameworkCore;

namespace CrudMYSQL.Data
{
    public class DBContext
    {
        public DBContext(DbContextOptions<Contexto> options)
        {
        }
    }
}