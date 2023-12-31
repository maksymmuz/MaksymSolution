﻿namespace CreateReadFile
{
	/**
	 * Домашнє завдання 3
	 * Завдання 2
	 * Створіть файл, 
	 * запишіть у нього довільні дані та закрийте файл. 
	 * Потім знову відкрийте цей файл, прочитайте дані
	 * і виведіть їх на консоль.
	*/

	internal class Program
	{
		static void Main(string[] args)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string filePath = Path.Combine(folderPath, "ForExperiments", "SomeFile.txt");

			WriteToFile(filePath);
			ReadFromFile(filePath);
		}

		static void WriteToFile(string filePath)
		{
			StreamWriter? writer = null;

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
		}

		static void ReadFromFile(string filePath)
		{
			StreamReader? reader = null;

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
