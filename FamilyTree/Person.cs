namespace FamilyTree
{
	internal class Person
	{
		public Person(string name, ushort yearOfBirth)
		{
			Name = name;
			YearOfBirth = yearOfBirth;
			Children = new List<Person>();
		}

		public string Name { get; init; }

		public ushort YearOfBirth { get; init; }

		public List<Person> Children { get; set; }

		public Person Parent { get; set; }

		public void AddChildren(Person person)
		{
			Children.Add(person);
		}
	}
}
