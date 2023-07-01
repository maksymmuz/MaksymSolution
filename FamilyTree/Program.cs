//using FamilyTree;
//using System.Linq;
//using System.Threading.Channels;

//var linkedList = new LinkedList_<string>("1");

//linkedList.Add("2");
//linkedList.Add("3");
//linkedList.Add("4");
//linkedList.Add("5");
//linkedList.Add("6");

//linkedList.Loop(x => Console.WriteLine(x));

//foreach (var item in linkedList)
//{
//	Console.WriteLine(item);
//}

//Console.WriteLine(new string('*', 20));

//var duplexLinkedList = new DuplexLinkedList<string>();

//duplexLinkedList.Add("1");
//duplexLinkedList.Add("2");
//duplexLinkedList.Add("3");
//duplexLinkedList.Add("4");
//duplexLinkedList.Add("5");
//duplexLinkedList.Add("6");

//Console.WriteLine(new string('*', 20));

//foreach (var item in duplexLinkedList)
//{
//	Console.WriteLine(item);
//}

//Console.WriteLine(new string('*', 20));

//duplexLinkedList.Remove("2");

//foreach (var item in duplexLinkedList)
//{
//	Console.WriteLine(item);
//}

//Console.WriteLine(new string('*', 20));

//var reverse = duplexLinkedList.Reverse();

//foreach (var item in reverse)
//{
//	Console.WriteLine(item);
//}
// ********************************************************************
// ********************************************************************


using FamilyTree;
using System.Text;

TreeNode<string> root = new TreeNode<string>("root");
{
	TreeNode<string> node0 = root.AddChild("node0");
	TreeNode<string> node1 = root.AddChild("node1");
	TreeNode<string> node2 = root.AddChild("node2");
	{
		TreeNode<string> node20 = node2.AddChild(null);
		TreeNode<string> node21 = node2.AddChild("node21");
		{
			TreeNode<string> node210 = node21.AddChild("node210");
			TreeNode<string> node211 = node21.AddChild("node211");
		}
	}
	TreeNode<string> node3 = root.AddChild("node3");
	{
		TreeNode<string> node30 = node3.AddChild("node30");
	}
}

ShowTree(root);

// Search
string nameForSearch = "210";
Console.WriteLine("Search for: " + nameForSearch);
TreeNode<string> found = root.FindTreeNode(node => node.Data != null && node.Data.Contains(nameForSearch));
Console.WriteLine("Found: " + found);

// Delete
string nameForDeleting = "node2";
Console.WriteLine("Deleing item " + nameForDeleting);
TreeNode<string> deleted = root.FindTreeNode(node => node.Data != null && node.Data == nameForDeleting);

if (deleted != default && !deleted.IsRoot)
{
	deleted.Parent.RemoveChild(deleted);
	Console.WriteLine("Tree after deleting");
	ShowTree(root);
}
else Console.WriteLine("Can't delete item " + nameForDeleting);

Console.ReadKey();

static void ShowTree(TreeNode<string> root)
{
	foreach (TreeNode<string> node in root)
	{
		string indent = CreateIndent(node.Level);
		Console.WriteLine(indent + (node.Data ?? "null"));
	}
}

// method for indents
static string CreateIndent(int depth)
{
	StringBuilder sb = new StringBuilder();
	for (int i = 0; i < depth; i++)
		sb.Append(' ');

	return sb.ToString();
}