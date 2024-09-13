using System.Web;
using System.Web.Mvc;

namespace G03_Sistema_de_Condominios
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
