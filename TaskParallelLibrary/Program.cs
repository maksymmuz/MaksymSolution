namespace TaskParallelLibrary;

/**
 * Домашнє завдання 13
 * Завдання 2
 * Створіть два методи, які виконуватимуться у межах паралельних завдань.
 * Організуйте виклик цих методів за допомогою Invoke таким чином, щоб основний потік програми (метод Main) не зупинив виконання.
 */
internal class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("\nStart Main method");
		Console.WriteLine("\nManagedThreadId main = {0}", Thread.CurrentThread.ManagedThreadId);

		var instance1 = new Thread(Method1);
		var instance2 = new Thread(Method2);

		Parallel.Invoke(instance1.Start, instance2.Start);

		for (int i = 0; i < 80; i++)
		{
			Console.Write("M ");
			Thread.Sleep(30);
		}

		Console.WriteLine("\nMain thread continues its work after Parallel.Invoke");
		Console.WriteLine("\nFinish Main method");
	}

	static void Method1()
	{
		Console.WriteLine("\nManagedThreadId Method1 = {0}", Thread.CurrentThread.ManagedThreadId);
		Console.WriteLine("\nStart method1");

		for (int i = 0; i < 80; i++)
		{
			Console.Write("1 ");
			Thread.Sleep(30);
		}

		Console.WriteLine("\nFinish method1");
	}

	static void Method2()
	{
		Console.WriteLine("\nManagedThreadId Method2 = {0}", Thread.CurrentThread.ManagedThreadId);
		Console.WriteLine("\nStart method2");

		for (int i = 0; i < 80; i++)
		{
			Console.Write("2 ");
			Thread.Sleep(30);
		}

		Console.WriteLine("\nFinish method2");
	}
}