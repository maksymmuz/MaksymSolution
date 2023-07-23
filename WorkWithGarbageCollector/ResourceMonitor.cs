namespace WorkWithGarbageCollector
{
	internal class ResourceMonitor
	{
		private long _acceptableMemoryUsage;
		static int j = 0;

		public ResourceMonitor(long acceptableMemoryUsage)
		{
			_acceptableMemoryUsage = acceptableMemoryUsage;
		}

		public void CheckMemoryUsage()
		{
			long memoryUsedBytes = GC.GetTotalMemory(false); // false parameter means the GC will not be called before getting the value
			
			if (memoryUsedBytes >= _acceptableMemoryUsage)
			{
				Console.WriteLine($"Warning {j++}: Memory usage ({memoryUsedBytes} bytes) is approaching the acceptable level.");
				GC.Collect();
				GC.WaitForPendingFinalizers();
			}
		}

		public static void AuxiliaryMethod()
		{
			OtherObject[] objects = new OtherObject[100];
			
			for (int i = 0; i < objects.Length; i++)
			{
				objects[i] = new OtherObject();

				long memoryUsedBytes = GC.GetTotalMemory(false); // false parameter means that the GC will not be called before getting the value
				Console.WriteLine("Currently used memory is: {0}", memoryUsedBytes);

				Thread.Sleep(5);
			}
		}

		class OtherObject
		{
			byte[] array = new byte[1024 * 512]; // 512 KB
		}
	}
}
