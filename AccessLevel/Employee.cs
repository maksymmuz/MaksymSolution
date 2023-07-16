namespace AccessLevel
{
	internal abstract class Employee
	{
		public string? Name { get; protected set; }

		public abstract void Work();
	}
}
