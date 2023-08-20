using HelpLibrary;

/**
 * Домашнє завдання 12
 * Завдання 5
 * Створіть Semaphore, що контролює доступу до ресурсу з кількох потоків.
 * Організуйте впорядкований вивід інформації про отримання доступу до спеціального файлу *.log.
 */
internal class Program
{
	static Semaphore semaphore = new Semaphore(1, 1);

	static void Main()
	{
		for (int i = 0; i < 5; i++)
		{
			var thread = new Thread(SomeTask);
			thread.Start(i);
		}
	}

	static void SomeTask(object id)
	{
		int taskId = (int)id;

		try
		{
			Console.WriteLine($"Thread {taskId} is waiting for access to the resource...");

			semaphore.WaitOne();

			Console.WriteLine($"Thread {taskId} gained access to the resource.");

			string logMessage = $"Thread {taskId} writes to the output.log file.";

			InputOutput.WriteToFile("output.log", logMessage, true);

			Console.WriteLine($"Thread {taskId} has completed work with the resource.");
		}
		finally
		{
			semaphore.Release();
		}
	}
}