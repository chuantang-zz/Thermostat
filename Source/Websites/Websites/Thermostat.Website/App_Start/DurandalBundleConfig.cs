namespace Thermostat.Website.App_Start
{
	using System;
	using System.Web.Optimization;

	public class DurandalBundleConfig
	{
		#region METHODS
			public static void RegisterBundles(BundleCollection bundles) 
			{
				bundles.IgnoreList.Clear();
				AddDefaultIgnorePatterns(bundles.IgnoreList);

				bundles.Add
				(
					new ScriptBundle("~/scripts/vendor")
						.Include("~/Content/Javascripts/JQuery/jquery-{version}.js")
						.Include("~/Content/Javascripts/Knockout/knockout-{version}.js")
						.Include("~/Content/Javascripts/Sammy/sammy-{version}.js")
						.Include("~/Content/Javascripts/BootStrap/bootstrap.js")
						.Include("~/Content/Javascripts/Toastr/toastr.js")
						.Include("~/Content/Javascripts/Amplify/amplify.js")
				);

				bundles.Add
				(
					new StyleBundle("~/Content/css")
						.Include("~/Content/Css/App/ie10mobile.css")
						.Include("~/Content/Css/BootStrap/bootstrap.min.css")
						.Include("~/Content/Css/BootStrap/bootstrap-responsive.min.css")
						.Include("~/Content/Css/FontAwesome/font-awesome.min.css")
						.Include("~/Content/Css/Durandal/durandal.css")
						.Include("~/Content/Css/Toastr/toastr.css")
						.Include("~/Content/Css/App/app.css")
				);
			}

			public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
			{
				if (ignoreList == null) throw new ArgumentNullException("ignoreList");

				ignoreList.Ignore("*.intellisense.js");
				ignoreList.Ignore("*-vsdoc.js");
				ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);

				//ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
				//ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
			}
		#endregion
	}
}
