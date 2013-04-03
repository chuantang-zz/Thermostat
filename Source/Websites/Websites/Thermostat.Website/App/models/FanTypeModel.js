define
(
	['ko'],
	function (ko)
	{
		'use strict';

		var fanTypeModel = function (fanTypeId, name, displayName, isChecked)
		{
			this.fanTypeId = ko.observable(fanTypeId);
			this.name = ko.observable(name);
			this.displayName = ko.observable(displayName);
			this.isChecked = ko.observable(isChecked);
		};

		return fanTypeModel;
	}
);
