namespace Thermostat.Service.Model
{
	public class ThermostatServiceModel
	{
		#region PROPERTIES
			public int ThermostatId { get; set; }
			public int SystemTypeId { get; set; }
			public int FanTypeId { get; set; }

			public int MaxSetting { get; set; }
			public int MinimumSetting { get; set; }
			public int CurrentTemperature { get; set; }
			public int HoldTemperature { get; set; }
		#endregion
	}
}
