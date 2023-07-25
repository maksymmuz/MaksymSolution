using System.Xml.Serialization;

namespace WorkWithSerialization
{
	[Serializable]
	public class Person
	{
		// Uncomment to use as XmlAttribute
		// [XmlAttribute]
		public string Name { get; set; }
		
		// [XmlAttribute]
		public int Age { get; set; }

		// [XmlAttribute]
		public string Position { get; set; }

		// An empty constructor is required for serialization/deserialization
		public Person() { }

		public Person(string name, int age, string position)
		{
			Name = name;
			Age = age;
			Position = position;
		}
	}
}
