using AccessLevel;
/**
 * Домашнє завдання 7
 * Завдання 5
 * Створіть атрибут користувача AccessLevelAttribute, який дозволяє визначити рівень доступу користувача до системи.
 * Сформуйте склад співробітників певної фірми як набору класів, наприклад, Manager, Programmer, Director.
 * За допомогою атрибута AccessLevelAttribute розподіліть рівні доступу персоналу та відобразіть на екрані
 * реакцію системи на спробу кожного співробітника отримати доступ до захищеної секції.
 */
Employee[] employees = new Employee[]
{
	new Manager("Johnnie Walker"),
	new Programmer("Jim Beam"),
	new Director("Jack Daniel's"),
};

foreach (var employee in employees)
{
	var accessLevelAttribute = Attribute.GetCustomAttribute(employee.GetType(), typeof(AccessLevelAttribute)) as AccessLevelAttribute;

	if (accessLevelAttribute != null)
	{
		var accessLevel = accessLevelAttribute.AccessLevel;
		employee.Work();

		switch (accessLevel)
		{
			case EmployeeAccessLevel.None:
				Console.WriteLine($"{employee.Name} has {accessLevel} access level,");
				break;

			case EmployeeAccessLevel.ReadOnly:
				Console.WriteLine($"{employee.Name} has {accessLevel} access level, " +
					$"therefore he/she can only read the code.");
				break;

			case EmployeeAccessLevel.ReadWrite:
				Console.WriteLine($"{employee.Name} has {accessLevel} access level, " +
					$"therefore he/she can read and write the code.");
				break;

			case EmployeeAccessLevel.Admin:
				Console.WriteLine($"{employee.Name} has {accessLevel} access level, " +
					$"therefore he/she can perform any operations on the code");
				break;

			default:
				Console.WriteLine("Default access level is None.");
				break;
		}
	}

	Console.WriteLine();
}