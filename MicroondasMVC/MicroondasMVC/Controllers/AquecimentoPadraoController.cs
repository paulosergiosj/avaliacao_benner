using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicroondasMVC.Models;
using MicroondasMVC.Services;
using MicroondasMVC.Services.Exceptions;

namespace MicroondasMVC.Controllers
{
    public class AquecimentoPadraoController : Controller
    {
        private static AquecimentoPadraoService _aquecimentoPadraoService = new AquecimentoPadraoService();

        public IActionResult Aquecer(int id)
        {
            return View(id);
        }
        [HttpPost]
        public IActionResult Aquecer(int id, string alimento)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (_aquecimentoPadraoService.ValidaAlimento(id, alimento))
                    {
                        var obj = _aquecimentoPadraoService.aquecimentos[id];
                        return View(nameof(Iniciar), obj);
                    }

                }
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            return View(nameof(Aquecer), id);
        }
        public IActionResult Iniciar(AquecimentoPadrao obj) //abre a view mostrando o aquecimento
        {

            return View(obj);
        }

        public IActionResult BuscaAquecimento(string alimento)
        {
            try
            {
                var lista = _aquecimentoPadraoService.EncontraAlimento(alimento);
                return View(lista);
            }
            catch (NaoEncontradoException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        public IActionResult Inserir()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Inserir(AquecimentoPadrao aquecimento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _aquecimentoPadraoService.InsereAquecimentoPadrao(aquecimento);
                    return RedirectToAction("Index","Aquecimento");
                }
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            return View();
        }
        public IActionResult ListaAquecimentoPadrao()
        {
            var obj = _aquecimentoPadraoService.aquecimentos;
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