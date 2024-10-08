using Microsoft.EntityFrameworkCore;
using WebApplicationEstudiantes.Models;

namespace WebApplicationEstudiantes.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        /// <summary>
        /// Establece la entidad estudiantes
        /// </summary>
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
