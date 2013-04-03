[assembly: WebActivator.PostApplicationStartMethod(typeof(Thermostat.Website.App_Start.DurandalConfig), "PreStart")]
namespace Thermostat.Website.App_Start
{
	using System.Web.Optimization;

	public static class DurandalConfig
	{
		#region METHODS
			public static void PreStart()
			{
				// Add your start logic here
				DurandalBundleConfig.RegisterBundles(BundleTable.Bundles);
			}
		#endregion
	}
}
