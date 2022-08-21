using ASP_Autenticacao.Models;
using ASP_Autenticacao.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Autenticacao.Controllers
{
    public class AutenticacaoController : Controller
    {
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CadastroUsuarioViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            Usuario usuario = new Usuario
            {
                Nome = viewModel.UsuarioNome,
                Login = viewModel.Login,
                Senha = viewModel.Senha
            };

            usuario.InsertUsuario(usuario);

            return RedirectToAction("Index", "Home");
        }
    }
}