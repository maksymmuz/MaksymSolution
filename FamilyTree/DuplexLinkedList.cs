using System.Collections;

namespace FamilyTree
{
	internal class DuplexLinkedList<T> : IEnumerable<T>
	{
		public DuplexItem<T> Head { get; set; }
		public DuplexItem<T> Tail { get; set; }
		public int Count { get; set; }

		public DuplexLinkedList()
		{
		}

		public DuplexLinkedList(T data)
		{
			var item = new DuplexItem<T>(data);
			Head = item;
			Tail = item;
			Count = 1;
		}

		public void Add(T data)
		{
			var item = new DuplexItem<T>(data);

			if (Count == 0)
			{
				Head = item;
				Tail = item;
				Count = 1;
			}
			else
			{
				Tail.Next = item;
				item.Previous = Tail;
				Tail = item;
				Count++;
			}
		}

		public void Remove(T data)
		{
			var current = Head;

			while (current != null)
			{
				if (current.Data.Equals(data))
				{
					current.Previous.Next = current.Next;
					current.Next.Previous = current.Previous;
					Count--;
					return;
				}

				current = current.Next;
			}
		}

		public DuplexLinkedList<T> Reverse()
		{
			var res = new DuplexLinkedList<T>();

			var current = Tail;

			while (current != null)
			{
				res.Add(current.Data);
				current = current.Previous;
			}

			return res;
		}

		public IEnumerator GetEnumerator()
		{
			var current = Head;

			while (current != null)
			{
				yield return current;
				current = current.Next;
			}
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return (IEnumerator<T>)GetEnumerator();
		}
	}
}
