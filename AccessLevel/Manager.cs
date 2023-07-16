namespace AccessLevel
{
	[AccessLevel(EmployeeAccessLevel.Admin)]
	internal class Manager : Employee
	{
		public Manager(string name)
		{
			Name = name;
		}

		public override void Work()
		{
			Console.WriteLine($"{Name} (Manager) is managing the team.");
		}
	}
}
