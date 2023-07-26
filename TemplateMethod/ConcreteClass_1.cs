namespace TemplateMethod
{
	internal class ConcreteClass_1 : TemplateClass
	{
		protected override void LoadBody()
		{
			Console.WriteLine("Load Body somehow from a concrete class_1.");
		}

		protected override void LoadFooter()
		{
			Console.WriteLine("Load Footer somehow from a concrete class_1.");
		}

		protected override void LoadHeader()
		{
			Console.WriteLine("\nLoad Header somehow from a concrete class_1.");
		}
	}
}
