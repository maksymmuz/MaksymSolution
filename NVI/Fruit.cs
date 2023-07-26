namespace NVI
{
	public class Fruit
	{
		public void Eat()
		{
			this.Consume();
		}

		// The basic logic of fruit consumption
		protected virtual void Consume()
		{
			Console.WriteLine("I eat fruit");
		}
	}
}
