using HelpLibrary;
using System.Text.RegularExpressions;

namespace Receipt
{
	internal class CheckProcessing : IFormattable
	{
		Dictionary<string, decimal> _productNameWithPrice;
		readonly string[]? _receiptContent;

		public CheckProcessing(string path)
		{
			_receiptContent = InputOutput.ReadLinesFromFile(path);
			_productNameWithPrice = new Dictionary<string, decimal>();
		}

		public string ToString(string? format, IFormatProvider? formatProvider)
		{
			this.ParseReceipt();

			foreach (KeyValuePair<string, decimal> item in _productNameWithPrice)
			{
				Console.WriteLine($"{item.Key} {item.Value.ToString(format, formatProvider)}");
			}

			Console.WriteLine(new string('*', 30));

			return "Success!";
		}

		public void ParseReceipt()
		{
			try
			{
				foreach (string line in _receiptContent)
				{
					decimal price = 0m;
					string productName = null;

					Match matches = Regex.Match(line, @"\d{1,6}\.\d{2}");

					if (matches.Success)
					{
						_ = decimal.TryParse(matches.Value, out price);

						int startIndexOfPrice = line.IndexOf(matches.Value);

						if (startIndexOfPrice != -1)
						{
							productName = line.Remove(startIndexOfPrice).Trim();
						}

						_productNameWithPrice[productName] = price;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred: " + ex.Message);
			}
		}
	}
}
