namespace AccessLevel
{
	[AccessLevel(EmployeeAccessLevel.ReadWrite)]
	internal class Programmer : Employee
	{
		internal Programmer(string name)
		{
			Name = name;
		}

		public override void Work()
		{
			Console.WriteLine($"{Name} (Programmer) is writing code.");
		}
	}
}
