﻿using Reserva.Equipamentos_XIMBINHA.Models;
using System.Web.Mvc;

namespace Reserva.Equipamentos_XIMBINHA.Controllers
{
    public class CadastroEquipamentosController : Controller
    {
        // GET: CadastroEquipamentos

        // METODO
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(CadastroEquipamentoModel model)
        {

            return View("Index");
        }
    }
}