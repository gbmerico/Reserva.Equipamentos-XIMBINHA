using Reserva.Equipamentos_XIMBINHA.Models;
using System.Web.Mvc;

namespace Reserva.Equipamentos_XIMBINHA.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        // metodo
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login( LoginModel model )
        {

            return Redirect("/ReservaEquipamentos");
        }
    }
}