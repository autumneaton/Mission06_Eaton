using Microsoft.EntityFrameworkCore;

namespace Mission06_Eaton.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) 
        { 
        }

        public DbSet<Application>Movies { get; set; }
    }
}
