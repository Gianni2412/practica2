using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica2.Models;
using practica2_1.Data;

namespace practica2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, AplicationDbContext context)
        {
            _logger = logger;
            _context = context;
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

        [HttpPost]
        public IActionResult Formulario(Formulario f)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f);
                _context.SaveChanges();
                return RedirectToAction("lista");
            }

            return View();
        }

        public IActionResult lista()
        {
            var formularios = _context.Formularios.ToList();
            return View(formularios);
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
