using System.Web;
using System.Web.Mvc;

namespace Azure_532_Lab_
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
