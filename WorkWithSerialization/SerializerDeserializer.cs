using HelpLibrary;
using System.Xml.Serialization;

namespace WorkWithSerialization
{
	internal class SerializerDeserializer
	{
		public static void SerializePerson<T>(T person)
		{
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Person.xml");

			var serializer = new XmlSerializer(typeof(T));

			using (var writer = new StringWriter())
			{
				serializer.Serialize(writer, person);
				InputOutput.WriteToFile(filePath, writer.ToString());
			}
		}
	}
}
