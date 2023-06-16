namespace CreateReadFile
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string filePath = Path.Combine(folderPath, "SomeFile.txt");

			StreamWriter? writer = null;
			StreamReader? reader = null;

			try
			{
				writer = new StreamWriter(filePath);

				writer.WriteLine("Line 1");
				writer.WriteLine("Line 2 Line 2");
				writer.WriteLine("Line 3 Line 3 Line 3");

				Console.WriteLine("The text was successfully written to the file.");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred while writing to file: " + ex.Message);
			}
			finally
			{
				writer?.Close();
			}

			try
			{
				reader = new StreamReader(filePath);

				string? line;
				while ((line = reader.ReadLine()) != null)
				{
					Console.WriteLine(line);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred while read the file: " + ex.Message);
			}
			finally
			{
				reader?.Close();
			}
		}
	}
}
