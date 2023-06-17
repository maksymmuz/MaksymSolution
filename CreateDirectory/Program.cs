/**
* Завдання 6
* Створіть на диску 100 директорій із іменами від Folder_0 до Folder_99, потім видаліть їх.
*/

var desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
var rootDirectory = $"{desktopDirectory}\\ForExperiments\\321";

CreateDirectories(100);
CreateNestedDirectories(100);
RemoveDirectories(rootDirectory, true);

void CreateDirectories(int numberOfDirectories)
{
	try
	{
		for (int i = 0; i < numberOfDirectories; i++)
		{
			var pathToDirectory = Path.Combine(rootDirectory, "Folder_" + i.ToString());
			Directory.CreateDirectory(pathToDirectory);
		}
	}
	catch (Exception ex)
	{
		Console.WriteLine("Error occurred: " + ex.Message);
	}
}

void CreateNestedDirectories(int numberOfDirectories)
{
	try
	{
		List<string>? partsOfPath = new() { rootDirectory, "Nested" };

		for (int i = 0; i < numberOfDirectories; i++)
		{
			partsOfPath.Add("Folder_" + i.ToString());
			var pathToDirectory = Path.Combine(partsOfPath.ToArray());
			Directory.CreateDirectory(pathToDirectory);
		}
	}
	catch (Exception ex)
	{
		Console.WriteLine("Error occurred: " + ex.Message);
	}
}

void RemoveDirectories(string path, bool recursive = false)
{
	var subDirectories = Directory.GetDirectories(path);
	try
	{
		if (subDirectories.Length > 0)
		{
			foreach (var subDirectory in subDirectories)
			{
				Directory.Delete(subDirectory, recursive);
			}
		}
	}
	catch (Exception ex)
	{
		Console.WriteLine("Error occurred: " + ex.Message);
	}
}