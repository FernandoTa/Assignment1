using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Nome{ get; set; }
        public string NomeEmpresa { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult QuemSomos()
        {
            ViewBag.Title = "Quem Somos";

            return View();
        }
        public ActionResult Posts()
        {
            ViewBag.Title = "Posts";

            return View();
        }
        public ActionResult Cadastrar()
        {
            ViewBag.Title = "Cadastro";

            return View();
        }
        
        public ActionResult ConfirmarCadastro(HomeController model, FormCollection formCollection)
        {
            if (model.Nome.Length < 5)
                ViewBag.Mensagem = "Por favor preencher o seu nome";
            else if (model.NomeEmpresa.Length < 2)
                ViewBag.Mensagem = "Por favor preencher o nome de sua empresa. Caso não possua escrever autônomo.";
            else if (model.Email.IndexOf('@') < 0 || model.Email2.IndexOf('@') < 0)
                ViewBag.Mensagem = "O email fornecido não é válido.";
            else if (model.Email != model.Email2)
                ViewBag.Mensagem = "Os emails fornecidos não conferem. Por favor verifique.";
            else
            {
                ViewBag.Title = "Cadastro Confirmado";

                return View();
            }
            return View("Cadastrar");
        }
    }
}
