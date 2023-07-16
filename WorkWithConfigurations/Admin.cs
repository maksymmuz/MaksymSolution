using HelpLibrary;
using System.Text.Json;

namespace WorkWithConfigurations
{
	internal class Admin
	{
		ConsoleConfigModel _config;

		public Admin()
		{
			_config = new ConsoleConfigModel();
		}

		void GetInfoFromAdminUser()
		{
			Console.WriteLine("Enter WindowWidth from 30 to 150: ");
			_config.WindowWidth = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter WindowHeight from 10 to 50: ");
			_config.WindowHeight = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter ForegroundColor Red, Yellow, DarkCyan, Blue: ");
			_config.ForegroundColor = Enum.Parse<ConsoleColor>(Console.ReadLine());

			Console.WriteLine("Enter BackgroundColor Red, Yellow, DarkCyan, Blue: ");
			_config.BackgroundColor = Enum.Parse<ConsoleColor>(Console.ReadLine());
		}

		void CreateAndFillConfigFile()
		{
			InputOutput.CreateFile("config.json");
			string json = JsonSerializer.Serialize(_config, new JsonSerializerOptions { WriteIndented = true });
			string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
			InputOutput.WriteToFile(configFilePath, json);

			Console.WriteLine("Configuration data is written to the file.");
		}

		public void CreteConfigFile()
		{
			GetInfoFromAdminUser();
			CreateAndFillConfigFile();
		}
	}
}
