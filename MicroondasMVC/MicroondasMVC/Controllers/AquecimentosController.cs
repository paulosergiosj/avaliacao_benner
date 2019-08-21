using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicroondasMVC.Models;
using MicroondasMVC.Services;
using MicroondasMVC.Services.Exceptions;
using System.Diagnostics;

namespace MicroondasMVC.Controllers
{
    public class AquecimentosController : Controller
    {
        private readonly AquecimentoService _aquecimentoService;


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Aquecer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Aquecer(Aquecimento aquecimento)
        {
            if (ModelState.IsValid)
            {
                try
                {
                  var Obj =  _aquecimentoService.AqueceAlimento(aquecimento);
                    return RedirectToAction(nameof(Iniciar), new { obj = Obj });
                }
                catch(TempoException e)
                {
                    return RedirectToAction(nameof(Error), new { message = e.Message });
                }
            }
            return null;
        }

        public IActionResult Iniciar(Aquecimento obj) //abre a view mostrando o aquecimento
        {
            return View(obj);
        }
        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
            };
            return View(viewModel);
        }

    }
}