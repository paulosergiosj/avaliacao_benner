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

        public IActionResult Aquecer(int id,string alimento)
        {
            ViewData["id"] = id;    
            return View();
        }

       [HttpPost]
        public IActionResult Aquecer(string alimento, int id)
        {
            try
            {
                if (_aquecimentoPadraoService.ValidaAlimento(id, alimento))
                {
                    var obj = _aquecimentoPadraoService.RetornaAquecimentosByPos(id);
                    return View(nameof(Iniciar), obj);
                }
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Iniciar(AquecimentoPadrao obj) //abre a view mostrando o aquecimento
        {

            return View(obj);
        }

        public IActionResult BuscaAquecimento(string palavra)
        {
            try
            {
                var lista = _aquecimentoPadraoService.EncontraAlimento(palavra);
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
                    return RedirectToAction("Index", "Home");
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
            var obj = _aquecimentoPadraoService.RetornaAquecimentos();
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