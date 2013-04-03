namespace Thermostat.Service.Model.Test.Unit
{
	using System;
	using System.Diagnostics.CodeAnalysis;
	using Shouldly;
	using Xunit;

	[Trait("CI", "Continuous Integration Service")]
	[ExcludeFromCodeCoverage]
	public class ThermostatServiceModelFixture
	{
		#region VARIABLES
			private readonly ThermostatServiceModel _thermostatServiceModel;
		#endregion

		#region CONSTRUCTORS
			public ThermostatServiceModelFixture() { _thermostatServiceModel = new ThermostatServiceModel(); }
		#endregion

		#region FACTS
			#region CONSTRUCTOR
				[Fact]
				public void ThermostatServiceModel_Creation_ValidateIsEmpty()
				{
					_thermostatServiceModel.ThermostatId.ShouldBe(0);
					_thermostatServiceModel.SystemTypeId.ShouldBe(0);
					_thermostatServiceModel.FanTypeId.ShouldBe(0);

					_thermostatServiceModel.MaxSetting.ShouldBe(0);
					_thermostatServiceModel.MinimumSetting.ShouldBe(0);
					_thermostatServiceModel.CurrentTemperature.ShouldBe(0);
					_thermostatServiceModel.HoldTemperature.ShouldBe(0);
				}
			#endregion

			#region PROPERTIES
				[Fact]
				public void ThermostatServiceModel_ThermostatId_Is_Int() { _thermostatServiceModel.ThermostatId.ShouldBeTypeOf(typeof(int)); }

				[Fact]
				public void ThermostatServiceModel_SystemTypeId_Is_Int() { _thermostatServiceModel.SystemTypeId.ShouldBeTypeOf(typeof(int)); }

				[Fact]
				public void ThermostatServiceModel_FanTypeId_Is_Int() { _thermostatServiceModel.FanTypeId.ShouldBeTypeOf(typeof(int)); }

				[Fact]
				public void ThermostatServiceModel_MaxSetting_Is_Int() { _thermostatServiceModel.MaxSetting.ShouldBeTypeOf(typeof(int)); }

				[Fact]
				public void ThermostatServiceModel_MinimumSetting_Is_Int() { _thermostatServiceModel.MinimumSetting.ShouldBeTypeOf(typeof(int)); }

				[Fact]
				public void ThermostatServiceModel_CurrentTemperature_Is_Int() { _thermostatServiceModel.CurrentTemperature.ShouldBeTypeOf(typeof(int)); }

				[Fact]
				public void ThermostatServiceModel_HoldTemperature_Is_Int() { _thermostatServiceModel.HoldTemperature.ShouldBeTypeOf(typeof(int)); }
			#endregion
		#endregion

		#region METHODS
		#endregion
	}
}
