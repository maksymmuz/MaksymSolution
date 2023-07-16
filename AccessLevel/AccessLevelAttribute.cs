namespace AccessLevel
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	internal class AccessLevelAttribute : Attribute
	{
		public AccessLevelAttribute(EmployeeAccessLevel accessLevel)
		{
			AccessLevel = accessLevel;
		}

		public EmployeeAccessLevel AccessLevel { get; private set; }
	}
}
