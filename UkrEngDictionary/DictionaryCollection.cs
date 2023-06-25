using System.Collections;

namespace UkrEngDictionary
{
	internal class DictionaryCollection : IEnumerable
	{
		Dictionary<string, Translation> Dictionary { get; set; }

		public DictionaryCollection()
		{
			Dictionary = new Dictionary<string, Translation>();
		}

		public void Add(string key, Translation value)
		{
			Dictionary.Add(key, value);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			foreach (var item in Dictionary)
			{
				yield return item;
			}
		}

		//public IEnumerator GetEnumerator()
		//{
		//	return ((IEnumerable)Dictionary).GetEnumerator();
		//}
	}
}
