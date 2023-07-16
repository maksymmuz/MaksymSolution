using HelpLibrary;
using System.Text.RegularExpressions;

namespace Encryption
{
	internal class Cryptographer
	{
		public static void EncryptFile(string filePath)
		{
			try
			{
				string? fileContent = InputOutput.ReadFromFile(filePath);

				string modifiedContent = Regex.Replace(fileContent, @"([^\W\d_]|[\p{L}0-9_]){1,3}", "ГАВ!");

				InputOutput.WriteToFile(filePath, modifiedContent);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred while crypt the file: " + ex.Message);
			}
		}
	}
}
