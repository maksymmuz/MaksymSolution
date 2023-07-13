using System.Globalization;

namespace Temperature
{
	public class TemperatureConverter : IFormattable
	{
		private decimal temperature;

		public TemperatureConverter(decimal temperature)
		{
			if (temperature < -273.15m)
			{
				throw new ArgumentOutOfRangeException(
					string.Format("{0} is less than absolute zero.", temperature));
			}
			this.temperature = temperature;
		}

		public decimal Celsius
		{
			get { return temperature; }
		}

		public decimal Fahrenheit
		{
			get { return temperature * 9 / 5 + 32; }
		}

		public decimal Kelvin
		{
			get { return temperature + 273.15m; }
		}

		public override string ToString()
		{
			return this.ToString("G", CultureInfo.CurrentCulture);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			if (string.IsNullOrEmpty(format))
				format = "G";

			if (provider == null)
				provider = CultureInfo.CurrentCulture;

			switch (format.ToUpperInvariant())
			{
				case "G":
				case "C":
					return temperature.ToString("F2", provider) + " °C";
				case "F":
					return Fahrenheit.ToString("F2", provider) + " °F";
				case "K":
					return Kelvin.ToString("F2", provider) + " K";
				default:
					throw new FormatException(string.Format("The {0} format string is not supported.", format));
			}
		}
	}
}