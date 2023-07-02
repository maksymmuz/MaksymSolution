using HelpLibrary;
using System.Text.RegularExpressions;

namespace Decryptor
{
	internal class Cryptographer
	{
		public static void EncryptFile(string filePath)
		{
			try
			{
				string? fileContent = InputOutput.ReadFromFile(filePath);

				string modifiedContent = Regex.Replace(fileContent, @"([^\W\d_]|[\p{L}0-9_]){1,3}", "ГАВ!1111111");

				InputOutput.WriteToFile(filePath, modifiedContent);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred while crypt the file: " + ex.Message);
			}
		}
	}
}
