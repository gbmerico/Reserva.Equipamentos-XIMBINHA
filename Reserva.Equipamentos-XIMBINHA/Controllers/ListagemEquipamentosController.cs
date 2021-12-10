using Reserva.Equipamentos_XIMBINHA.data;
using Reserva.Equipamentos_XIMBINHA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reserva.Equipamentos_XIMBINHA.Controllers
{
    public class ListagemEquipamentosController : Controller
    {
        // GET: ListagemEquipamentos

        public ActionResult Index()
        {
            using (var context = new BancoDeDadosContext())
            {
                List<CadastroEquipamentoModel> lista = context.CadastroEquipamento.ToList();
                return View(lista);
            }
        }

        public ActionResult Novo()
        {
            return RedirectToAction("Index", "CadastroEquipamentos");
        }

        public ActionResult Deletar(int id)
        {
            using (var context = new BancoDeDadosContext())
            {
                CadastroEquipamentoModel equipamento = context.CadastroEquipamento.Find(id);
                if (equipamento != null)
                {
                    context.CadastroEquipamento.Remove(equipamento);
                    context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}