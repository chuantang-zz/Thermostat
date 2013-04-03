namespace Thermostat.Repository.Model.Types
{
	using System.ComponentModel.DataAnnotations;

	public class SystemType
	{
		#region PROPERTIES
			[Required]
			public int SystemTypeId { get; set; }

			[Required]
			[StringLength(255)]
			public string Name { get; set; }
			[Required]
			[StringLength(255)]
			public string DisplayName { get; set; }
		#endregion
	}
}
