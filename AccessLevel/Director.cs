namespace AccessLevel
{
	[AccessLevel(EmployeeAccessLevel.ReadOnly)]
	internal class Director : Employee
	{
		public Director(string name)
		{
			Name = name;
		}

		public override void Work()
		{
			Console.WriteLine($"{Name} (Director) is making important decisions.");
		}
	}
}
