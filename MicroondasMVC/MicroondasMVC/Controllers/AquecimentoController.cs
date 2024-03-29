﻿using System;
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
    public class AquecimentoController : Controller
    {
        private static AquecimentoService _aquecimentoService = new AquecimentoService();

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
                    var obj = _aquecimentoService.AqueceAlimento(aquecimento);
                    return View(nameof(Iniciar), obj);
                }
                catch (TempoException e)
                {
                    return RedirectToAction(nameof(Error), new { message = e.Message });
                }
                catch (PotenciaException e)
                {
                    return RedirectToAction(nameof(Error), new { message = e.Message });
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult InicioRapido()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InicioRapido(Aquecimento aquecimento)
        {
            try
            {
                var obj = _aquecimentoService.InicioRapido(aquecimento);
                return View(nameof(Iniciar), obj);
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
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