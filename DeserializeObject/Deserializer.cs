using HelpLibrary;
using System.Xml.Serialization;

namespace DeserializeObject
{
	internal class Deserializer<T>
	{
		public static T DeserializePerson()
		{
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Person.xml");
			string xmlString = InputOutput.ReadFromFile(filePath);

			var serializer = new XmlSerializer(typeof(T));
			using var reader = new StringReader(xmlString);

			return (T)serializer.Deserialize(reader);
		}
	}
}
