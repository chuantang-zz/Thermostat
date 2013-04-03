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
	public class FanTypeFixture
	{
		#region VARIABLES
			private readonly FanType _fanType;
			private readonly CustomAttributes _customAttributes;
		#endregion

		#region CONSTRUCTORS
			public FanTypeFixture()
			{
				_fanType = new FanType();
				_customAttributes = new CustomAttributes();
			}
		#endregion

		#region FACTS
			#region CONSTRUCTOR
				[Fact]
				public void FanType_Creation_ValidateIsEmpty()
				{
					_fanType.FanTypeId.ShouldBe(0);

					_fanType.Name.ShouldBe(null);
					_fanType.DisplayName.ShouldBe(null);
				}
			#endregion

			#region PROPERTIES
				[Fact]
				public void FanType_FanTypeId_Is_Int() { _fanType.FanTypeId.ShouldBeTypeOf(typeof(int)); }
				[Fact]
				public void FanType_FanTypeId_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("FanTypeId");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}

				[Fact]
				public void FanType_Name_Is_String()
				{
					_fanType.Name = string.Empty;

					_fanType.Name.ShouldBeTypeOf(typeof(string));
				}
				[Fact]
				public void FanType_Name_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("Name");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}
				[Fact]
				public void FanType_Name_MaxStringLength_Is_255()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("Name");
					StringLengthAttribute attribute = _customAttributes.CheckStringLengthAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
					attribute.MaximumLength.ShouldBe(255);
				}

				[Fact]
				public void FanType_DisplayName_Is_String()
				{
					_fanType.Name = string.Empty;

					_fanType.Name.ShouldBeTypeOf(typeof(string));
				}
				[Fact]
				public void FanType_DisplayName_Is_Required()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("DisplayName");
					RequiredAttribute attribute = _customAttributes.CheckRequiredAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
				}
				[Fact]
				public void FanType_DisplayName_MaxStringLength_Is_255()
				{
					PropertyInfo propertyInfo = GetPropertyInfo("DisplayName");
					StringLengthAttribute attribute = _customAttributes.CheckStringLengthAttribute(propertyInfo);

					attribute.ShouldNotBe(null);
					attribute.MaximumLength.ShouldBe(255);
				}
			#endregion
		#endregion

		#region METHODS
			private PropertyInfo GetPropertyInfo(string propertyName) { return _fanType.GetType().GetProperty(propertyName); }
		#endregion
	}
}
