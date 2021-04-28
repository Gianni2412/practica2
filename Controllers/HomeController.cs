using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica2.Models;

namespace practica2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicios()
        {
            return View();
        }

        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult Productos()
        {
            return View();
        }

        public IActionResult Catalogo()
        {
            return View();
        }

        public IActionResult Servicio()
        {
            return View();
        }


        public IActionResult Resumen()
        {
            return View();
        }
        public IActionResult Pagar()
        {
            return View();
        }


        public IActionResult Usuario()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Iniciar()
        {
            return View();
        }


        public IActionResult Actualizar()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
