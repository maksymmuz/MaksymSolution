using System.Collections;
using System.Collections.Specialized;

namespace SystemCollections
{
	internal static class Program
	{
		static void Main(string[] args)
		{
			#region Task2
			/**
			 * Домашнє завдання 2
			 * Завдання 2
			 * Створіть колекцію, до якої можна додавати покупців та категорію придбаної ними продукції. 
			 * З колекції можна отримувати категорії товарів, які купив покупець або за категорією визначити покупців.
			 */

			Buyer buyer1 = new() { Name = "buyer1", Age = 20 };
			Buyer buyer2 = new() { Name = "buyer2", Age = 30 };
			Buyer buyer3 = new() { Name = "buyer3", Age = 30 };
			Buyer buyer4 = new() { Name = "buyer3", Age = 50 };

			List<string>? buyerCategory1 = new() { "Technic", };
			List<string>? buyerCategory2 = new() { "Food", "Books", };
			List<string>? buyerCategory3 = new() { "Food", "Technic", "Books", };

			var buyers = new Dictionary<Buyer, List<string>>
			{
				{ buyer1, buyerCategory1 },
				{ buyer2, buyerCategory2 },
				{ buyer3, buyerCategory3 }
			};

			var categoryOfBuyer1 = buyers.Where(b => b.Key.Name == "buyer1");
			var categoryOfBuyer2 = buyers.Where(b => b.Key.Name == "buyer2");
			var categoryOfBuyer3 = buyers.Where(b => b.Key.Name == "buyer3");

			var buyerByCategory = buyers.Where(c => !c.Value.Contains("Food"));
			#endregion

			#region Task3
			/**
			 * Домашнє завдання 2
			 * Завдання 3
			 * Декількома способами створіть колекцію, в якій можна зберігати тільки цілі та речові значення, 
			 * на кшталт «рахунок підприємства – доступна сума» відповідно.
			 */

			Dictionary<int, decimal> counts1 = new()
			{
				{ 111, 10000.50m },
				{ 222, 5000.25m },
				{ 333, 7500.75m }
			};

			SortedDictionary<int, double> counts2 = new()
			{
				{ 111, 10000.50d },
				{ 222, 5000.25d },
				{ 333, 7500.75d }
			};
			#endregion

			#region Task4
			/**
			 * Домашнє завдання 2
			 * Завдання 4
			 * Створіть колекцію типу OrderedDictionary та реалізуйте у ній можливість порівняння значень.
			 */

			var orderedDictionary = new OrderedDictionary()
			{
				{ "111", 12 },
				{ "333", "12" },
				{ "444", "123" },
				{ "555", "123" }
			};

			var flag1 = orderedDictionary["111"].Comparer(orderedDictionary[0]);
			var flag3 = orderedDictionary["333"].Comparer(orderedDictionary[3]);
			var flag4 = orderedDictionary["555"].Comparer(orderedDictionary["444"]);
			#endregion

			#region Task6
			/**
			 * Домашнє завдання 2
			 * Завдання 6 
			 * Використовуючи клас SortedList, створіть невелику колекцію та виведіть на екран 
			 * значення пар «ключ-значення» спочатку в алфавітному порядку, а потім у зворотному.
			 */

			SortedList sortedList = new()
			{
				{ "ccc", "333" },
				{ "eee", "555" },
				{ "aaa", "111" },
				{ "ddd", "444" },
				{ "bbb", "222" }
			};

			Console.WriteLine("Sorted list in ascending order");
			for (int i = 0; i < sortedList.Count; i++)
			{
				Console.WriteLine("Key: {0}, Value: {1}", sortedList.GetKey(i), sortedList.GetByIndex(i));
			}

			Console.WriteLine("\r\nSorted list in descending order");
			for (int i = sortedList.Count - 1; i >= 0; i--)
			{
				Console.WriteLine("Key: {0}, Value: {1}", sortedList.GetKey(i), sortedList.GetByIndex(i));
			}
			#endregion
		}

		static bool Comparer(this object a, object b) => a.Equals(b);
	}
}