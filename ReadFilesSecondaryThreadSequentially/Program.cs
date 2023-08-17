using HelpLibrary;

/**
 * Домашнє завдання 11
 * Завдання 4
 * Використовуючи конструкції блокування, модифікуйте останній приклад уроку таким чином,
 * щоб отримати можливість послідовної роботи 3-х потоків.
 */
internal class Program
{
	private static readonly object fileLock = new();

	private static void Main()
	{
		for (int i = 0; i < 20; i++)
		{
			// Create threads
			Thread thread1 = new Thread(ReadAndWriteToFile);
			Thread thread2 = new Thread(ReadAndWriteToFile);
			Thread thread3 = new Thread(ReadAndWriteToFile);

			thread1.Start("file1.txt");
			thread1.Join();

			thread2.Start("file2.txt");
			thread2.Join();

			thread3.Start("file3.txt");
			thread3.Join();

			Console.WriteLine("Operation is complete.");
		}
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

			lock (fileLock)
			{
				InputOutput.WriteToFile(outputFileName, content, true);
			}

			Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: read from {inputFileName} and write to {outputFileName}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error in the thread {Thread.CurrentThread.ManagedThreadId}: {ex.Message}");
		}
	}
}