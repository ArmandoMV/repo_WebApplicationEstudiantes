using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationEstudiantes.Models;

namespace WebApplicationEstudiantes.Controllers.Web
{
    public class EstudiantesController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public EstudiantesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Método de acción principal
        /// </summary>
        /// <returns>Devuelve la vista principal</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Método de acción de errores
        /// </summary>
        /// <returns>Devuelve una vista con información del error</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
