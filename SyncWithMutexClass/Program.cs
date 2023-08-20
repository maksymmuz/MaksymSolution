/**
 * Домашнє завдання 12
 * Завдання 3
 * Створіть програму, яка може бути запущена лише в одному екземплярі (використовуючи іменований Mutex).
 */
class Program
{
	static readonly Mutex mutex = new Mutex(false, "MyUniqueMutexName");

	static void Main(string[] args)
	{
		Thread[] threads = new Thread[5];

		for (int i = 0; i < 5; i++)
		{
			threads[i] = new Thread(SomeProgram)
			{
				Name = i.ToString()
			};

			threads[i].Start();
		}
	}

	static void SomeProgram()
	{
		mutex.WaitOne();

		Console.WriteLine("\nThe program {0} is running.", Thread.CurrentThread.Name);
		Thread.Sleep(2000);
		Console.WriteLine("The program {0} is complete.", Thread.CurrentThread.Name);

		mutex.ReleaseMutex();
	}
}