using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevIO.App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var error = new ErrorViewModel {ErroCode = id};
            switch (id)
            {
                default: return StatusCode(404);
                case 500:
                    error.Titulo = "Ocorreu um Erro!";
                    error.Mensagem = "Ocorre um Erro! Tente novamente mais tarde ou contato o nosso suporte.";
                    return View(error);
                case 404:
                    error.Titulo = "Ops! Página não Encontrada.";
                    error.Mensagem = "A Página que está procurando não Existe!<br /> Em caso de dúvidas entre em contato com nosso suporte.";
                    return View(error);
                case 403:
                    error.Titulo = "Acesso Negado";
                    error.Mensagem = "Você não tem Permissão para fazer isto.";
                    return View(error);
            }
        }
    }
}
