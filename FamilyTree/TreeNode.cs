using System.Collections;

namespace FamilyTree
{
	internal class TreeNode<T> : IEnumerable<TreeNode<T>> //Узел дерева
	{
		public T Data { get; set; } //Данные
		public TreeNode<T> Parent { get; set; } //Родитель
		public ICollection<TreeNode<T>> Children { get; set; } //Потомки

		public bool IsRoot//Это корень?
		{
			get { return Parent == null; }
		}

		public bool IsLeaf //Это лист?
		{
			get { return Children.Count == 0; }
		}

		public int Level //Уровень в дереве?
		{
			get
			{
				if (this.IsRoot) return 0;
				return Parent.Level + 1;
			}
		}
		public TreeNode(T data) //Конструктор
		{
			this.Data = data;
			this.Children = new LinkedList<TreeNode<T>>();
			this.ElementsIndex = new LinkedList<TreeNode<T>>();
			this.ElementsIndex.Add(this);
		}

		public TreeNode<T> AddChild(T child)//Добавить потомка
		{
			TreeNode<T> childNode = new TreeNode<T>(child) { Parent = this };
			this.Children.Add(childNode);
			this.RegisterChildForSearch(childNode);
			return childNode;
		}

		public bool RemoveChild(TreeNode<T> childNode)//Удалить потомка
		{
			bool result = this.Children.Remove(childNode);
			this.UnRegisterChildForSearch(childNode);
			return result;
		}

		public override string ToString()//Преобразовать в строку
		{
			return Data != null ? Data.ToString() : "[data null]";
		}

		#region searching
		private ICollection<TreeNode<T>> ElementsIndex { get; set; }

		private void RegisterChildForSearch(TreeNode<T> node)
		{
			ElementsIndex.Add(node);
			if (Parent != null) Parent.RegisterChildForSearch(node);
		}

		private void UnRegisterChildForSearch(TreeNode<T> node)
		{
			ElementsIndex.Remove(node);
			if (Parent != null) Parent.UnRegisterChildForSearch(node);
		}

		public TreeNode<T> FindTreeNode(Func<TreeNode<T>, bool> predicate)
		{
			return this.ElementsIndex.FirstOrDefault(predicate);
		}
		#endregion

		#region iterating
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public IEnumerator<TreeNode<T>> GetEnumerator()
		{
			yield return this;
			foreach (var directChild in this.Children)
			{
				foreach (var anyChild in directChild)
					yield return anyChild;
			}
		}
		#endregion
	}
}
