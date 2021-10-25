using System.Web;
using System.Web.Mvc;

namespace Reserva.Equipamentos_XIMBINHA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
