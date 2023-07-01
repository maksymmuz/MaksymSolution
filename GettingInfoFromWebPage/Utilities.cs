namespace GettingInfoFromWebPage
{
	internal class Utilities
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
	}
}
