using System.Collections;

namespace FamilyTree
{
	internal class LinkedList_<T> : IEnumerable
	{
		public LinkedList_(T headData)
		{
			Head = new Node<T>(headData);
		}

		public Node<T> Head { get; set; }

		public void Add(T data)
		{
			Node<T> current = Head;

			while (current.Next != null)
			{
				current = current.Next;
			}

			current.Next = new Node<T>(data);
		}

		public void Loop(Action<object> action)
		//public void Loop()
		{
			Node<T> current = Head;

			while (current != null)
			{
				action(current.Data);
				// Console.WriteLine(current.Data);
				current = current.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			Node<T> current = Head;

			while (current != null)
			{
				yield return current.Data;
				// Console.WriteLine(current.Data);
				current = current.Next;
			}
		}
	}
}
