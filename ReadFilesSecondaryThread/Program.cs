using HelpLibrary;

/**
 * Домашнє завдання 11
 * Завдання 2
 * Створіть консольну програму, яка в різних потоках зможе отримати доступ до 2-х файлів.
 * Зчитайте з цих файлів вміст і спробуйте записати отриману інформацію в третій файл.
 * Читання/запис мають здійснюватися одночасно у кожному з дочірніх потоків.
 * Використовуйте блокування потоків для того, щоб досягти коректного запису в кінцевий файл.
 */
internal class Program
{
	private static readonly object fileLock = new();

	private static void Main()
	{
		Thread thread1 = new Thread(ReadAndWriteToFile);
		Thread thread2 = new Thread(ReadAndWriteToFile);

		thread1.Start("file1.txt");
		thread2.Start("file2.txt");
	}

	private static void ReadAndWriteToFile(object filename)
	{
		string inputFileName = filename.ToString();
		string outputFileName = "output.txt";

		try
		{
			string content;
			lock (fileLock)
			{
				content = InputOutput.ReadFromFile(inputFileName);
			}

			Thread.Sleep(50);
			lock (fileLock)
			{
				InputOutput.WriteToFile(outputFileName, content, true);
			}

			Console.WriteLine(
				$"Thread {Thread.CurrentThread.ManagedThreadId}: read from {inputFileName} and write to {outputFileName}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error in the thread {Thread.CurrentThread.ManagedThreadId}: {ex.Message}");
		}
	}
}