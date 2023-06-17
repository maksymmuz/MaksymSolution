namespace SystemCollections
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Task2
			Buyer buyer1 = new() { Name = "buyer1" };
			Buyer buyer2 = new() { Name = "buyer2" };
			Buyer buyer3 = new() { Name = "buyer3" };

			List<string>? buyerCategory1 = new() { "Technic", };
			List<string>? buyerCategory2 = new() { "Food", "Books", };
			List<string>? buyerCategory3 = new() { "Food", "Technic", "Books", };

			var buyers = new Dictionary<Buyer, List<string>>
			{
				{ buyer1, buyerCategory1 },
				{ buyer2, buyerCategory2 },
				{ buyer3, buyerCategory3 }
			};

			var categoryOfBuyer1 = buyers.Where(b => b.Key.Name == "buyer1");
			var categoryOfBuyer2 = buyers.Where(b => b.Key.Name == "buyer2");
			var categoryOfBuyer3 = buyers.Where(b => b.Key.Name == "buyer3");

			var buyerByCategory = buyers.Where(c => !c.Value.Contains("Food"));
			#endregion

			#region Task3
			Dictionary<int, decimal> counts1 = new()
			{
				{ 111, 10000.50m },
				{ 222, 5000.25m },
				{ 333, 7500.75m }
			};

			SortedDictionary<int, double> counts2 = new()
			{
				{ 111, 10000.50d },
				{ 222, 5000.25d },
				{ 333, 7500.75d }
			};
			#endregion
		}
	}
}