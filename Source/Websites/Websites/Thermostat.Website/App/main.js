(
	function (root)
	{
		requirejs.config
		(
			{
				paths: { 'text': 'durandal/amd/text' },
				urlArgs: "bust=" + (new Date()).getTime(),
				config:
				{
					'configuration': { serviceName: 'http://localhost:40774' }
				}
			}
		);

		define('jquery', function () { return root.jQuery; });
		define('ko', function () { return root.ko; });
		define('komapping', function () { return root.komapping; });
		define('amplify', function () { return root.amplify; });
		define('logger', function () { return root.logger; });

		define
		(
			['durandal/app', 'durandal/viewLocator', 'durandal/system', 'durandal/plugins/router'],
			function (app, viewLocator, system, router)
			{
				//>>excludeStart("build", true);
				system.debug(true);
				//>>excludeEnd("build");

				app.title = 'Thermostat';
				app.start().then
				(
					function ()
					{
						//Replace 'viewmodels' in the moduleId with 'views' to locate the view. Look for partial views in a 'views' folder in the root.
						viewLocator.useConvention();

						//configure routing
						router.useConvention();
						router.mapNav('welcome');

						app.adaptToDevice();

						//Show the app by setting the root view model for our application with a transition.
						app.setRoot('viewmodels/shell', 'entrance');
					}
				);
			}
		);
	}
)(window);
