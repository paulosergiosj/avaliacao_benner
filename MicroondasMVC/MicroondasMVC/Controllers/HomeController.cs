using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicroondasMVC.Models;
using MicroondasMVC.Services;

namespace MicroondasMVC.Controllers
{
    public class HomeController : Controller
    {
        private static AquecimentoPadraoService _aquecimentoPadraoService = new AquecimentoPadraoService();
        public IActionResult Index(string alimento)
        {
            var aquecimentos = _aquecimentoPadraoService.RetornaAquecimentos();
            if (!string.IsNullOrEmpty(alimento))
            {
                return RedirectToAction("BuscaAquecimento", "AquecimentoPadrao", new { palavra = alimento });
            }
            return View(aquecimentos);
        }
 
    }
}
