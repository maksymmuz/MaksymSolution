namespace NVI
{
	public class Apple : Fruit
	{
		// Own implementation for apple
		protected override void Consume()
		{
			Console.WriteLine("I eat an apple");
		}
	}
}
