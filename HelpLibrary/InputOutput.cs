namespace HelpLibrary
{
	public class InputOutput
	{
		public static void WriteToFile(string filePath, string content, bool append = false)
		{
			try
			{
				using (var writer = new StreamWriter(filePath, append: append))
				{
					writer.WriteLine(content);
				}

				Console.WriteLine("The text was successfully written to the file.");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred while writing to file: " + ex.Message);
			}
		}

		public static string? ReadFromFile(string filePath)
		{
			try
			{
				return File.ReadAllText(filePath);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred while reading the file: " + ex.Message);
				return null;
			}
		}
	}
}