namespace Thermostat.Repository.Model.Test.Unit.Types
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
	public class SystemTypeFixture
	{
		#region VARIABLES
			private readonly SystemType _systemType;
			private readonly CustomAttributes _customAttributes;
		#endregion

		#region CONSTRUCTORS
			public SystemTypeFixture()
			{
				_systemType = new SystemType();
				_customAttributes = new CustomAttributes();
			}
		#endregion

		#region FACTS
			#region CONSTRUCTOR
				[Fact]
				public void SystemType_Creation_ValidateIsEmpty()
				{
					_systemType.SystemTypeId.ShouldBe(0);

					_systemType.Name.ShouldBe(null);
					_systemType.DisplayName.ShouldBe(null);
				}
			#endregion

			#region PROPERTIES
				[Fact]
				public void SystemType_SystemTypeId_Is_Int() { _systemType.SystemTypeId.ShouldBeTypeOf(typeof(int)); }
				[Fact]
				public void SystemType_SystemTypeId_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("SystemTypeId");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}

				[Fact]
				public void SystemType_Name_Is_String()
				{
					_systemType.Name = string.Empty;

					_systemType.Name.ShouldBeTypeOf(typeof(string));
				}
				[Fact]
				public void SystemType_Name_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("Name");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}
				[Fact]
				public void SystemType_Name_MaxStringLength_Is_255()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("Name");
					StringLengthAttribute attribute = _customAttributes.CheckStringLengthAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
					attribute.MaximumLength.ShouldBe(255);
				}

				[Fact]
				public void SystemType_DisplayName_Is_String()
				{
					_systemType.Name = string.Empty;

					_systemType.Name.ShouldBeTypeOf(typeof(string));
				}
				[Fact]
				public void SystemType_DisplayName_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("DisplayName");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}
				[Fact]
				public void SystemType_DisplayName_MaxStringLength_Is_255()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("DisplayName");
					StringLengthAttribute attribute = _customAttributes.CheckStringLengthAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
					attribute.MaximumLength.ShouldBe(255);
				}
			#endregion
		#endregion

		#region METHODS
			private PropertyInfo GetPropertyInfo(string propertyName) { return _systemType.GetType().GetProperty(propertyName); }
		#endregion
	}
}
