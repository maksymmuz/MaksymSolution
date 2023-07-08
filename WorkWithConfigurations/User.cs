using Microsoft.Extensions.Configuration;

namespace WorkWithConfigurations
{
	internal class User
	{
		ConsoleConfigModel _consoleConfigModel;
		IConfigurationRoot _configuration;

		public User()
		{
			_consoleConfigModel = new ConsoleConfigModel();
		}

		void GetConfiguration()
		{
			Console.WriteLine("Reading configuration data from JSON file.");

			_configuration = new ConfigurationBuilder()
				.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
				.AddJsonFile("config.json", optional: false, reloadOnChange: true)
				.Build();

			ConfigurationBinder.Bind(_configuration, _consoleConfigModel);
		}

		void ConfigureConsole()
		{
			Console.ForegroundColor = _consoleConfigModel.ForegroundColor;
			Console.BackgroundColor = _consoleConfigModel.BackgroundColor;
			Console.WindowHeight = _consoleConfigModel.WindowHeight;
			Console.WindowWidth = _consoleConfigModel.WindowWidth;
		}

		public void Print()
		{
			Console.WriteLine("Enter some text to print out on the console with Admin's settings: ");
			var text = Console.ReadLine();

			GetConfiguration();
			ConfigureConsole();
			Console.Clear();
			Console.WriteLine("Text from user in new format and window size: \n {0}", text);
		}
	}
}
