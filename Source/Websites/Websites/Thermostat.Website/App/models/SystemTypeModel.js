define
(
	['ko'],
	function (ko)
	{
		'use strict';

		var systemTypeModel = function (systemTypeId, name, displayName, isChecked)
		{
			this.systemTypeId = ko.observable(systemTypeId);
			this.name = ko.observable(name);
			this.displayName = ko.observable(displayName);
			this.isChecked = ko.observable(isChecked);
		};

		return systemTypeModel;
	}
);
