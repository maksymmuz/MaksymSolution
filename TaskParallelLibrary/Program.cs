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
		Console.WriteLine("Start Main method");

		Console.WriteLine("ManagedThreadId main = {0}", Thread.CurrentThread.ManagedThreadId);
		Thread.CurrentThread.IsBackground = true;
		Console.WriteLine("Main IsBackground = {0}", Thread.CurrentThread.IsBackground); // false

		for (int i = 0; i < 80; i++)
		{
			Console.Write("M ");
			Thread.Sleep(20);
		}

		Parallel.Invoke(Method1, Method2);

		Console.WriteLine("\nMain thread continues its work after Parallel.Invoke");
		Console.WriteLine("Finish Main method");
	}

	static void Method1()
	{
		Console.WriteLine("ManagedThreadId Method1 = {0}", Thread.CurrentThread.ManagedThreadId);
		Console.WriteLine("\nStart method1");
		// Thread.CurrentThread.IsBackground = false;
		Console.WriteLine("method1 IsBackground = {0}", Thread.CurrentThread.IsBackground); //false

		for (int i = 0; i < 80; i++)
		{
			Console.Write("1 ");
			Thread.Sleep(20);
		}
		Console.WriteLine("\nFinish method1");
	}

	static void Method2()
	{
		Console.WriteLine("ManagedThreadId Method2 = {0}", Thread.CurrentThread.ManagedThreadId);
		Thread.CurrentThread.IsBackground = false;
		Console.WriteLine("method2 IsBackground = {0}", Thread.CurrentThread.IsBackground); // true

		Console.WriteLine("\nStart method2");
		for (int i = 0; i < 80; i++)
		{
			Console.Write("2 ");
			Thread.Sleep(20);
		}
		Console.WriteLine("\nFinish method2");
	}
}