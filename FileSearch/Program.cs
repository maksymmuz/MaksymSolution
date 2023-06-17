using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace FileSearch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the drive (example C:\\):");
			string? searchPath = Console.ReadLine();

			Console.WriteLine("Enter file name to search:");
			string? fileName = Console.ReadLine();

			try
			{
				string? filePath = SearchFile(searchPath, fileName);

				if (!string.IsNullOrEmpty(filePath))
				{
					Console.WriteLine("File found: " + filePath);
					ViewFileContents(filePath);
					ArchiveFile(fileName);
				}
				else
				{
					Console.WriteLine("File not found.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred: " + ex.Message);
			}
		}

		static string? SearchFile(string path, string fileName)
		{
			var directoriesToSearch = new Queue<string>();
			directoriesToSearch.Enqueue(path);

			while (directoriesToSearch.Count > 0)
			{
				string currentDirectory = directoriesToSearch.Dequeue();

				string[] files = Directory.GetFiles(currentDirectory, fileName);
				if (files.Length > 0)
				{
					return files[0];
				}

				string[] subDirectories = Directory.GetDirectories(currentDirectory);
				foreach (string subDirectory in subDirectories)
				{
					directoriesToSearch.Enqueue(subDirectory);
				}
			}

			return null;
		}

		static void ViewFileContents(string filePath)
		{
			using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				using (StreamReader reader = new StreamReader(fileStream))
				{
					Console.WriteLine("File content:");
					Console.WriteLine(new string('*', 20));
					string? line;
					while ((line = reader.ReadLine()) != null)
					{
						Console.WriteLine(line);
					}
					Console.WriteLine(new string('*', 20));
				}
			}

			Process.Start("notepad.exe", filePath);
		}

		static void ArchiveFile(string fileName)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			string sourceFilePath = Path.Combine(folderPath, fileName);
			string destinationFilePath = Path.Combine(folderPath, "archive.zip");

			FileStream source = File.OpenRead(sourceFilePath);
			FileStream destination = File.Create(destinationFilePath);

			GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

			int theByte = source.ReadByte();
			while (theByte != -1)
			{
				compressor.WriteByte((byte)theByte);
				theByte = source.ReadByte();
			}

			compressor.Close();
		}
	}
}