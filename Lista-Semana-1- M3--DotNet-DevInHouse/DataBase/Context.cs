using Lista_Semana_1__M3__DotNet_DevInHouse.Models;
using Microsoft.EntityFrameworkCore;

namespace Lista_Semana_1__M3__DotNet_DevInHouse.DataBase
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<BandModel> Banda { get; set; }
    }
}
