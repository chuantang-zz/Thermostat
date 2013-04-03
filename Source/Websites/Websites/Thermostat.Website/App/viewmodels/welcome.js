define
(
	['jquery', 'ko', 'logger', 'models/SystemTypeModel', 'models/FanTypeModel'],
	function ($, ko, logger, systemTypeModel, fanTypeModel)
	{
		'use strict';

		var viewModel =
		{
			//#region VARIABLES
				systemTypeCollection: ko.observableArray([]),
				fanTypeCollection: ko.observableArray([]),
				maxSetting: ko.observable(120),
				minimumSetting: ko.observable(20),
				holdTemperature: ko.observable(80),
				currentTemperature: ko.observable(30),
				selectedSystemType: ko.observable('Cool'),
				selectedFanType: ko.observable('Auto'),
			//#endregion

			//#region METHODS
				load: load,
				setSystemType: setSystemType,
				setFanType: setFanType,
			//#endregion
		};

		viewModel.load();

		return viewModel;

		function load()
		{
			viewModel.systemTypeCollection.push(new systemTypeModel(1, 'Cool', 'Cool', true));
			viewModel.systemTypeCollection.push(new systemTypeModel(2, 'Heat', 'Heat', false));
			viewModel.systemTypeCollection.push(new systemTypeModel(3, 'Off', 'Off', false));

			viewModel.fanTypeCollection.push(new fanTypeModel(1, 'Auto', 'Auto', true));
			viewModel.fanTypeCollection.push(new fanTypeModel(2, 'Off', 'Off', false));

			setInterval
			(
				function ()
				{
					if (viewModel.selectedSystemType() == 'Off') return;

					if (viewModel.currentTemperature() == viewModel.holdTemperature()) return;
					else if (viewModel.currentTemperature() < viewModel.holdTemperature())
					{
						if (viewModel.currentTemperature() == viewModel.maxSetting()) return;

						if (viewModel.selectedSystemType() == 'Cool') return;

						var current = viewModel.currentTemperature() + 1;
						viewModel.currentTemperature(current);
					}
					else
					{
						if (viewModel.currentTemperature() == viewModel.minimumSetting()) return;

						if (viewModel.selectedSystemType() == 'Heat') return;

						current = viewModel.currentTemperature() - 1;
						viewModel.currentTemperature(current);
					}
				},
				1000
			);
		}
		function setSystemType(systemType)
		{
			viewModel.selectedSystemType(systemType.name());
			systemType.isChecked(true);
		}
		function setFanType(fanType)
		{
			viewModel.selectedFanType(fanType.name());
			fanType.isChecked(true);
		 }
	}
);
