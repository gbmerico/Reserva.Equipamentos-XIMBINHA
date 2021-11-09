using Reserva.Equipamentos_XIMBINHA.Models;
using System.Web.Mvc;

namespace Reserva.Equipamentos_XIMBINHA.Controllers
{
    public class CadastroUsuariosController : Controller
    {
        // GET: CadastroUsuario

        // METODO
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(CadastroUsuarioModel model)
        {

            return View("Index"); 
        }
    }
}