using System.Collections;

namespace MonthsCollection
{
	internal class Months : IEnumerable, IEnumerator
	{
		public Month[] MonthsArray { get; }

		int position = -1;

		public Month this[int index]
		{
			get
			{
				try
				{
					return MonthsArray[index - 1];
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

				return MonthsArray[0];
			}
			// set { /* set the specified index to value here */ }
		}

		object IEnumerator.Current => MonthsArray[position];

		// public List<Month> ListOfMonths { get; }

		public Months()
		{
			MonthsArray = new Month[]
			{
				new Month()
				{
					MonthName = "January",
					MonthNumber = 1,
					NumberOfDays = 31,
				},
				new Month()
				{
					MonthName = "February",
					MonthNumber = 2,
					NumberOfDays = 28,
				},
				new Month()
				{
					MonthName = "March",
					MonthNumber = 3,
					NumberOfDays = 31,
				},
				new Month()
				{
					MonthName = "April",
					MonthNumber = 4,
					NumberOfDays = 30,
				},
				new Month()
				{
					MonthName = "May",
					MonthNumber = 5,
					NumberOfDays = 31,
				},
				new Month()
				{
					MonthName = "June",
					MonthNumber = 6,
					NumberOfDays = 30,
				},
				new Month()
				{
					MonthName = "July",
					MonthNumber = 7,
					NumberOfDays = 31,
				},
				new Month()
				{
					MonthName = "August",
					MonthNumber = 8,
					NumberOfDays = 31,
				},
				new Month()
				{
					MonthName = "September",
					MonthNumber = 9,
					NumberOfDays = 30,
				},
				new Month()
				{
					MonthName = "October",
					MonthNumber = 10,
					NumberOfDays = 31,
				},
				new Month()
				{
					MonthName = "November",
					MonthNumber = 11,
					NumberOfDays = 30,
				},
				new Month()
				{
					MonthName = "December",
					MonthNumber = 12,
					NumberOfDays = 31,
				}
			};

			//ListOfMonths = new List<Month>()
			//{
			//	new Month()
			//	{
			//		MonthName = "January",
			//		MonthNumber = 1,
			//		NumberOfDays = 31,
			//	},
			//	new Month()
			//	{
			//		MonthName = "February",
			//		MonthNumber = 2,
			//		NumberOfDays = 28,
			//	},
			//	new Month()
			//	{
			//		MonthName = "March",
			//		MonthNumber = 3,
			//		NumberOfDays = 31,
			//	},
			//	new Month()
			//	{
			//		MonthName = "April",
			//		MonthNumber = 4,
			//		NumberOfDays = 30,
			//	},
			//	new Month()
			//	{
			//		MonthName = "May",
			//		MonthNumber = 5,
			//		NumberOfDays = 31,
			//	},
			//	new Month()
			//	{
			//		MonthName = "June",
			//		MonthNumber = 6,
			//		NumberOfDays = 30,
			//	},
			//	new Month()
			//	{
			//		MonthName = "July",
			//		MonthNumber = 7,
			//		NumberOfDays = 31,
			//	},
			//	new Month()
			//	{
			//		MonthName = "August",
			//		MonthNumber = 8,
			//		NumberOfDays = 31,
			//	},
			//	new Month()
			//	{
			//		MonthName = "September",
			//		MonthNumber = 9,
			//		NumberOfDays = 30,
			//	},
			//	new Month()
			//	{
			//		MonthName = "October",
			//		MonthNumber = 10,
			//		NumberOfDays = 31,
			//	},
			//	new Month()
			//	{
			//		MonthName = "November",
			//		MonthNumber = 11,
			//		NumberOfDays = 30,
			//	},
			//	new Month()
			//	{
			//		MonthName = "December",
			//		MonthNumber = 12,
			//		NumberOfDays = 31,
			//	},
			//};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this;
		}

		bool IEnumerator.MoveNext()
		{
			if (position < MonthsArray.Length - 1)
			{
				position++;
				return true;
			};

			((IEnumerator)this).Reset();
			return false;
		}

		void IEnumerator.Reset()
		{
			position = -1;
		}

		//IEnumerator IEnumerable.GetEnumerator()
		//{
		//	return MonthsArray.GetEnumerator();
		//}
	}
}
