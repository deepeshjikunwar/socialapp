
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) //takes connection string as parameters passed during instanstiation
        {
        }

        public DbSet<AppUser> Users {get; set;} //represent table in the DataBase
    }
}