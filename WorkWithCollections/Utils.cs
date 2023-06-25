using System.Collections;

namespace WorkWithCollections
{
	internal static class Utils
	{
		public static IEnumerable SquaresOfOddNumbers(this IEnumerable array)
		{
			foreach (int item in array)
			{
				if (item % 2 != 0)
				{
					yield return Math.Pow(item, 2);
				}
			}
		}
	}
}
