namespace UkrEngDictionary
{
	internal class Translation
	{
		public Translation(string translation, bool isEng = true)
		{
			if (!isEng)
			{
				Other = translation;
			}
			Eng = translation;
		}

		public string? Eng { get; set; }

		public string? Other { get; set; }

		public override string? ToString() => Eng is not null ? Eng : Other;
	}
}
