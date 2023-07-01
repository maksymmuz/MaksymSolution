namespace FamilyTree
{
	internal class FamilyTreeCollection
	{
		public FamilyTreeCollection(Person root)
		{
			Root = root;

			LinkedList = new LinkedList<Person>();
			LinkedList.AddFirst(root);
		}

		LinkedList<Person> LinkedList { get; set; }

		public Person Root { get; set; }


		//public void PrintFamilyTree()
		//{
		//	PrintFamilyTree(Root, 0);
		//}

		//private void PrintFamilyTree(Person person, int level)
		//{
		//	string indentation = new string(' ', level * 4);
		//	Console.WriteLine($"{indentation}- {person}");

		//	foreach (Person child in person.Children)
		//	{
		//		PrintFamilyTree(child, level + 1);
		//	}
		//}
	}
}
