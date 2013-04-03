namespace Thermostat.Repository.Model.Test.Unit
{
	using System.ComponentModel.DataAnnotations;
	using System.Diagnostics.CodeAnalysis;
	using System.Reflection;
	using Common.UnitTest;
	using Model.Types;
	using Shouldly;
	using Xunit;

	[Trait("CI", "Continuous Integration Repository")]
	[ExcludeFromCodeCoverage]
	public class ThermostatFixture
	{
		#region VARIABLES
			private readonly Thermostat _thermostat;
			private readonly CustomAttributes _customAttributes;
		#endregion

		#region CONSTRUCTORS
			public ThermostatFixture()
			{
				_thermostat = new Thermostat();
				_customAttributes = new CustomAttributes();
			}
		#endregion

		#region FACTS
			#region CONSTRUCTOR
				[Fact]
				public void Thermostat_Creation_ValidateIsEmpty()
				{
					_thermostat.ThermostatId.ShouldBe(0);
					_thermostat.SystemTypeId.ShouldBe(0);
					_thermostat.FanTypeId.ShouldBe(0);

					_thermostat.MaxSetting.ShouldBe(0);
					_thermostat.MinimumSetting.ShouldBe(0);
					_thermostat.CurrentTemperature.ShouldBe(0);
					_thermostat.HoldTemperature.ShouldBe(0);

					_thermostat.SystemType.ShouldBe(null);
					_thermostat.FanType.ShouldBe(null);
				}
			#endregion

			#region PROPERTIES
				[Fact]
				public void Thermostat_ThermostatId_Is_Int() { _thermostat.ThermostatId.ShouldBeTypeOf(typeof(int)); }
				[Fact]
				public void Thermostat_ThermostatId_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("ThermostatId");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}

				[Fact]
				public void Thermostat_SystemTypeId_Is_Int() { _thermostat.SystemTypeId.ShouldBeTypeOf(typeof(int)); }
				[Fact]
				public void Thermostat_SystemTypeId_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("SystemTypeId");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}

				[Fact]
				public void Thermostat_FanTypeId_Is_Int() { _thermostat.FanTypeId.ShouldBeTypeOf(typeof(int)); }
				[Fact]
				public void Thermostat_FanTypeId_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("FanTypeId");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}

				[Fact]
				public void Thermostat_MaxSetting_Is_Int() { _thermostat.MaxSetting.ShouldBeTypeOf(typeof(int)); }
				[Fact]
				public void Thermostat_MaxSetting_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("MaxSetting");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}

				[Fact]
				public void Thermostat_MinimumSetting_Is_Int() { _thermostat.MinimumSetting.ShouldBeTypeOf(typeof(int)); }
				[Fact]
				public void Thermostat_MinimumSetting_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("MinimumSetting");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}

				[Fact]
				public void Thermostat_CurrentTemperature_Is_Int() { _thermostat.CurrentTemperature.ShouldBeTypeOf(typeof(int)); }
				[Fact]
				public void Thermostat_CurrentTemperature_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("CurrentTemperature");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}

				[Fact]
				public void Thermostat_HoldTemperature_Is_Int() { _thermostat.HoldTemperature.ShouldBeTypeOf(typeof(int)); }
				[Fact]
				public void Thermostat_HoldTemperature_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("HoldTemperature");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}

				[Fact]
				public void Thermostat_SystemType_Is_SystemTypeObject()
				{
					_thermostat.SystemType = new SystemType();

					_thermostat.SystemType.ShouldBeTypeOf(typeof(SystemType));
				}

				[Fact]
				public void Thermostat_FanType_Is_FanTypeObject()
				{
					_thermostat.FanType = new FanType();

					_thermostat.FanType.ShouldBeTypeOf(typeof(FanType));
				}
			#endregion
		#endregion

		#region METHODS
			private PropertyInfo GetPropertyInfo(string propertyName) { return _thermostat.GetType().GetProperty(propertyName); }
		#endregion
	}
}
