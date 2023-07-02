using System.Xml;

/**
 * Домашнє завдання 5
 * Завдання 2
 * Створіть програму, яка виводить на екран всю інформацію про вказаний .xml файл.
 */

XmlReaderSettings settings = new XmlReaderSettings();
settings.DtdProcessing = DtdProcessing.Ignore; // Disable XML compliance checking

using (XmlReader reader = XmlReader.Create(@"TelephoneBook.xml", settings))
{
	while (reader.Read())
	{
		switch (reader.NodeType)
		{
			case XmlNodeType.Element:
				Console.WriteLine($"Value: {reader.Name}");

				if (reader.HasAttributes)
				{
					while (reader.MoveToNextAttribute())
					{
						Console.WriteLine($"Attribute: {reader.Name} = {reader.Value}");
					}

					reader.MoveToElement();
				}
				break;

			case XmlNodeType.Text:
				Console.WriteLine($"Value: {reader.Value}");
				break;

			case XmlNodeType.EndElement:
				Console.WriteLine($"End of element: {reader.Name}");
				break;
		}
	}
}