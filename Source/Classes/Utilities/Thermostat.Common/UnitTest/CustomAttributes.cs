namespace Thermostat.Common.UnitTest
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Diagnostics.CodeAnalysis;
	using System.Linq;
	using System.Reflection;

	[ExcludeFromCodeCoverage]
	public class CustomAttributes
	{
		#region METHODS
			public RequiredAttribute CheckRequiredAttribute(PropertyInfo propertyInfo) { return propertyInfo.GetCustomAttributes(typeof(RequiredAttribute), false).Cast<RequiredAttribute>().FirstOrDefault(); }
			public StringLengthAttribute CheckStringLengthAttribute(PropertyInfo propertyInfo) { return propertyInfo.GetCustomAttributes(typeof(StringLengthAttribute), false).Cast<StringLengthAttribute>().FirstOrDefault(); }
			public KeyAttribute CheckKeyAttribute(PropertyInfo propertyInfo) { return propertyInfo.GetCustomAttributes(typeof(KeyAttribute), false).Cast<KeyAttribute>().FirstOrDefault(); }
			public ColumnAttribute CheckColumnAttribute(PropertyInfo propertyInfo) { return propertyInfo.GetCustomAttributes(typeof(ColumnAttribute), false).Cast<ColumnAttribute>().FirstOrDefault(); }
		#endregion
	}
}
