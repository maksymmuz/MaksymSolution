using HelpLibrary;

/**
* Домашнє завдання 12
* Завдання 2
* Перетворіть приклад блокування подій таким чином,
* щоб замість ручної обробки використовувалася автоматична.
*/
internal class Program
{
	private static readonly object lockObject = new();

	public static void Main()
	{
		Thread thread1 = new Thread(ReadAndWriteToFile);
		Thread thread2 = new Thread(ReadAndWriteToFile);

		thread1.Start("file1.txt");
		thread1.Join();

		thread2.Start("file2.txt");
		thread2.Join();
	}

	static void ReadAndWriteToFile(object fileNameObj)
	{
		string? fileName = fileNameObj.ToString();
		string outputFileName = "output.txt";

		string content;
		Monitor.Enter(lockObject);
		try
		{
			content = InputOutput.ReadFromFile(fileName);
		}
		finally
		{
			Monitor.Exit(lockObject);
		}

		Monitor.Enter(lockObject);
		try
		{
			InputOutput.WriteToFile(outputFileName, content, true);
		}
		finally
		{
			Monitor.Exit(lockObject);
		}
	}
}