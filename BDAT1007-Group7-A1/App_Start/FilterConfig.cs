using System.Web;
using System.Web.Mvc;

namespace BDAT1007_Group7_A1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
