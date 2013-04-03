namespace Thermostat.Website
{
	using System.Diagnostics.CodeAnalysis;
	using System.Reflection;
	using System.Web;
	using System.Web.Http;
	using System.Web.Mvc;
	using System.Web.Optimization;
	using System.Web.Routing;
	using App_Start;
	using Autofac;
	using Autofac.Integration.Mvc;
	using Autofac.Integration.WebApi;

	// Note: For instructions on enabling IIS6 or IIS7 classic mode, visit http://go.microsoft.com/?LinkId=9394801
	public class MvcApplication : HttpApplication
	{
		#region VARIABLES
		#endregion

		#region EVENTS
			#region APPLICATION
				protected void Application_Start()
				{
					AreaRegistration.RegisterAllAreas();

					WebApiConfig.Register(GlobalConfiguration.Configuration);
					FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
					RouteConfig.RegisterRoutes(RouteTable.Routes);
					DurandalBundleConfig.RegisterBundles(BundleTable.Bundles);

					InitializeDependencyInjectionContainer();
				}
			#endregion
		#endregion

		#region METHODS
			[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "This should survive the lifetime of the application.")]
			private static void InitializeDependencyInjectionContainer()
			{
				var builder = new ContainerBuilder();

				builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
				builder.RegisterModelBinderProvider();
				builder.RegisterControllers(Assembly.GetExecutingAssembly());
				builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

				Assembly serviceAssembly = Assembly.Load("Thermostat.Service");
				builder.RegisterAssemblyTypes(serviceAssembly).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerHttpRequest();

				Assembly repositoryAssembly = Assembly.Load("Thermostat.Repository");
				builder.RegisterAssemblyTypes(repositoryAssembly).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerHttpRequest();

				IContainer container = builder.Build();
				DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
				GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
			}
		#endregion
	}
}
