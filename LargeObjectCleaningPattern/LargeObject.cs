namespace LargeObjectCleaningPattern
{
	internal class LargeObject : IDisposable
	{
		private int[] largeArray;
		private bool disposed = false;

		public LargeObject()
		{
			largeArray = new int[10_000_000];
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this); // Do not call the destructor.
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					// additional resource release actions can be performed as needed

					Console.WriteLine("The database connection is closed.");
				}

				// Release managed resources (array object)
				largeArray = null;
				disposed = true;
			}
		}

		~LargeObject()
		{
			Dispose(false);
		}
	}
}
