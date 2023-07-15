namespace WorkWithAttributes
{
	internal class ClassObsoleteMethods
	{
		[Obsolete("My custom message: This method is obsolete.")]
		public int ObsoleteSum(int a, int b) => a + b;


		// in this case the code will not compiled due to second Obsolete attribute parameter = true
		// [Obsolete("This method is obsolete. You can use the new one - Print()", true)]
		[Obsolete("This method is obsolete. You can use the new one - Print()")]
		public void ObsoletePrint() 
		{
			Console.WriteLine("Message from ObsoletePrint().");
		}

		public void Print()
		{
			Console.WriteLine("Message from Print().");
		}
	}
}
