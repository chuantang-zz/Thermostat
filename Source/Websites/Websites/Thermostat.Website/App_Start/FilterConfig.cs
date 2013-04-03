namespace Thermostat.Website.App_Start
{
	using System.Web.Mvc;

	public class FilterConfig
	{
		#region METHODS
			public static void RegisterGlobalFilters(GlobalFilterCollection filters) { filters.Add(new HandleErrorAttribute()); }
		#endregion
	}
}
