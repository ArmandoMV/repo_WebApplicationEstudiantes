using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationEstudiantes.Data;

namespace WebApplicationEstudiantes.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EstudiantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Método para obtener estudiantes
        /// </summary>
        /// <returns>Lista de estudiantes</returns>
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _context.Estudiantes.FromSqlRaw("EXEC spObtenerEstudiantes").ToListAsync();
            return Ok(students);
        }
    }
}
