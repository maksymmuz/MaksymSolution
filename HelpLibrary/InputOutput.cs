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

		public static string[]? ReadLinesFromFile(string filePath)
		{
			try
			{
				return File.ReadAllLines(filePath);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred while reading lines of the file: " + ex.Message);
				return null;
			}
		}

		public static void CreateFile(string fileName, string? directory = null)
		{
			directory ??= AppDomain.CurrentDomain.BaseDirectory;
			string filePath = Path.Combine(directory, fileName);

			if (!File.Exists(filePath))
			{
				try
				{
					File.Create(filePath).Close();
					Console.WriteLine("File \"{0}\" was created in the \"{1}\" directory.", fileName, directory);
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error occurred while creating the file: " + ex.Message);
				}
			}
		}
	}
}