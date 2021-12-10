using Reserva.Equipamentos_XIMBINHA.data;
using Reserva.Equipamentos_XIMBINHA.Models;
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
            if (model.Id == 0) //new eqp
            {
                using (var context = new BancoDeDadosContext())
                {
                    context.CadastroEquipamento.Add(model);
                    context.SaveChanges();
                }

            }
            else
            {
                using (var context = new BancoDeDadosContext())
                {
                    CadastroEquipamentoModel equipamento = context.CadastroEquipamento.Find(model.Id);
                    if(equipamento != null)
                    {
                        equipamento.Nome = model.Nome;
                        context.SaveChanges();
                    }
                }
            }

            return RedirectToAction("Index", "ListagemEquipamentos");
        }

        public ActionResult Alterar(int id)
        {
            using (var context = new BancoDeDadosContext())
            {
                CadastroEquipamentoModel equipamento = context.CadastroEquipamento.Find(id);
                return View("Index", equipamento);
            }
        }
    }
}