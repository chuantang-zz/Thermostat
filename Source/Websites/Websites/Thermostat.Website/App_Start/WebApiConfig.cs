namespace Thermostat.Website
{
	using System.Web.Http;

	public static class WebApiConfig
	{
		#region METHODS
			public static void Register(HttpConfiguration config)
			{
				config.Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}", defaults: new { id = RouteParameter.Optional });
			}
		#endregion
	}
}
