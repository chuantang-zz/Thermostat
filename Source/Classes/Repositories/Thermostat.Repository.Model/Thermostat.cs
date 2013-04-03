namespace Thermostat.Repository.Model
{
	using System.ComponentModel.DataAnnotations;
	using Types;

	public class Thermostat
	{
		#region PROPERTIES
			[Required]
			public int ThermostatId { get; set; }
			[Required]
			public int SystemTypeId { get; set; }
			[Required]
			public int FanTypeId { get; set; }

			[Required]
			public int MaxSetting { get; set; }
			[Required]
			public int MinimumSetting { get; set; }
			[Required]
			public int CurrentTemperature { get; set; }
			[Required]
			public int HoldTemperature { get; set; }

			public virtual SystemType SystemType { get; set; }
			public virtual FanType FanType { get; set; }
		#endregion
	}
}
